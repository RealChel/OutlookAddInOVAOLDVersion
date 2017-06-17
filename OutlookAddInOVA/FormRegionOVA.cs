using System;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace OutlookAddInOVA
{
	partial class FormRegionOVA
	{
        internal bool checkedDoZunOVA;

        #region Фабрика областей формы

        [Microsoft.Office.Tools.Outlook.FormRegionMessageClass(Microsoft.Office.Tools.Outlook.FormRegionMessageClassAttribute.Note)]
		[Microsoft.Office.Tools.Outlook.FormRegionName("OutlookAddInOVA.FormRegionOVA")]
		public partial class FormRegionOVAFactory
		{
			// Возникает перед инициализацией области формы.
			// Чтобы исключить появление области формы, задайте для параметра e.Cancel значение true.
			// Используйте e.OutlookItem для получения ссылки на текущий элемент Outlook.
			private void FormRegionOVAFactory_FormRegionInitializing(object sender, Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs e)
			{
				//e.Cancel = true;

    //            Outlook.MailItem myItem = (Outlook.MailItem)e.OutlookItem;

    //            if (myItem != null)
    //            {
    //                string allmale = OutlookAddInOVA.Globals.ThisAddIn.GetAllSMTPAddressForRecipients(myItem);
    //                if (allmale.Contains("glaal@1ab.ru"))
    //                {
    //                    e.Cancel = false;
    //                }
    //            }
                
               
            }
		}

		#endregion Фабрика областей формы

		// Возникает перед отображением области формы.
		// Используйте this.OutlookItem для получения ссылки на текущий элемент Outlook.
		// Используйте this.OutlookFormRegion для получения ссылки на область формы.
		private void FormRegionOVA_FormRegionShowing(object sender, System.EventArgs e)
		{
            tabOVA.TabPages.Remove(tabPageApproval);
            this.OutlookFormRegion.Visible = false;
            //this.Visible = false;
            //dataGridView1.DataSource = OutlookAddInOVA.Globals.ThisAddIn.listCoWorker;
            this.EnabledChanged += FormEnabledChange;
        }


        // Возникает перед закрытием области формы.
        // Используйте this.OutlookItem для получения ссылки на текущий элемент Outlook.
        // Используйте this.OutlookFormRegion для получения ссылки на область формы.
        private void FormRegionOVA_FormRegionClosed(object sender, System.EventArgs e)
		{
    
		}

        private void FormEnabledChange(object sender, EventArgs e)
        {
            if (Enabled)
            {
                cbCreateZUn.Checked = checkedDoZunOVA;
            }
            else
            {
                cbCreateZUn.Checked = false;
            }
        }

		private void cbApproval_CheckedChanged(object sender, EventArgs e)
		{
			if (cbApproval.Checked)
			{
				tabOVA.TabPages.Add(tabPageApproval);
			}
			else
			{
                tabOVA.TabPages.Remove(tabPageApproval);

            }
		}

        private void cbCreateZUn_CheckedChanged(object sender, EventArgs e)
        {
            checkedDoZunOVA = cbCreateZUn.Checked;
        }
    }
}