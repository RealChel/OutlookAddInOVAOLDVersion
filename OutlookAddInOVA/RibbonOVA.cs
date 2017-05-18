using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Collections;
using System.Net;


namespace OutlookAddInOVA
{
	public partial class RibbonOVA
	{
		private string lastError;
		private void RibbonOVA_Load(object sender, RibbonUIEventArgs e)
		{
			cbQuestionAnswer.Checked = Properties.Settings.Default.PrnQuestionAnswer;
			cbQuestionForward.Checked = Properties.Settings.Default.prnQuestionForward;
			cbQuestionNew.Checked = Properties.Settings.Default.PrnQuestionNew;
		}

		private void cbQuestionNew_Click(object sender, RibbonControlEventArgs e)
		{
			Properties.Settings.Default.PrnQuestionNew = cbQuestionNew.Checked;
			Properties.Settings.Default.Save();
		}

		private void cbQuestionAnswer_Click(object sender, RibbonControlEventArgs e)
		{
			Properties.Settings.Default.PrnQuestionNew = cbQuestionAnswer.Checked;
			Properties.Settings.Default.Save();
		}

		private void cbQuestionForward_Click(object sender, RibbonControlEventArgs e)
		{
			Properties.Settings.Default.prnQuestionForward = cbQuestionForward.Checked;
			Properties.Settings.Default.Save();
		}

		
		private void btnCreateZUnInABF_Click(object sender, RibbonControlEventArgs e)
		{
			try
			{
				string screenshotName = SaveClipBoardToPicture();
				if (screenshotName == "")
				{
					if (lastError == "Буфер не содержит картинку")
					{
						MessageBox.Show("Буфер обмена не содержит картинку.\nСкопируйте в буфер картинку или сделайте скриншот.\nПовторите операцию.", "Не удалось создать ЗУн в УК ОВА", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					else
					{
						MessageBox.Show("При сохранении скриншота возникла ошибка.\nПожалуйста сообщите текст ошибки в отдел УК ОВА.\n" + lastError, "Не удалось создать ЗУн в УК ОВА", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				else
				{
					instructionInZUn instructionForm = new instructionInZUn();
					instructionForm.PathToFile = screenshotName;
					instructionForm.preTextZun = "Ошибка зарегестрирована из MS Outlook.\nПодробности в приложенном скриншоте.\n\n";
					instructionForm.ShowDialog();
					instructionForm = null;


				}
				//Outlook.MailItem mailItem = (Outlook.MailItem)
				//OutlookAddInOVA.Globals.ThisAddIn.Application.CreateItem(Outlook.OlItemType.olMailItem);
				//mailItem.Subject = "Тестовое письмо";
				//mailItem.To = "test@csharpcoderr.com";
				//mailItem.Body = "Текст сообщения";
				//mailItem.Importance = Outlook.OlImportance.olImportanceLow;
				//mailItem.Display(false);
			}
			catch(Exception eRror)
			{
				MessageBox.Show(eRror.ToString());
			}
		}



		public string SaveClipBoardToPicture()
		{
			try
			{
				if (!Clipboard.ContainsImage())
				{
					lastError = "Буфер не содержит картинку";
					return "";
				}
				string fileName = GetPathToSave("png");
				Image img = new Bitmap(Clipboard.GetImage());
				img.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
				return fileName;
			}
			catch (Exception e)
			{
				lastError = e.ToString();
				return "";
			}
		}

		public string SaveEmailToMsg(Outlook.MailItem mailItem)
		{
			try
			{
				string tempFolder = Path.GetTempPath();
				string fileName = mailItem.Subject;

				char[] charInvalidFileChars = Path.GetInvalidFileNameChars();
				foreach (char charInvalid in charInvalidFileChars)
				{
					fileName = fileName.Replace(charInvalid,' ');
				}
				fileName = tempFolder + fileName + ".msg";

				mailItem.SaveAs(fileName, Outlook.OlSaveAsType.olMSGUnicode);
				return fileName;
			}
			catch (Exception e)
			{
				lastError = e.ToString();
				return "";
			}
		}
		private string GetPathToSave(string extension)
		{
			string tempFolder = Path.GetTempPath();
			//string tempFileName = Path.GetRandomFileName();
			string tempFileName = SystemInformation.ComputerName + "_" + SystemInformation.UserName + "_" + DateTime.Now.ToString("dd.MM.yyyy_hhmmss") + "." + extension;
			
			return tempFolder + tempFileName;
		}

		private void buttonCreateZunWithMsg_Click(object sender, RibbonControlEventArgs e)
		{
			Outlook.MailItem mailItem;

			if (((Microsoft.Office.Tools.Ribbon.OfficeRibbon)((Microsoft.Office.Tools.Ribbon.RibbonComponent)sender).Parent.Parent.Parent).Context is Outlook.Inspector)
			{
				
				Outlook.Inspector item = ((Microsoft.Office.Tools.Ribbon.OfficeRibbon)((Microsoft.Office.Tools.Ribbon.RibbonComponent)sender).Parent.Parent.Parent).Context as Outlook.Inspector;
				mailItem = item.CurrentItem as Outlook.MailItem;
			}
			else
			{
				Outlook.Explorer item = ((Microsoft.Office.Tools.Ribbon.OfficeRibbon)((Microsoft.Office.Tools.Ribbon.RibbonComponent)sender).Parent.Parent.Parent).Context as Outlook.Explorer;
				mailItem = item.Selection[1];


			}


			string pathToFile = SaveEmailToMsg(mailItem);
			if (pathToFile=="")
			{
				MessageBox.Show("При сохранении письма в файл возникла ошибка.\nПожалуйста сообщите текст ошибки в отдел УК ОВА.\n" + lastError, "Не удалось создать ЗУн в УК ОВА", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			instructionInZUn instructionForm = new instructionInZUn();
			instructionForm.PathToFile = pathToFile;
			instructionForm.preTextZun = "Заявка создана автоматически из MS Outlook.\nПодробности в приложенном письме.\n\n";
			instructionForm.ShowDialog();
			instructionForm = null;

		}


		private void CurrentExplorer_Event()
		{
			//Outlook.MAPIFolder selectedFolder =
			//	this.Application.ActiveExplorer().CurrentFolder;
			//String expMessage = "Your current folder is "
			//	+ selectedFolder.Name + ".\n";
			//String itemMessage = "Item is unknown.";
			//try
			//{
			//	if (this.Application.ActiveExplorer().Selection.Count > 0)
			//	{
			//		Object selObject = this.Application.ActiveExplorer().Selection[1];
			//		if (selObject is Outlook.MailItem)
			//		{
			//			Outlook.MailItem mailItem =
			//				(selObject as Outlook.MailItem);
			//			itemMessage = "The item is an e-mail message." +
			//				" The subject is " + mailItem.Subject + ".";
			//			mailItem.Display(false);
			//		}
			//		else if (selObject is Outlook.ContactItem)
			//		{
			//			Outlook.ContactItem contactItem =
			//				(selObject as Outlook.ContactItem);
			//			itemMessage = "The item is a contact." +
			//				" The full name is " + contactItem.Subject + ".";
			//			contactItem.Display(false);
			//		}
			//		else if (selObject is Outlook.AppointmentItem)
			//		{
			//			Outlook.AppointmentItem apptItem =
			//				(selObject as Outlook.AppointmentItem);
			//			itemMessage = "The item is an appointment." +
			//				" The subject is " + apptItem.Subject + ".";
			//		}
			//		else if (selObject is Outlook.TaskItem)
			//		{
			//			Outlook.TaskItem taskItem =
			//				(selObject as Outlook.TaskItem);
			//			itemMessage = "The item is a task. The body is "
			//				+ taskItem.Body + ".";
			//		}
			//		else if (selObject is Outlook.MeetingItem)
			//		{
			//			Outlook.MeetingItem meetingItem =
			//				(selObject as Outlook.MeetingItem);
			//			itemMessage = "The item is a meeting item. " +
			//				 "The subject is " + meetingItem.Subject + ".";
			//		}
			//	}
			//	expMessage = expMessage + itemMessage;
			//}
			//catch (Exception ex)
			//{
			//	expMessage = ex.Message;
			//}
			//MessageBox.Show(expMessage);
		}

	}
}
