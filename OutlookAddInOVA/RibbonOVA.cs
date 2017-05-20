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
using System.Runtime.InteropServices;



namespace OutlookAddInOVA
{
	public partial class RibbonOVA
	{
		private string lastError;
		private string pathToFile;
		private string preTextZun;
		private string textZun;
		private string errorCreateZun="";
		private bool workWorker=false;
		private string createZunResult;
		private bool currentUserIsOVA = false;
		private string EMailFromCurrentMail = SystemInformation.UserName+"@1ab.ru";
		private Outlook.MailItem curMailItem;
		private void RibbonOVA_Load(object sender, RibbonUIEventArgs e)
		{
			cbQuestionAnswer.Checked = Properties.Settings.Default.prmQuestionAnswer;
			cbQuestionForward.Checked = Properties.Settings.Default.prmQuestionForward;
			cbQuestionNew.Checked = Properties.Settings.Default.prmQuestionNew;
			cbCreateZunFromMe.Checked = Properties.Settings.Default.prmCreateZunFromMe;

			string currentuser = SystemInformation.UserName;
			
			if (OutlookAddInOVA.ThisAddIn.usersOVA.Contains(currentuser))
			{
				groupSettingOVA.Visible = true;
				currentUserIsOVA = true;
			}
		}

		private void cbQuestionNew_Click(object sender, RibbonControlEventArgs e)
		{
			Properties.Settings.Default.prmQuestionNew = cbQuestionNew.Checked;
			Properties.Settings.Default.Save();
		}

		private void cbQuestionAnswer_Click(object sender, RibbonControlEventArgs e)
		{
			Properties.Settings.Default.prmQuestionNew = cbQuestionAnswer.Checked;
			Properties.Settings.Default.Save();
		}

		private void cbQuestionForward_Click(object sender, RibbonControlEventArgs e)
		{
			Properties.Settings.Default.prmQuestionForward = cbQuestionForward.Checked;
			Properties.Settings.Default.Save();
		}

		private void cbCreateZunFromMe_Click(object sender, RibbonControlEventArgs e)
		{
			Properties.Settings.Default.prmCreateZunFromMe = cbCreateZunFromMe.Checked;
			Properties.Settings.Default.Save();
		}
		private void btnCreateZUnInABF_Click(object sender, RibbonControlEventArgs e)
		{
			try
			{
				//creatAtMsg = false;
				if (workWorker)
				{
					MessageBox.Show("Идёт процес создания ЗУн.\nПопробуйте через минуту...", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;

				}
				notifyIconOVA.Visible = false;
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
					pathToFile = screenshotName;
					preTextZun = "Ошибка зарегестрирована из MS Outlook.\nПодробности в приложенном скриншоте.\n\n";
					instructionForm.ShowDialog();
					textZun = instructionForm.textZun;
					if (instructionForm.clickBnOk)
					{
						workWorker = true;
						this.backgroundWorkerOVA.RunWorkerAsync();
					}
					instructionForm = null;
				}
			}
			catch (Exception eRror)
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
					fileName = fileName.Replace(charInvalid, ' ');
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
			string tempFileName = SystemInformation.ComputerName + "_" + SystemInformation.UserName + "_" + DateTime.Now.ToString("dd.MM.yyyy_hhmmss") + "." + extension;

			return tempFolder + tempFileName;
		}

