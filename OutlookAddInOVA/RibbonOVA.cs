using Microsoft.Office.Tools.Ribbon;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using WithABF = OutlookAddInOVA.InteractionWithABF;

namespace OutlookAddInOVA
{
    public partial class RibbonOVA
    {
        #region Закрытые переменные

        internal string lastError;
        internal string pathToFile;
        internal string preTextZun;
        internal string textZun;
        internal string errorCreateZun = "";
        internal bool workWorker = false;
        internal bool workWorkerSMART = false;
        internal string createZunResult;
        internal string EMailFromCurrentMail;
        internal Outlook.MailItem curItem;
        internal string executorSMART;
        internal string executorZUn;
        internal string textFormulirovka;
        internal string textKriterii;
        internal string textComment;
        internal int vesSmart;
        internal string DoDate;

        #endregion Закрытые переменные

        private void RibbonOVA_Load(object sender, RibbonUIEventArgs e)
        {
            cbCreateZunFromMe.Checked = Properties.Settings.Default.prmCreateZUnFromMe;
            EMailFromCurrentMail = OutlookAddInOVA.Globals.ThisAddIn.currentusermail;
            //MessageBox.Show(OutlookAddInOVA.Globals.ThisAddIn.currentusermail);
            if (OutlookAddInOVA.Globals.ThisAddIn.currentUserIsOVA)
            {
                groupSettingOVA.Visible = true;
            }
            if (Properties.Settings.Default.prmCreateSMART)
            {
                groupSmart.Visible = true;
            }
            if (Properties.Settings.Default.prmCreateZUnOVA)
            {
                groupCreateZUnOVA.Visible = true;
            }
            if (Properties.Settings.Default.prmCreateOtherZUn)
            {
                groupCreateOtherZUN.Visible = true;
            }
            buttonCreateOtherZUn.Label = Properties.Settings.Default.prmZUnButtonName;
        }

        #region Клик по чек боксам

        private void cbCreateZunFromMe_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.prmCreateZUnFromMe = cbCreateZunFromMe.Checked;
            Properties.Settings.Default.Save();
        }

        #endregion Клик по чек боксам

        #region Кнопки на ленте

        private void btnCreateZUnWithScreenShoot_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                if (Globals.ThisAddIn.doCreateZunInOVA)
                {
                    MessageBox.Show("Идёт процес создания ЗУн.\nПопробуйте через минуту...", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                CreatZunFromScreenshot();
            }
            catch (Exception err)
            {
                String sError = err.ToString();
                WithABF.CreateMailWithError(sError);
                MessageBox.Show(sError);
            }
        }

        private void buttonCreateZunWithMsg_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                if (Globals.ThisAddIn.doCreateZunInOVA)
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
                WithABF.CreateMailWithError(sError);
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
                WithABF.CreateMailWithError(sError);
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
                WithABF.CreateMailWithError(sError);
                MessageBox.Show("Не удается идентифицировать текущий объект как письмо.\nСоздать ЗУн можено только на основании письма.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            finally
            {
                notifyIconOVA.Visible = false;
            }
        }

        private void buttonToDeveloper_Click(object sender, RibbonControlEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:glaal@1ab.ru");
        }

        #endregion Кнопки на ленте

        #region Кнопки

        private void btnAboutProg_Click(object sender, RibbonControlEventArgs e)
        {
            FormAboutBox formAbout = new FormAboutBox();
            formAbout.ShowDialog();
        }

        private void buttonSettingSMART_Click(object sender, RibbonControlEventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.ShowDialog();
        }

        #endregion Кнопки

        #region Запуск фоновых обработчиков

