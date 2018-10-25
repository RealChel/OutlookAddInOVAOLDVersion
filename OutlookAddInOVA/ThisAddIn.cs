using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Outlook = Microsoft.Office.Interop.Outlook;
using WithABF = OutlookAddInOVA.InteractionWithABF;

namespace OutlookAddInOVA
{
    public partial class ThisAddIn
    {
#if DEBUG
        internal const string pathToListCOWorker = "D:\\temp\\Сотрудники1АБ.xlsx";
        //internal string usersOVA = "aleks;glaal;vasta;rogva;lihyu;provi;chest";
        internal string usersOVA = "glaal;vasta;rogva;lihyu;provi;chest";
        internal string[] arrUsersOVA;
        internal string currentuser = "aleks";
        internal string currentusermail = "glaal@1ab.ru";
#else
		private const string pathToListCOWorker = "J:\\ABFant80\\ExtProjectABF\\OutlookAddInOVA\\Сотрудники1АБ.xlsx";
		internal string usersOVA = "glaal;vasta;rogva;lihyu;provi;chest";
        internal string[] arrUsersOVA;
		internal string currentuser = SystemInformation.UserName;
		internal string currentusermail = SystemInformation.UserName + "@1ab.ru";
#endif
        internal const string strcolName = "FIO;Family;Name;Otchest;Podrazd;Office;Email;GUIDCoWorker;GUIDChief";
        internal string[] colName = strcolName.Split(';');
        internal Outlook.Inspectors inspectors;
        internal Outlook.Explorer currentExplorer = null;
        internal bool currentUserIsOVA = false;
        /// <summary>
        /// Объект 1С
        /// </summary>
        internal V83.COMConnector com1s;
        
        /// <summary>
        /// Объект Coonection возвращаемый функцией 1С Connect(connectString)
        /// </summary>
        internal dynamic ConnetionTo1C;
        private System.ComponentModel.BackgroundWorker BackgroundWorkerABF;
        internal bool doCreateZUn;
        internal NotifyIcon GlobalNotifyIcon;
        internal ContextMenuStrip myContextMenu;
        //internal ToolStripMenuItem copyZUn;
        internal string LastCreateZunResult = "";

        internal System.Data.DataTable listAllCoWorker;
        internal System.Data.DataTable listMyCoWorker;

      

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            inspectors = this.Application.Inspectors;
            //inspectors.NewInspector +=
            //new Microsoft.Office.Interop.Outlook.InspectorsEvents_NewInspectorEventHandler(Inspectors_NewInspector);
            //this.Application.ItemSend += ThisAddInItemSend;
            

           // currentExplorer = this.Application.ActiveExplorer();
            try
            {
                prepareData();
            }
            catch (Exception err)
            {
                WithABF.CreateMailWithError(err.ToString());
                listAllCoWorker = new System.Data.DataTable();
            }

            BackgroundWorkerABF = new System.ComponentModel.BackgroundWorker();
            BackgroundWorkerABF.DoWork += BackgroundWorkerABFStart;
            BackgroundWorkerABF.RunWorkerCompleted += BackgroundWorkerABFComplet;

            GlobalNotifyIcon = new NotifyIcon();
            GlobalNotifyIcon.Click += copyZUn_Click;
        }

        private void Application_ItemLoad(object Item)
        {
            throw new NotImplementedException();
        }

        private void ThisAddInItemSend(object Item, ref bool Cancel)
        {
            //Outlook.MailItem mailItem = (Outlook.MailItem)Item;
            //WindowFormRegionCollection formRegions;
            //try
            //{
            //    //своегообразного рода защита.
            //    //создание ЗУн возможна только если письмо отправляеться из отдельного окна.
            //    if (Globals.ThisAddIn.Application.ActiveWindow() is Microsoft.Office.Interop.Outlook.Explorer)
            //    {
            //        return;
            //    }
              

            //    try
            //    {
            //        formRegions =
            //       Globals.FormRegions
            //           [Globals.ThisAddIn.Application.ActiveInspector()];
            //    }
            //    catch (Exception e)
            //    {
            //        formRegions =
            //       Globals.FormRegions
            //           [Globals.ThisAddIn.Application.ActiveWindow()];
            //    }

            //    if (formRegions.FormRegionOVA.CheckedDoZunOVA)
            //    {
            //        if (doCreateZunInOVA)
            //        {
            //            MessageBox.Show("Вы уже отправляете письмо с созданием ЗУн.\n Пожалуйста дождитесь сообщения о создании ЗУн, и повторите отправку.", "Отпавка письма с созданием ЗУн");
            //            Cancel = true;
            //            return;
            //        }

            //        string lastError = "";
            //        string pathToMsgFile = WithABF.SaveEmailToMsg(mailItem, ref lastError);
            //        if (pathToMsgFile == "")
            //        {
            //            MessageBox.Show(lastError, "Возникла ошибка");
            //            WithABF.CreateMailWithError(lastError);
            //        }
            //        else
            //        {
            //            doCreateZunInOVA = true;
            //            LastCreateZunResult = "";
            //            //ParamsZUn paramsZUn = new ParamsZUn(true, formRegions.FormRegionOVA.TextZUn,"", pathToMsgFile, "", "1.Любые вопросы в ОВА (выбирайте этот разрез, если есть сомнения в выборе другого разреза)", DateTime.Now, false, "", "");
            //            BackgroundWorkerABF.RunWorkerAsync(FillParamsForZUn(formRegions.FormRegionOVA, mailItem, pathToMsgFile));
            //        }
            //    }
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show("При создании ЗУн возникла ошибка\nИнформация об ошибки отправлена в УК ОВА", "Не удалось создать ЗУн");
            //    WithABF.CreateMailWithError(e.ToString());
            //}
        }