		private void buttonCreateZunWithMsg_Click(object sender, RibbonControlEventArgs e)
		{
		
			if (workWorker)
			{
				MessageBox.Show("Идёт процес создания ЗУн.\nПопробуйте через минуту...", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			notifyIconOVA.Visible = false;
			if (((Microsoft.Office.Tools.Ribbon.OfficeRibbon)((Microsoft.Office.Tools.Ribbon.RibbonComponent)sender).Parent.Parent.Parent).Context is Outlook.Inspector)
			{

				Outlook.Inspector item = ((Microsoft.Office.Tools.Ribbon.OfficeRibbon)((Microsoft.Office.Tools.Ribbon.RibbonComponent)sender).Parent.Parent.Parent).Context as Outlook.Inspector;
				curMailItem = item.CurrentItem as Outlook.MailItem;
			}
			else
			{
				Outlook.Explorer item = ((Microsoft.Office.Tools.Ribbon.OfficeRibbon)((Microsoft.Office.Tools.Ribbon.RibbonComponent)sender).Parent.Parent.Parent).Context as Outlook.Explorer;
				curMailItem = item.Selection[1];


			}


			if (currentUserIsOVA && !Properties.Settings.Default.prmCreateZunFromMe)
			{
				EMailFromCurrentMail = GetSmtpAddress(curMailItem);
			}

			string pathToFileMsg = SaveEmailToMsg(curMailItem);
			if (pathToFileMsg == "")
			{
				MessageBox.Show("При сохранении письма в файл возникла ошибка.\nПожалуйста сообщите текст ошибки в отдел УК ОВА.\n" + lastError, "Не удалось создать ЗУн в УК ОВА", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			instructionInZUn instructionForm = new instructionInZUn();
			pathToFile = pathToFileMsg;
			preTextZun = "Заявка создана автоматически из MS Outlook.\nПодробности в приложенном письме.\n\n";
			instructionForm.ShowDialog();
			textZun = instructionForm.textZun;
			if (instructionForm.clickBnOk)
			{
				workWorker = true;
				this.backgroundWorkerOVA.RunWorkerAsync();
			}
			instructionForm = null;

		}

		
		/// <summary>
		/// Тестовая функция для проверки работы NotifyIcon
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, RibbonControlEventArgs e)
		{
			notifyIconOVA.Icon = Properties.Resources.ico_1ab;
			notifyIconOVA.BalloonTipIcon = ToolTipIcon.Error;
			notifyIconOVA.BalloonTipText = "Заявка универсальная №УК12/12312 от 12.12.2017";
			notifyIconOVA.BalloonTipTitle = "Создана Заявка ниверсальная";
			notifyIconOVA.Text = "Двойной клик по иконке копировать данные в буфер";
			notifyIconOVA.Visible = true;

			var myContextMenu = new ContextMenuStrip();
			var exit = new ToolStripMenuItem("Скопировать ЗУн в буфер");
			myContextMenu.Items.Add(exit);
			exit.Click += copyZUn_Click;
			notifyIconOVA.ContextMenuStrip = myContextMenu;
			notifyIconOVA.ShowBalloonTip(50000);
		}


		private void copyZUn_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(createZunResult);
			notifyIconOVA.Visible = false; ;
		}



		

		private void backgroundWorkerOVA_DoWork_1(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			dynamic result = null;
			V83.COMConnector com1s = new V83.COMConnector();
			try
			{

				if (textZun.Contains("При необходимости укажите подробности ошибки."))
				{
					textZun = "";
				}


				string user = @"""Create_ZUn""";
				string pas = @"""bF6k6mjbCEfEJayL""";
#if DEBUG
				string file = @"""G:\\ABF""";
#else
				string Srvr = @"""1ab-1cv80""";
				string Ref = @"""pav-oper82""";
#endif
				com1s.PoolCapacity = 1;
				com1s.PoolTimeout = 1;
				com1s.MaxConnections = 1;
#if DEBUG
				string connectString = "File=" + file + ";Usr=" + user + ";Pwd=" + pas + ";";
#else
				string connectString = "Srvr=" + Srvr + ";Ref=" + Ref + ";Usr=" + user + ";Pwd=" + pas + ";";
#endif
				result = com1s.Connect(connectString);

#if DEBUG
				createZunResult = result.ДляВнешнихСоединений.CreateZUN("glaal@1ab.ru", pathToFile, preTextZun + textZun, ref errorCreateZun);
				//createZunResult = result.ДляВнешнихСоединений.CreateZUN("glaal12@1ab.ru", pathToFile, preTextZun + textZun,ref errorCreateZun);
#else
				createZunResult = result.ДляВнешнихСоединений.CreateZUN(EMailFromCurrentMail, pathToFile, preTextZun + textZun, ref errorCreateZun);
#endif
				if (createZunResult == "")
				{
					e.Result = false;

					return;
				}
				else
				{
					e.Result = true;

					return;
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.ToString());

				return;
			}
			finally
			{
				Marshal.ReleaseComObject(result);
				result = null;

				Marshal.ReleaseComObject(com1s);
				com1s = null;
				GC.Collect();
				GC.WaitForPendingFinalizers();
				GC.Collect();
			}
		}
		private void backgroundWorkerOVA_RunWorkerCompleted_1(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			if ((bool)e.Result)
			{
				//MessageBox.Show("Создана заявка универсальная в УК ОВА.\n" + createZunResult, "Заявка создана успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
				notifyIconOVA.Icon = Properties.Resources.ico_1ab;
				notifyIconOVA.BalloonTipIcon = ToolTipIcon.Info;
				notifyIconOVA.BalloonTipText = createZunResult;
				notifyIconOVA.BalloonTipTitle = "Создана Заявка универсальная";
				notifyIconOVA.Text = "Через контекстное меню можно скопировать Дату и номер ЗУн";
				var myContextMenu = new ContextMenuStrip();
				var copyZUn = new ToolStripMenuItem("Скопировать ЗУн в буфер");
				myContextMenu.Items.Add(copyZUn);
				copyZUn.Click += copyZUn_Click;
				notifyIconOVA.ContextMenuStrip = myContextMenu;
				notifyIconOVA.Visible = true;
				notifyIconOVA.ShowBalloonTip(60000);
			}
			else
			{
				//MessageBox.Show("При создании ЗУн возникла ошибка.\nПожалуйста сообщите текст ошибки в отдел УК ОВА.\n" + errorCreateZun, "Не удалось создать ЗУн в УК ОВА", MessageBoxButtons.OK, MessageBoxIcon.Error);
				notifyIconOVA.Icon = Properties.Resources.ico_1ab;
				notifyIconOVA.BalloonTipIcon = ToolTipIcon.Error;
				notifyIconOVA.BalloonTipText = "В УК ОВА было отпралено письмо с ошибкой.";
				notifyIconOVA.BalloonTipTitle = "При создании ЗУн возникла ошибка";
				notifyIconOVA.Text = "";
				notifyIconOVA.Visible = true;
				notifyIconOVA.ShowBalloonTip(60000);

				Outlook.MailItem mailItem = (Outlook.MailItem)
				OutlookAddInOVA.Globals.ThisAddIn.Application.CreateItem(Outlook.OlItemType.olMailItem);
				mailItem.Subject = "При создании ЗУн возникла ошибка.";
				mailItem.To = "glaal@1ab.ru";
				mailItem.Body = errorCreateZun;
				mailItem.Importance = Outlook.OlImportance.olImportanceHigh;
				mailItem.Send();
			}
			workWorker = false;
		}

		public string GetSmtpAddress(Outlook.MailItem oItem)
		{
			Outlook.Recipient recip;
			Outlook.ExchangeUser exUser;
			string sAddress;

			if (oItem.SenderEmailType.ToLower() == "ex")
			{
				recip = Globals.ThisAddIn.Application.GetNamespace("MAPI").CreateRecipient(oItem.SenderEmailAddress);
				exUser = recip.AddressEntry.GetExchangeUser();
				sAddress = exUser.PrimarySmtpAddress;
			}
			else
			{
				sAddress = oItem.SenderEmailAddress.Replace("'", "");
			}
			return sAddress;
		}

	}
}