        internal void backgroundWorkerOVAZUn_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            dynamic result = null;
            ParamsZUn paramsZUn = (ParamsZUn)e.Argument;
            //V83.COMConnector com1s = new V83.COMConnector();
            try
            {
                //По простому проверяю изменили текст или сразу нажали ОК
                //Вероятность того что кто то же укажет такой же текст равна 0
                if (paramsZUn.textZun.Contains("При необходимости укажите"))
                {
                    paramsZUn.textZun = "";
                }

                if (!String.IsNullOrEmpty(textZun))
                {
                    textZun += "\n\n";
                }

                //                string user = @"""Create_ZUn""";
                //                string pas = @"""bF6k6mjbCEfEJayL""";
                //#if DEBUG
                //                string file = @"""G:\\ABF""";
                //#else
                //                //string Srvr = @"""1ab-1cv81:2541""";
                //                //string Ref = @"""copy_abf""";
                //                string Srvr = @"""1ab-1cv80""";
                //                string Ref = @"""pav-oper82""";
                //#endif
                //                //com1s.PoolCapacity = 1;
                //                //com1s.PoolTimeout = 1;
                //                //com1s.MaxConnections = 1;
                //#if DEBUG
                //                string connectString = "File=" + file + ";Usr=" + user + ";Pwd=" + pas + ";";
                //#else
                //				string connectString = "Srvr=" + Srvr + ";Ref=" + Ref + ";Usr=" + user + ";Pwd=" + pas + ";";
                //#endif
                //                //result = com1s.Connect(connectString);
                //                //todo: удалить

                paramsZUn.dopRazrez = "1.Любые вопросы в ОВА(выбирайте этот разрез, если есть сомнения в выборе другого разреза)";

                //#if DEBUG

                //               //createZunResult = result.ДляВнешнихСоединений.Create_ZUn("glaal@1ab.ru", pathToFile, textZun + preTextZun, ref errorCreateZun, executorZUn, dopRazrez);
                //               //createZunResult = result.ДляВнешнихСоединений.Create_ZUn("glaal12@1ab.ru", pathToFile, preTextZun + textZun,ref errorCreateZun,executorZUn,dopRazrez);
                //#else
                //                //createZunResult = result.ДляВнешнихСоединений.Create_ZUn(EMailFromCurrentMail, pathToFile, textZun + preTextZun, ref errorCreateZun,executorZUn);
                //                //createZunResult = result.ДляВнешнихСоединений.GetResultCommand("Результат=10",  ref errorCreateZun);
                //                //MessageBox.Show(createZunResult);
                //#endif

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

                //if (createZunResult == "")
                //{
                //    e.Result = false;

                //    return;
                //}
                //else
                //{
                //    e.Result = true;

                //    return;
                //}
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());

