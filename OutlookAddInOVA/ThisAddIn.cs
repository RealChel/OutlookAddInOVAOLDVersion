using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;



namespace OutlookAddInOVA
{

	public partial class ThisAddIn
    {
		Outlook.Inspectors inspectors;
		private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
			inspectors = this.Application.Inspectors;
			inspectors.NewInspector +=
			new Microsoft.Office.Interop.Outlook.InspectorsEvents_NewInspectorEventHandler(Inspectors_NewInspector);
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

		#endregion

		void Inspectors_NewInspector(Microsoft.Office.Interop.Outlook.Inspector Inspector)
		{
			Outlook.MailItem mailItem = Inspector.CurrentItem as Outlook.MailItem;
			if (mailItem != null)
			{
				if (mailItem.EntryID == null)
				{
					mailItem.Subject = "This text was added by using code";
					mailItem.Body = "This text was added by using code";
				}

			}
		}
	}
}
