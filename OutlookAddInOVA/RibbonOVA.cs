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
						MessageBox.Show("При сохранении скриншота возникла ошибка.\nПожалуйста сообщите текст ошибки в отдела УК ОВА.\n" + lastError, "Не удалось создать ЗУн в УК ОВА", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				else
				{
					instructionInZUn instructionForm = new instructionInZUn();
					instructionForm.PathToScreenShot = screenshotName;
					instructionForm.ShowDialog();
					

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

		private string GetPathToSave(string extension)
		{
			string tempFolder = Path.GetTempPath();
			//string tempFileName = Path.GetRandomFileName();
			string tempFileName = SystemInformation.ComputerName + "_" + SystemInformation.UserName + "_" + DateTime.Now.ToString("dd.MM.yyyy_hhmmss") + "." + extension;
			
			return tempFolder + tempFileName;
		}
	}
}
