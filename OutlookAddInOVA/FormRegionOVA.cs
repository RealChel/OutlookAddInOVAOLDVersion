using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Office = Microsoft.Office.Core;
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
				//Outlook.MailItem myItem = (Outlook.MailItem)e.OutlookItem ;

				//if (myItem != null)
				//{
				//	string allmale = GetAllSMTPAddressForRecipients(myItem);
				//	if (allmale.Contains("glaal@1ab.ru"))
				//	{
				//		e.Cancel = false;
				//	}
				//}
				return;
			}


			private string GetAllSMTPAddressForRecipients(Outlook.MailItem myMail)
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
		}

		#endregion

		// Возникает перед отображением области формы.
		// Используйте this.OutlookItem для получения ссылки на текущий элемент Outlook.
		// Используйте this.OutlookFormRegion для получения ссылки на область формы.
		private void FormRegionOVA_FormRegionShowing(object sender, System.EventArgs e)
		{
		}

		// Возникает перед закрытием области формы.
		// Используйте this.OutlookItem для получения ссылки на текущий элемент Outlook.
		// Используйте this.OutlookFormRegion для получения ссылки на область формы.
		private void FormRegionOVA_FormRegionClosed(object sender, System.EventArgs e)
		{
		}



	}
}
