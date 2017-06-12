using System;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace OutlookAddInOVA
{
	partial class FormRegionOVA
	{
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
				e.Cancel = true;

				//Outlook.MailItem myItem = (Outlook.MailItem)e.OutlookItem;

				//if (myItem != null)
				//{
				//	string allmale = OutlookAddInOVA.Globals.ThisAddIn.GetAllSMTPAddressForRecipients(myItem);
				//	if (allmale.Contains("glaal@1ab.ru"))
				//	{
				//		e.Cancel = false;
				//	}
				//}
				//return;
			}
		}

		#endregion Фабрика областей формы

		// Возникает перед отображением области формы.
		// Используйте this.OutlookItem для получения ссылки на текущий элемент Outlook.
		// Используйте this.OutlookFormRegion для получения ссылки на область формы.
		private void FormRegionOVA_FormRegionShowing(object sender, System.EventArgs e)
		{
			//dataGridView1.DataSource = OutlookAddInOVA.Globals.ThisAddIn.listCoWorker;
		}

		// Возникает перед закрытием области формы.
		// Используйте this.OutlookItem для получения ссылки на текущий элемент Outlook.
		// Используйте this.OutlookFormRegion для получения ссылки на область формы.
		private void FormRegionOVA_FormRegionClosed(object sender, System.EventArgs e)
		{
		}

		private void cbApproval_CheckedChanged(object sender, EventArgs e)
		{
			if (cbApproval.Checked)
			{
				tabOVA.Visible = true;
			}
			else
			{
				tabOVA.Visible = false;
			}
		}
	}
}