        //private ParamsZUn FillParamsForZUn( FormRegionOVA formRegions,  Outlook.MailItem mailItem,string pathToMsgFile)
        //{
        //    ParamsZUn paramsZUN = new ParamsZUn();
        //    string textZUn = formRegions.TextZUn;
        //    string commentExecutor = formRegions.CommentExecutor;
        //    if (String.IsNullOrEmpty(textZUn) || textZUn.Contains("При необходимости введите текст поручения ЗУн"))
        //    {
        //        textZUn = "Заявка создана автоматически из MS Outlook.\nПодробности в приложенном письме.";
        //    }
        //    //if (commentExecutor.Contains("При необходимости введите текст поручения ЗУн") || String.IsNullOrEmpty(textZUn))
        //    //{
        //    //    commentExecutor = "Заявка создана автоматически из MS Outlook.\nПодробности в приложенном письме.";
        //    //}

        //    paramsZUN.textZun = textZUn;
        //    paramsZUN.executorZUn = formRegions.Executor;
        //    paramsZUN.commentExecutorZUn = formRegions.CommentExecutor;
        //    paramsZUN.importan = formRegions.Important;
        //    paramsZUN.dopRazrez = formRegions.DopRazrez;
        //    paramsZUN.executorZUn = formRegions.Executor;
        //    paramsZUN.doDate = formRegions.DoDate;
        //    paramsZUN.pathToFile = pathToMsgFile;
        //    paramsZUN.approval = formRegions.ApproveList; 

        //    return paramsZUN;
        //}

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

        private void Inspectors_NewInspector(Microsoft.Office.Interop.Outlook.Inspector Inspector)
        {
            //Outlook.MailItem mailItem = Inspector.CurrentItem as Outlook.MailItem;

            //if (!Properties.Settings.Default.prmHideFormRegion)
            //{
            //    mailItem.PropertyChange += ThisAddInPropertyChange;
            //    //ShowForRegion(Inspector);
            //}
        }

        private void ThisAddInPropertyChange(string name)
        {
            
            //if (name == "To")
            //{
            //    ShowForRegion(Globals.ThisAddIn.Application.ActiveInspector());
            //}
        }
        private void ShowForRegion(Microsoft.Office.Interop.Outlook.Inspector Inspector)
        {
            //if (Inspector is null)
            //{ return; }

            //Outlook.MailItem mailItem;
            //try
            //{
                
            //    try
            //    {
            //        //mailItem = Globals.ThisAddIn.Application.ActiveInspector().CurrentItem as Outlook.MailItem;
            //        mailItem = Inspector.CurrentItem as Outlook.MailItem;
            //        //mailItem.PropertyChange -= ThisAddInPropertyChange;
            //        string allmail = GetAllSMTPAddressForRecipients(mailItem);
            //        bool findUserOVA = false;
            //        foreach (string userOVA in arrUsersOVA)
            //        {
            //            if (allmail.Contains(userOVA))
            //            {
            //                findUserOVA = true;
            //            }
            //        }

            //        WindowFormRegionCollection formRegions =
            //        Globals.FormRegions
            //            [Inspector];
            //        formRegions.FormRegionOVA.OutlookFormRegion.Visible = findUserOVA;
            //    }
            //    catch (Exception e)
            //    {
            //        MessageBox.Show(e.ToString());
            //    }
            //    //finally
            //    //{
            //    //    mailItem.PropertyChange += ThisAddInPropertyChange;
            //    //}
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.ToString());
            //}
        }
        internal string GetAllSMTPAddressForRecipients(Outlook.MailItem myMail)
        {
            string AllEmail = "";
            const string PR_SMTP_ADDRESS =    "http://schemas.microsoft.com/mapi/proptag/0x39FE001E";
            Outlook.Recipients recips = myMail.Recipients;
            foreach (Outlook.Recipient recip in recips)
            {
#if DEBUG
                AllEmail += recip.Address + ";";

#else
            Outlook.PropertyAccessor pa = recip.PropertyAccessor;
                AllEmail +=
                    pa.GetProperty(PR_SMTP_ADDRESS).ToString();
#endif
            }
            return AllEmail;
        }

        #region Первоначальное заполнение данными

        private System.Data.DataTable GetListCoWorker()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Clear();
            Excel.Application appExcel = new Excel.Application();
            appExcel.Visible = false;
            //Excel.Workbook workbook = appExcel.Workbooks.Open(pathToListCOWorker, Type.Missing, Type.Missing, Type.Missing, "n2mZ8ihQ");
            Excel.Workbook workbook = appExcel.Workbooks.Open(pathToListCOWorker, Type.Missing, Type.Missing, Type.Missing);
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
                //usersOVA = "";
