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

		#endregion

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

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			System.Windows.Forms.TextBox txtBoxName = (System.Windows.Forms.TextBox)sender;
			Outlook.AppointmentItem appt = OutlookAddInOVA.Globals.ThisAddIn.Application.CreateItem(
		Outlook.OlItemType.olAppointmentItem)
		as Outlook.AppointmentItem;
			appt.MeetingStatus = Outlook.OlMeetingStatus.olMeeting;
			appt.Subject = "Team Morale Event";
			//appt.Start = DateTime.Parse("5/17/2007 11:00 AM");
			//appt.End = DateTime.Parse("5/17/2007 12:00 PM");
			Outlook.SelectNamesDialog snd =
				OutlookAddInOVA.Globals.ThisAddIn.Application.Session.GetSelectNamesDialog();
			snd.SetDefaultDisplayMode(
				Outlook.OlDefaultSelectNamesDisplayMode.olDefaultMeeting);
			Outlook.Recipient confRoom =
				snd.Recipients.Add("Conf Room 36/2739");
			// Explicitly specify Recipient.Type.
			confRoom.Type = (int)Outlook.OlMeetingRecipientType.olResource;
			snd.Recipients.ResolveAll();
			snd.Display();
			// Add Recipients to meeting request.
			Outlook.Recipients recips = snd.Recipients;
			if (recips.Count > 0)
			{
				foreach (Outlook.Recipient recip in recips)
				{
					appt.Recipients.Add(recip.Name);
				}
			}
			appt.Recipients.ResolveAll();
			appt.Display(false);
		}
	}
}
