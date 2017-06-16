using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace OutlookAddInOVA
{
    public partial class ThisAddIn
    {
#if DEBUG
        internal const string pathToListCOWorker = "D:\\temp\\Сотрудники1АБ.xlsx";
        internal string usersOVA = "aleks;glaal;vasta;rogva;lihyu;provi;chest";
        internal string currentuser = "aleks";
        internal string currentusermail = "glaal@1ab.ru";
#else
		private const string pathToListCOWorker = "J:\\ABFant80\\ExtProjectABF\\OutlookAddInOVA\\Сотрудники1АБ.xlsx";
		internal string usersOVA = "glaal;vasta;rogva;lihyu;provi;chest";
		internal string currentuser = SystemInformation.UserName;
		internal string currentusermail = SystemInformation.UserName + "@1ab.ru";
#endif
        internal const string strcolName = "FIO;Family;Name;Otchest;Podrazd;Office;Email;GUIDCoWorker;GUIDChief";
        internal string[] colName = strcolName.Split(';');
        internal Outlook.Inspectors inspectors;
        internal Outlook.Explorer currentExplorer = null;
        internal bool currentUserIsOVA = false;

        internal System.Data.DataTable listAllCoWorker;
        internal System.Data.DataTable listMyCoWorker;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            inspectors = this.Application.Inspectors;
            //inspectors.NewInspector +=
            //new Microsoft.Office.Interop.Outlook.InspectorsEvents_NewInspectorEventHandler(Inspectors_NewInspector);
            currentExplorer = this.Application.ActiveExplorer();
            try
            {
                prepareData();
            }
            catch (Exception err)
            {
                CreateZunWithError(err.ToString());
                listAllCoWorker = new System.Data.DataTable();
            }
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Примечание. Outlook больше не выдает это событие. Если имеется код, который
            //    должно выполняться при завершении работы Outlook, см. статью на странице https://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region Код, автоматически созданный VSTO

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion Код, автоматически созданный VSTO

        //void Inspectors_NewInspector(Microsoft.Office.Interop.Outlook.Inspector Inspector)
        //{
        //	Outlook.MailItem mailItem = Inspector.CurrentItem as Outlook.MailItem;
        //	if (mailItem != null)
        //	{
        //		if (mailItem.EntryID == null)
        //		{
        //			mailItem.Subject = "This text was added by using code";
        //			mailItem.Body = "This text was added by using code";
        //		}

        //	}
        //}

        internal string GetAllSMTPAddressForRecipients(Outlook.MailItem myMail)
        {
            string AllEmail = "";
            const string PR_SMTP_ADDRESS =
                "http://schemas.microsoft.com/mapi/proptag/0x39FE001E";
            Outlook.Recipients recips = myMail.Recipients;
            foreach (Outlook.Recipient recip in recips)
            {
                Outlook.PropertyAccessor pa = recip.PropertyAccessor;
                AllEmail +=
                    pa.GetProperty(PR_SMTP_ADDRESS).ToString();
            }
            return AllEmail;
        }

        internal void CreateZunWithError(string sError = "")
        {
            Outlook.MailItem mailItem = (Outlook.MailItem)
            OutlookAddInOVA.Globals.ThisAddIn.Application.CreateItem(Outlook.OlItemType.olMailItem);
            mailItem.Subject = "В работе надстройки OutlookAddInOVA возникла ошибка";
            mailItem.To = "glaal@1ab.ru";
            mailItem.Body = sError;
            mailItem.Importance = Outlook.OlImportance.olImportanceHigh;
            mailItem.Send();
        }

        #region Первоначальное заполнение данными

        private System.Data.DataTable GetListCoWorker()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Clear();
            Excel.Application appExcel = new Excel.Application();
            appExcel.Visible = false;
            Excel.Workbook workbook = appExcel.Workbooks.Open(pathToListCOWorker, Type.Missing, Type.Missing, Type.Missing, "n2mZ8ihQ");
            Excel.Worksheet worksheet = workbook.Sheets[1];
            Excel.Range range = worksheet.UsedRange;

            object[,] data = range.Value2;
            int cCnt = range.Columns.Count;
            int rCnt = range.Rows.Count;

            int row;
            int col;

            for (col = 1; col <= cCnt; col++)
            {
                dt.Columns.Add(colName[col - 1], typeof(string));
            }
            for (row = 1; row <= rCnt; row++)
            {
                dt.Rows.Add();
                for (col = 1; col <= cCnt; col++)
                {
                    dt.Rows[row - 1][col - 1] = data[row, col];
                }
            }
            appExcel.ActiveWorkbook.Close(false);
            Marshal.ReleaseComObject(range);
            range = null;
            Marshal.ReleaseComObject(worksheet);
            worksheet = null;
            Marshal.ReleaseComObject(workbook);
            workbook = null;

            appExcel.Quit();
            Marshal.ReleaseComObject(appExcel);
            appExcel = null;
            GC.Collect();

            return dt;
        }

        private void prepareData()
        {
            //Заполним параметры при необходимости
            FillParametrs();
            //Заполним таблицу сотрудниками из Excel
            listAllCoWorker = GetListCoWorker();
            //Выберим только с подразделением УК ОВА
            System.Data.DataRow[] listCoWorkerUkOva;
            listCoWorkerUkOva = listAllCoWorker.Select("Podrazd='УК ОВА'");
            if (listCoWorkerUkOva.Count() > 0)
            {
#if DEBUG
                usersOVA = "aleks;";
#else
				usersOVA = "";
#endif
                foreach (System.Data.DataRow rowCoWorker in listCoWorkerUkOva)
                {
                    usersOVA += rowCoWorker["EMail"] + ";";
                }
            }
            //Выберим тех где текущий пользователь Руководитель
            //Найдем GUID Руководителя
            System.Data.DataRow[] GUIDChief;
            GUIDChief = listAllCoWorker.Select("Email='" + currentusermail + "'");
            string guidchief = "";
            if (GUIDChief.Count() > 0)
            {
                guidchief = GUIDChief[0]["GUIDCoWorker"].ToString();
            }
            if (guidchief != "")
            {
                System.Data.DataRow[] listRowsMyCoWorker;
                listRowsMyCoWorker = listAllCoWorker.Select("GUIDChief='" + guidchief + "'");
                listMyCoWorker = listAllCoWorker.Clone();
                //Добавлю руководителя
                object[] row = GUIDChief[0].ItemArray;
                listMyCoWorker.Rows.Add(row);
                //listMyCoWorker.LoadDataRow(listRowsMyCoWorker, true);
                foreach (System.Data.DataRow dr in listRowsMyCoWorker)
                {
                    row = dr.ItemArray;
                    listMyCoWorker.Rows.Add(row);
                }
            }

            if (usersOVA.Contains(currentuser))
            {
                currentUserIsOVA = true;
            }
        }

        private void FillParametrs()
        {
            if (Properties.Settings.Default.prmSmartExecutorFormulirovka == "")
            {
                Properties.Settings.Default.prmSmartExecutorFormulirovka = "Задача созданна автоматически из MS Outlook." + Environment.NewLine + "Подробности в приложенном письме.";
            }
            if (Properties.Settings.Default.prmSmartExecutorKriterii == "")
            {
                Properties.Settings.Default.prmSmartExecutorKriterii = "Задача выполнена, сдана руководителю на проверку.";
            }
            if (Properties.Settings.Default.prmSmartFastFormulirovka == "")
            {
                Properties.Settings.Default.prmSmartFastFormulirovka = "Задача созданна автоматически из MS Outlook." + Environment.NewLine + "Подробности в приложенном письме.";
            }
            if (Properties.Settings.Default.prmSmartFastKriterii == "")
            {
                Properties.Settings.Default.prmSmartFastKriterii = "Задача выполнена, сдана руководителю на проверку.";
            }
        }

#endregion New Region
    }
}