#else
				usersOVA = "";
#endif
                foreach (System.Data.DataRow rowCoWorker in listCoWorkerUkOva)
                {
                    usersOVA += rowCoWorker["EMail"] + ";";
                }
                usersOVA = usersOVA.Substring(0, usersOVA.Length - 1);
            }
            arrUsersOVA = usersOVA.Split(';');
            //Выберим по GUID тех где текущий пользователь Руководитель
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
                //все строки с руководителем по ГУИД
                listRowsMyCoWorker = listAllCoWorker.Select("GUIDChief='" + guidchief + "'");
                listMyCoWorker = listAllCoWorker.Clone();
                //Нужна первая пустая строка(т.к. я не нашел способа не заполнять комбобоксы на формах, система всегда делает первую строку)
                
                listMyCoWorker.Rows.Add();
                //Добавлю руководителя
                object[]  row = GUIDChief[0].ItemArray;
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

        #endregion Первоначальное заполнение данными

        #region Фоновые задания

        internal void BackgroundWorkerABFStart(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ParamsZUn paramsZUn = (ParamsZUn)e.Argument;

            if (!InteractionWithABF.Create_ZUn(paramsZUn))
            {
                MessageBox.Show(paramsZUn.errorCreateZun + "\n" + paramsZUn.createZunResult);
                paramsZUn.doComplit = false;
            }
            else
            {
                paramsZUn.doComplit = true;
            }
            e.Result = paramsZUn;
        }

        internal void BackgroundWorkerABFComplet(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            ParamsZUn paramsZUn = (ParamsZUn)e.Result;
            if (paramsZUn.doComplit)
            {
                GlobalNotifyIcon.Icon = Properties.Resources.ico_1ab;
                GlobalNotifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                GlobalNotifyIcon.BalloonTipText = paramsZUn.createZunResult;
                GlobalNotifyIcon.BalloonTipTitle = "Создана Заявка универсальная";
                GlobalNotifyIcon.Text = "Через контекстное меню можно скопировать Дату и номер ЗУн";
                myContextMenu = new ContextMenuStrip();
                ToolStripMenuItem copyZUn = new ToolStripMenuItem("Скопировать ЗУн в буфер");
                LastCreateZunResult = paramsZUn.createZunResult;
                myContextMenu.Items.Add(copyZUn);
                copyZUn.Click += copyZUn_Click;
                GlobalNotifyIcon.ContextMenuStrip = myContextMenu;
                GlobalNotifyIcon.Visible = true;
                GlobalNotifyIcon.ShowBalloonTip(0);
            }
            else
            {
                GlobalNotifyIcon.Icon = Properties.Resources.ico_1ab;
                GlobalNotifyIcon.BalloonTipIcon = ToolTipIcon.Error;
                GlobalNotifyIcon.BalloonTipText = "В УК ОВА было отпралено письмо с ошибкой.";
                GlobalNotifyIcon.BalloonTipTitle = "При создании ЗУн возникла ошибка";
                GlobalNotifyIcon.Text = "";
                GlobalNotifyIcon.Visible = true;
                GlobalNotifyIcon.ShowBalloonTip(0);

                WithABF.CreateMailWithError(paramsZUn.errorCreateZun);
            }
            doCreateZUn = false;
        }

        #endregion Фоновые задания

        private void copyZUn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LastCreateZunResult);
            GlobalNotifyIcon.Visible = false; 
            //сделать: Не отрабатывает просмотр ошибки через иконку панели задач
        }
    }
}