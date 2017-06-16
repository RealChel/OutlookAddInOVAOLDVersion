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
		#region Закрытые переменные
		private string lastError = "";
		private string pathToFile = "";
		private string preTextZun = "";
		private string textZun = "";
		private string errorCreateZun = "";
		private bool workWorker = false;
		private bool workWorkerSMART = false;
		private string createZunResult = "";
		private bool currentUserIsOVA = false;
		private string EMailFromCurrentMail = "";
		private Outlook.MailItem curItem;
		private string executorSMART = "";
		private string textFormulirovka = "";
		private string textKriterii = "";
		private string textComment = "";
		private int vesSmart=1;
		private string DoDate = ""; 
		#endregion

		private void RibbonOVA_Load(object sender, RibbonUIEventArgs e)
		{
			cbQuestionAnswer.Checked = Properties.Settings.Default.prmQuestionAnswer;
			cbQuestionForward.Checked = Properties.Settings.Default.prmQuestionForward;
			cbQuestionNew.Checked = Properties.Settings.Default.prmQuestionNew;
			cbCreateZunFromMe.Checked = Properties.Settings.Default.prmCreateZunFromMe;
			EMailFromCurrentMail = OutlookAddInOVA.Globals.ThisAddIn.currentusermail;

			if (OutlookAddInOVA.Globals.ThisAddIn.usersOVA.Contains(OutlookAddInOVA.Globals.ThisAddIn.currentuser))
			{
				groupSettingOVA.Visible = true;
				currentUserIsOVA = true;
			}
		}

		#region Клик по чек боксам
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
		#endregion


		#region Кнопки на ленте
		
		private void btnCreateZUnWithScreenShoot_Click(object sender, RibbonControlEventArgs e)
		{
			try
			{
				if (workWorker)
				{
					MessageBox.Show("Идёт процес создания ЗУн.\nПопробуйте через минуту...", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				CreatZunFromScreenshot();
			}
			catch (Exception err)
			{
				String sError = err.ToString();
				OutlookAddInOVA.Globals.ThisAddIn.CreateZunWithError(sError);
				MessageBox.Show(sError);
			}
		}

		private void buttonCreateZunWithMsg_Click(object sender, RibbonControlEventArgs e)
		{
			try
			{
				if (workWorker)
				{
					MessageBox.Show("Идёт процес создания ЗУн.\nПопробуйте через минуту...", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				notifyIconOVA.Visible = false;
				if (!SetCurrenEmail(sender))
				{
					return;
				}
			}
			catch (Exception err)
			{
				string sError = err.ToString();
				OutlookAddInOVA.Globals.ThisAddIn.CreateZunWithError(sError);
				MessageBox.Show("Не удается идентифицировать текущий объект как письмо.\nСоздать ЗУн можено только на основании письма.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			CreateZunFromMail();
		}

		private void buttonCreateSmartToMe_Click(object sender, RibbonControlEventArgs e)
		{
				try
				{
				if (workWorkerSMART)
					{
						MessageBox.Show("Идёт процес создания СМАРТ.\nПопробуйте через минуту...", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					notifyIconOVA.Visible = false;
					if (!SetCurrenEmail(sender))
					{
						return;
					}
					CreatSMART();
				}
				catch (Exception err)
				{
					string sError = err.ToString();
					OutlookAddInOVA.Globals.ThisAddIn.CreateZunWithError(sError);
					MessageBox.Show("Не удается идентифицировать текущий объект как письмо.\nСоздать ЗУн можено только на основании письма.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				finally
				{
				notifyIconOVA.Visible = false;
				}
		}

		private void buttonCreateSmartToExcevutor_Click(object sender, RibbonControlEventArgs e)
		{
			try
			{
				if (workWorkerSMART)
				{
					MessageBox.Show("Идёт процес создания СМАРТ.\nПопробуйте через минуту...", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				notifyIconOVA.Visible = false;
				if (!SetCurrenEmail(sender))
				{
					return;
				}
				CreatSMART(false, true);
			}
			catch (Exception err)
			{
				string sError = err.ToString();
				OutlookAddInOVA.Globals.ThisAddIn.CreateZunWithError(sError);
				MessageBox.Show("Не удается идентифицировать текущий объект как письмо.\nСоздать ЗУн можено только на основании письма.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			finally
			{
				notifyIconOVA.Visible = false;
			}
		}

		#endregion New Region


		#region Кнопки в меню

		private void buttonSettingSMART_Click(object sender, RibbonControlEventArgs e)
		{
			FormSettings formSettings = new FormSettings();
			formSettings.ShowDialog();
		}
		private void btnAboutProg_Click(object sender, RibbonControlEventArgs e)
		{
			FormAboutBox formAbout = new FormAboutBox();
			formAbout.ShowDialog();
		}

#endregion New Region
		#region Запуск фоновых обработчиков	

		private void backgroundWorkerOVAZUn_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			dynamic result = null;
			V83.COMConnector com1s = new V83.COMConnector();
			try
			{
				//По простому проверяю изменили текст или сразу нажали ОК
				if (textZun.Contains("При необходимости укажите"))
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

				if (!String.IsNullOrEmpty(textZun))
				{
					textZun += "\n\n";
				}
#if DEBUG
				createZunResult = result.ДляВнешнихСоединений.Create_ZUN("glaal@1ab.ru", pathToFile, textZun + preTextZun, ref errorCreateZun);
				//createZunResult = result.ДляВнешнихСоединений.Create_ZUN("glaal12@1ab.ru", pathToFile, preTextZun + textZun,ref errorCreateZun);
#else
				createZunResult = result.ДляВнешнихСоединений.Create_ZUN(EMailFromCurrentMail, pathToFile, textZun + preTextZun, ref errorCreateZun);
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

		private void backgroundWorkerOVASMART_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			dynamic result = null;
			V83.COMConnector com1s = new V83.COMConnector();
			try
			{
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
				createZunResult = result.ДляВнешнихСоединений.Create_SMART("glaal@1ab.ru" , executorSMART, textFormulirovka,textKriterii, pathToFile,vesSmart,DoDate,textComment, ref errorCreateZun);
				//createZunResult = result.ДляВнешнихСоединений.Create_SMART("glaal12@1ab.ru", pathToFile, preTextZun + textZun,ref errorCreateZun);
#else
				createZunResult = result.ДляВнешнихСоединений.Create_SMART(OutlookAddInOVA.Globals.ThisAddIn.currentusermail, executorSMART, textFormulirovka, textKriterii, pathToFile, vesSmart, DoDate, textComment, ref errorCreateZun);
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
				string sError = err.ToString();
				OutlookAddInOVA.Globals.ThisAddIn.CreateZunWithError(sError);
				MessageBox.Show(sError);
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

		#endregion New Region


		#region Обработка окончания работы фоновых обработчиков	

		private void backgroundWorkerOVAZUn_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
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

				OutlookAddInOVA.Globals.ThisAddIn.CreateZunWithError(errorCreateZun);
			}
			workWorker = false;
		}

		private void backgroundWorkerOVASMART_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			if ((bool)e.Result)
			{
				//MessageBox.Show("Создана заявка универсальная в УК ОВА.\n" + createZunResult, "Заявка создана успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
				notifyIconOVA.Icon = Properties.Resources.ico_1ab;
				notifyIconOVA.BalloonTipIcon = ToolTipIcon.Info;
				notifyIconOVA.BalloonTipText = createZunResult;
				notifyIconOVA.BalloonTipTitle = "Создана СМАРТ задача";
				notifyIconOVA.Text = "Через контекстное меню можно скопировать Дату и номер СМАРТ";
				var myContextMenu = new ContextMenuStrip();
				var copyZUn = new ToolStripMenuItem("Скопировать СМАРТ в буфер");
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
				notifyIconOVA.BalloonTipTitle = "При создании СМАРТ возникла ошибка";
				notifyIconOVA.Text = "";
				notifyIconOVA.Visible = true;
				notifyIconOVA.ShowBalloonTip(60000);

				OutlookAddInOVA.Globals.ThisAddIn.CreateZunWithError(errorCreateZun);
			}
			workWorkerSMART = false;
		}

		#endregion New Region
		//test

		#region Другие функции	

		private void CreatZunFromScreenshot()
		{
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
				preTextZun = "Ошибка зарегестрирована из MS Outlook.\nПодробности в приложенном скриншоте.";
				instructionForm.textZun = "При необходимости укажите подробности ошибки." + Environment.NewLine + "Либо просто нажмите ОК(Ctr+Enter)";
				instructionForm.ShowDialog();
				textZun = instructionForm.textZun;
				if (instructionForm.clickBnOk)
				{
					workWorker = true;
					this.backgroundWorkerOVAZUn.RunWorkerAsync();
				}
				instructionForm = null;
			}
		}

		private void CreateZunFromMail()
		{
			if (currentUserIsOVA && !Properties.Settings.Default.prmCreateZunFromMe)
			{
				EMailFromCurrentMail = GetSmtpAddress(curItem);
			}
            else
            {
                EMailFromCurrentMail = OutlookAddInOVA.Globals.ThisAddIn.currentusermail;
            }

			string pathToFileMsg = SaveEmailToMsg(curItem);
			if (pathToFileMsg == "")
			{
				MessageBox.Show("При сохранении письма в файл возникла ошибка.\nПожалуйста сообщите текст ошибки в отдел УК ОВА.\n" + lastError, "Не удалось создать ЗУн в УК ОВА", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			instructionInZUn instructionForm = new instructionInZUn();
			pathToFile = pathToFileMsg;
			preTextZun = "Заявка создана автоматически из MS Outlook.\nПодробности в приложенном письме.";
			instructionForm.textZun = "При необходимости укажите подробности для заявки." + Environment.NewLine + "Либо просто нажмите ОК(Ctr+Enter)";
			instructionForm.ShowDialog();
			textZun = instructionForm.textZun;
			if (instructionForm.clickBnOk)
			{
				workWorker = true;
				this.backgroundWorkerOVAZUn.RunWorkerAsync();
			}
			instructionForm = null;
		}

		private bool SetCurrenEmail(object selectedItem)
		{
			if (((Microsoft.Office.Tools.Ribbon.OfficeRibbon)((Microsoft.Office.Tools.Ribbon.RibbonComponent)selectedItem).Parent.Parent.Parent).Context is Outlook.Inspector)
			{
				Outlook.Inspector item = ((Microsoft.Office.Tools.Ribbon.OfficeRibbon)((Microsoft.Office.Tools.Ribbon.RibbonComponent)selectedItem).Parent.Parent.Parent).Context as Outlook.Inspector;
				curItem = item.CurrentItem;
				return true;
			}
			else if (((Microsoft.Office.Tools.Ribbon.OfficeRibbon)((Microsoft.Office.Tools.Ribbon.RibbonComponent)selectedItem).Parent.Parent.Parent).Context is Outlook.Explorer)
			{
				Outlook.Explorer item = ((Microsoft.Office.Tools.Ribbon.OfficeRibbon)((Microsoft.Office.Tools.Ribbon.RibbonComponent)selectedItem).Parent.Parent.Parent).Context as Outlook.Explorer;
				curItem = item.Selection[1];
				return true;
			}
			else
			{
				MessageBox.Show("Не удается идентифицировать текущий объект как письмо.\nСоздать ЗУн можено только на основании письма.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
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
				OutlookAddInOVA.Globals.ThisAddIn.CreateZunWithError(lastError);
				return "";
			}
		}

		public string SaveEmailToMsg(Outlook.MailItem mailItem)
		{
			try
			{
				string tempFolder = Path.GetTempPath();
				string fileName;
				fileName = mailItem.Subject;
				if (!string.IsNullOrEmpty(fileName))
				{ 
				char[] charInvalidFileChars = Path.GetInvalidFileNameChars();
				foreach (char charInvalid in charInvalidFileChars)
				{
					fileName = fileName.Replace(charInvalid, ' ');
				}
				fileName = tempFolder + fileName + ".msg";
				}
				else
				{
					fileName = GetPathToSave("msg");
				}
				mailItem.SaveAs(fileName, Outlook.OlSaveAsType.olMSGUnicode);
				return fileName;
			}
			catch (Exception e)
			{
				lastError = e.ToString();
				OutlookAddInOVA.Globals.ThisAddIn.CreateZunWithError(lastError);
				return "";
			}
		}

		private string GetPathToSave(string extension)
		{
			string tempFolder = Path.GetTempPath();
			string tempFileName = SystemInformation.ComputerName + "_" + SystemInformation.UserName + "_" + DateTime.Now.ToString("dd.MM.yyyy_hhmmss") + "." + extension;

			return tempFolder + tempFileName;
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
		private void CreatSMART(bool fastSmart=true,bool showForm=false)
		{
			string pathToFileMsg = SaveEmailToMsg(curItem);
			if (pathToFileMsg == "")
			{
				MessageBox.Show("При сохранении письма в файл возникла ошибка.\nПожалуйста сообщите текст ошибки в отдел УК ОВА.\n" + lastError, "Не удалось создать ЗУн в УК ОВА", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			bool clickOk = false;
			FormSMART formSmart = new FormSMART();
			if (fastSmart)
			{
				formSmart.textFormulirovka = Properties.Settings.Default.prmSmartFastFormulirovka;
				formSmart.textKriterii = Properties.Settings.Default.prmSmartFastKriterii;
				clickOk = true;
			}
			else
			{
				formSmart.textFormulirovka = Properties.Settings.Default.prmSmartExecutorFormulirovka;
				formSmart.textKriterii = Properties.Settings.Default.prmSmartExecutorKriterii;
			}
			if (showForm)
			{
				formSmart.ShowDialog();
				clickOk = formSmart.clickBnOk;
				executorSMART = formSmart.executor;
				textFormulirovka = formSmart.textFormulirovka;
				textKriterii = formSmart.textKriterii;
				textComment = "";
				vesSmart = formSmart.VesSmart;
				DoDate = formSmart.DoDate.ToString("yyyyMMdd");
			}
			else
			{
				executorSMART = OutlookAddInOVA.Globals.ThisAddIn.currentusermail;
				textFormulirovka = Properties.Settings.Default.prmSmartFastFormulirovka;
				textKriterii = Properties.Settings.Default.prmSmartFastKriterii;
				textComment = "";
				vesSmart = 1;
				DoDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)).ToString("yyyyMMdd");
			}
			if (clickOk)
			{
				if (fastSmart)
				{
					notifyIconOVA.Icon = Properties.Resources.ico_1ab;
					notifyIconOVA.BalloonTipIcon = ToolTipIcon.Info;
					notifyIconOVA.BalloonTipText = "Создание СМАРТ";
					notifyIconOVA.BalloonTipTitle = "Началось создание СМАРТ в АБФ";
					notifyIconOVA.Text = "";
					notifyIconOVA.Visible = true;
					notifyIconOVA.ShowBalloonTip(5000);
				}

				//Пустые параметры заполним по умолчанию
				if (fastSmart)
				{
					if (textFormulirovka == "")
					{
						textFormulirovka = Properties.Settings.Default.prmSmartFastFormulirovka;
					}
					if (textKriterii=="")
					{
						textKriterii = Properties.Settings.Default.prmSmartFastKriterii;
					}
				}
				else
				{
					if (textFormulirovka == "")
					{
						textFormulirovka = Properties.Settings.Default.prmSmartExecutorFormulirovka;
					}
					if (textKriterii == "")
					{
						textKriterii = Properties.Settings.Default.prmSmartExecutorKriterii;
					}
				}
				if (executorSMART == "")
				{
					executorSMART = OutlookAddInOVA.Globals.ThisAddIn.currentusermail;
				}
				if (vesSmart == 0)
				{
					vesSmart = 1;
				}

				formSmart = null;
				pathToFile = pathToFileMsg;
				workWorkerSMART = true;
				this.backgroundWorkerOVASMART.RunWorkerAsync();
			}
		}

        #endregion New Region

        private void buttonAddToMeeting_Click(object sender, RibbonControlEventArgs e)
        {
            dynamic result = null;
            dynamic resultquery = null;
            System.Data.DataTable resultTable = null;
           
            V83.COMConnector com1s = new V83.COMConnector();
            try
            {
                //По простому проверяю изменили текст или сразу нажали ОК
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

                string textQuery= @"ВЫБРАТЬ УР_Собрание.Ссылка, УР_Собрание.Дата,УР_Собрание.Номер,УР_Собрание.Председатель,УР_Собрание.Организатор ИЗ Документ.УР_Собрание КАК УР_Собрание ГДЕ УР_Собрание.Организатор.Наименование = ""Главизнин Алексей""";
#if DEBUG
                resultquery = result.ДляВнешнихСоединений.GetResultQuery(textQuery, ref errorCreateZun);
                //createZunResult = result.ДляВнешнихСоединений.CreateZUN("glaal12@1ab.ru", pathToFile, preTextZun + textZun,ref errorCreateZun);
#else
				createZunResult = result.ДляВнешнихСоединений.CreateZUN(EMailFromCurrentMail, pathToFile, textZun + preTextZun, ref errorCreateZun);
#endif
                resultTable = (System.Data.DataTable)resultquery;
                if (createZunResult == "")
                {
                   

                    return;
                }
                else
                {
                 

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
    }
}