                return;
            }
            //finally
            //{
            //    if (result != null)
            //    {
            //        Marshal.ReleaseComObject(result);
            //        result = null;
            //    }
            //    if (com1s != null)
            //    {
            //        Marshal.ReleaseComObject(com1s);
            //        com1s = null;
            //    }
            //    GC.Collect();
            //    GC.WaitForPendingFinalizers();
            //    GC.Collect();
            //}
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
                //string Srvr = @"""1ab-1cv81:2541""";
                //string Ref = @"""copy_abf""";
                string Srvr = @"""1ab-1cv80""";
                string Ref = @"""pav-oper82""";
                //            Srvr = "1ab-1cv81:2541"; Ref = "copy_abf";
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
                createZunResult = result.ДляВнешнихСоединений.Create_SMART("glaal@1ab.ru", executorSMART, textFormulirovka, textKriterii, pathToFile, vesSmart, DoDate, textComment, ref errorCreateZun);
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
                WithABF.CreateMailWithError(sError);
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

        #endregion Запуск фоновых обработчиков

        #region Обработка окончания работы фоновых обработчиков

        private void backgroundWorkerOVAZUn_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            //if ((bool)e.Result)
            //{
            //    //MessageBox.Show("Создана заявка универсальная в УК ОВА.\n" + createZunResult, "Заявка создана успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    notifyIconOVA.Icon = Properties.Resources.ico_1ab;
            //    notifyIconOVA.BalloonTipIcon = ToolTipIcon.Info;
            //    notifyIconOVA.BalloonTipText = createZunResult;
            //    notifyIconOVA.BalloonTipTitle = "Создана Заявка универсальная";
            //    notifyIconOVA.Text = "Через контекстное меню можно скопировать Дату и номер ЗУн";
            //    var myContextMenu = new ContextMenuStrip();
            //    var copyZUn = new ToolStripMenuItem("Скопировать ЗУн в буфер");
            //    myContextMenu.Items.Add(copyZUn);
            //    copyZUn.Click += copyZUn_Click;
            //    notifyIconOVA.ContextMenuStrip = myContextMenu;
            //    notifyIconOVA.Visible = true;
            //    notifyIconOVA.ShowBalloonTip(60000);
            //}
            //else
            //{
            //    //MessageBox.Show("При создании ЗУн возникла ошибка.\nПожалуйста сообщите текст ошибки в отдел УК ОВА.\n" + errorCreateZun, "Не удалось создать ЗУн в УК ОВА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    notifyIconOVA.Icon = Properties.Resources.ico_1ab;
            //    notifyIconOVA.BalloonTipIcon = ToolTipIcon.Error;
            //    notifyIconOVA.BalloonTipText = "В УК ОВА было отпралено письмо с ошибкой.";
            //    notifyIconOVA.BalloonTipTitle = "При создании ЗУн возникла ошибка";
            //    notifyIconOVA.Text = "";
            //    notifyIconOVA.Visible = true;
            //    notifyIconOVA.ShowBalloonTip(15000);

            //    WithABF.CreateMailWithError(errorCreateZun);
            //}
            //workWorker = false;

            ParamsZUn paramsZUn = (ParamsZUn)e.Result;
            if (paramsZUn.doComplit)
            {
                Globals.ThisAddIn.GlobalNotifyIcon.Icon = Properties.Resources.ico_1ab;
                Globals.ThisAddIn.GlobalNotifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                Globals.ThisAddIn.GlobalNotifyIcon.BalloonTipText = paramsZUn.createZunResult;
                Globals.ThisAddIn.GlobalNotifyIcon.BalloonTipTitle = "Создана Заявка универсальная";
                Globals.ThisAddIn.GlobalNotifyIcon.Text = "Через контекстное меню можно скопировать Дату и номер ЗУн";
                Globals.ThisAddIn.myContextMenu = new ContextMenuStrip();
                ToolStripMenuItem copyZUn = new ToolStripMenuItem("Скопировать ЗУн в буфер");
                Globals.ThisAddIn.LastCreateZunResult = paramsZUn.createZunResult;
                Globals.ThisAddIn.myContextMenu.Items.Add(copyZUn);
                copyZUn.Click += copyZUn_Click;
                Globals.ThisAddIn.GlobalNotifyIcon.ContextMenuStrip = Globals.ThisAddIn.myContextMenu;
                Globals.ThisAddIn.GlobalNotifyIcon.Visible = true;
                Globals.ThisAddIn.GlobalNotifyIcon.ShowBalloonTip(0);
            }
            else
            {
                Globals.ThisAddIn.GlobalNotifyIcon.Icon = Properties.Resources.ico_1ab;
                Globals.ThisAddIn.GlobalNotifyIcon.BalloonTipIcon = ToolTipIcon.Error;
                Globals.ThisAddIn.GlobalNotifyIcon.BalloonTipText = "В УК ОВА было отпралено письмо с ошибкой.";
                Globals.ThisAddIn.GlobalNotifyIcon.BalloonTipTitle = "При создании ЗУн возникла ошибка";
                Globals.ThisAddIn.GlobalNotifyIcon.Text = "";
                Globals.ThisAddIn.GlobalNotifyIcon.Visible = true;
                Globals.ThisAddIn.GlobalNotifyIcon.ShowBalloonTip(0);

                WithABF.CreateMailWithError(paramsZUn.errorCreateZun);
            }
            Globals.ThisAddIn.doCreateZunInOVA = false;
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
                notifyIconOVA.ShowBalloonTip(15000);

                WithABF.CreateMailWithError(errorCreateZun);
            }
            workWorkerSMART = false;
        }

        #endregion Обработка окончания работы фоновых обработчиков

        #region Другие функции

        /// <summary>
        /// Создание ЗУн из скриншота находящегося в буфере
        /// </summary>
        private void CreatZunFromScreenshot()
        {
            notifyIconOVA.Visible = false;
            string screenshotName = WithABF.SaveClipBoardToPicture(ref lastError);
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
                InstructionInZUn instructionForm = new InstructionInZUn();
                pathToFile = screenshotName;
                preTextZun = "Ошибка зарегестрирована из MS Outlook.\nПодробности в приложенном скриншоте.";
                instructionForm.TextZun = "При необходимости укажите подробности ошибки." + Environment.NewLine + "Либо просто нажмите ОК(Ctr+Enter)";
                instructionForm.ShowDialog();
                textZun = instructionForm.TextZun;
                executorZUn = instructionForm.Executor;
                if (instructionForm.ClickBnOk)
                {
                    Globals.ThisAddIn.doCreateZunInOVA = true;
                    this.backgroundWorkerOVAZUn.RunWorkerAsync();
                }
                instructionForm = null;
            }
        }

        /// <summary>
        /// Создание ЗУн из текущего письма
        /// </summary>
        internal void CreateZunFromMail()
        {
            //Если пользователь работает в ОВА и не включен флаг Создать ЗУн от текущего пользователя
            //Получаем адрес отправителя из письма
            //в противном случаее получаем адрес текущего пользователя
            if (OutlookAddInOVA.Globals.ThisAddIn.currentUserIsOVA && !Properties.Settings.Default.prmCreateZUnFromMe)
            {
                EMailFromCurrentMail = GetSmtpAddress(curItem);
            }
            else
            {
                EMailFromCurrentMail = OutlookAddInOVA.Globals.ThisAddIn.currentusermail;
            }

            string pathToFileMsg = WithABF.SaveEmailToMsg(curItem, ref lastError);
            if (pathToFileMsg == "")
            {
                MessageBox.Show("При сохранении письма в файл возникла ошибка.\nПожалуйста сообщите текст ошибки в отдел УК ОВА.\n" + lastError, "Не удалось создать ЗУн в УК ОВА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InstructionInZUn instructionForm = new InstructionInZUn();
            pathToFile = pathToFileMsg;
            preTextZun = "Заявка создана автоматически из MS Outlook.\nПодробности в приложенном письме.";
            instructionForm.TextZun = "При необходимости укажите подробности для заявки." + Environment.NewLine + "Либо просто нажмите ОК(Ctr+Enter)";
            instructionForm.ShowDialog();
            if (instructionForm.ClickBnOk)
            {
                Globals.ThisAddIn.doCreateZunInOVA = true;
                this.backgroundWorkerOVAZUn.RunWorkerAsync(FillParamsForZUn(instructionForm, pathToFileMsg));
            }
            instructionForm = null;
        }

        private ParamsZUn FillParamsForZUn(InstructionInZUn forminstruction, string pathToMsgFile)
        {
            ParamsZUn paramsZUN = new ParamsZUn();
            string textZUn = forminstruction.TextZun;

            if (String.IsNullOrEmpty(textZUn) || textZUn.Contains("При необходимости введите текст поручения ЗУн"))
            {
                textZUn = "Заявка создана автоматически из MS Outlook.\nПодробности в приложенном письме.";
            }
            //if (commentExecutor.Contains("При необходимости введите текст поручения ЗУн") || String.IsNullOrEmpty(textZUn))
            //{
            //    commentExecutor = "Заявка создана автоматически из MS Outlook.\nПодробности в приложенном письме.";
            //}

            paramsZUN.textZun = textZUn;
            paramsZUN.commentExecutorZUn = forminstruction.CommentExecutor;
            paramsZUN.executorZUn = forminstruction.Executor;
            paramsZUN.pathToFile = pathToMsgFile;
            paramsZUN.approval = forminstruction.ApproveList;

            return paramsZUN;
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

        private void CreatSMART(bool fastSmart = true, bool showForm = false)
        {
            string pathToFileMsg = WithABF.SaveEmailToMsg(curItem, ref lastError);
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
                    if (textKriterii == "")
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

        #endregion Другие функции
    }
}


//Сделать: Создать перерисовку Рибона при изменении настроек
//Сделать: Написать функционал создания ЗУн