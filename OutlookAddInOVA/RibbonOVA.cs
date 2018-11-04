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
            EMailFromCurrentMail = OutlookAddInOVA.Globals.ThisAddIn.currentUserMail;
            //MessageBox.Show(OutlookAddInOVA.Globals.ThisAddIn.currentusermail);
            ReLoadRibbon();
        }

        #region Клик по чек боксам

        private void cbCreateZunFromMe_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.prmCreateZUnFromMe = cbCreateZunFromMe.Checked;
            Properties.Settings.Default.Save();
        }

        #endregion Клик по чек боксам

        #region Кнопки на ленте

        private void btnCreateZUnWithScreenShootToOVA_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                if (Globals.ThisAddIn.doCreateZUn)
                {
                    MessageBox.Show("Идёт процес создания ЗУн.\nПопробуйте через минуту...", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!SetCurrenEmail(sender))
                {
                    return;
                }
                CreatZunFromScreenShot("УК ОВА");
            }
            catch (Exception err)
            {
                String sError = err.ToString();
                WithABF.CreateMailWithError(sError);
                MessageBox.Show(sError);
            }
            
        }

        private void btnCreateZUnWithScreenShootInTO_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                if (Globals.ThisAddIn.doCreateZUn)
                {
                    MessageBox.Show("Идёт процес создания ЗУн.\nПопробуйте через минуту...", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //if (!SetCurrenEmail(sender))
                //{
                //    return;
                //}
                CreatZunFromScreenShot("УК ТО");
            }
            catch (Exception err)
            {
                String sError = err.ToString();
                WithABF.CreateMailWithError(sError);
                MessageBox.Show(sError);
            }
            
        }

        private void btnCreateZunWithMsgToOVA_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                if (Globals.ThisAddIn.doCreateZUn)
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


            string podrazdTo = "УК ОВА";
            string dopRazrez = "1.Любые вопросы в ОВА (выбирайте этот разрез, если есть сомнения в выборе другого разреза)";
            
            CreateZunFromMail(podrazdTo, dopRazrez);
        }


        private void buttonCreateZunInToWithMsg_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                if (Globals.ThisAddIn.doCreateZUn)
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


            string podrazdTo = "УК ТО";
            string dopRazrez = "1.Работа ТО по офису";

            CreateZunFromMail(podrazdTo, dopRazrez);
        }


        /// <summary>
        /// Создает ЗУн в подразделение указанное в настройках пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateOtherZUn_Click(object sender, RibbonControlEventArgs e)
        {

            string dopRazrez = Properties.Settings.Default.prmZUnDopRazrez;
            if (String.IsNullOrEmpty(dopRazrez))
            {
                MessageBox.Show("Не указан доп.разрез в который необходимо создавать заявку.\n Заполните доп.разрез в настройках.", "Не возможно создать ЗУн", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string podrazdTo = Properties.Settings.Default.prmPodrazdTo;
            if (String.IsNullOrEmpty(podrazdTo))
            {
                MessageBox.Show("Не указано подразделение в которое необходимо создавать заявку.\n Заполните подразделение в настройках.", "Не возможно создать ЗУн", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (Globals.ThisAddIn.doCreateZUn)
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


           
            CreateZunFromMail(podrazdTo, dopRazrez);

        }
        private void btnCreateSmartToMe_Click(object sender, RibbonControlEventArgs e)
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

        private void btnCreateSmartToExcevutor_Click(object sender, RibbonControlEventArgs e)
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

        /// <summary>
        /// Открывать встроенный почтовый клиент, с вставкой мейла разработчику
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToDeveloper_Click(object sender, RibbonControlEventArgs e)
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
            ParamsZUn paramsZUn = (ParamsZUn)e.Argument;
            try
            {
    
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
            // Возможно закрытие соеденения вынести туда где оно создается
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

                 createZunResult = result.ДляВнешнихСоединений.Create_SMART(OutlookAddInOVA.Globals.ThisAddIn.currentUserMail, executorSMART, textFormulirovka, textKriterii, pathToFile, vesSmart, DoDate, textComment, ref errorCreateZun);
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
            //Сделать: Создание из скриншота не работает
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
            Globals.ThisAddIn.doCreateZUn = false;
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
        private void CreatZunFromScreenShot(string podrazd="УК ОВА")
        {
            notifyIconOVA.Visible = false;
            string screenshotName = WithABF.SaveClipBoardToPicture(ref lastError);
            if (screenshotName == "")
            {
                if (lastError == "Буфер не содержит картинку")
                {
                    MessageBox.Show("Буфер обмена не содержит картинку.\nСкопируйте в буфер картинку или сделайте скриншот.\nПовторите операцию.", "Не удалось создать ЗУн в "+podrazd, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("При сохранении скриншота возникла ошибка.\nПожалуйста сообщите текст ошибки в отдел УК ОВА.\n" + lastError, "Не удалось создать ЗУн в " + podrazd, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
   
                string dopRazrez = "";
                switch (podrazd)
                {
                    case "УК ОВА":
                        dopRazrez = "1.Любые вопросы в ОВА (выбирайте этот разрез, если есть сомнения в выборе другого разреза)";
                        break;
                    case "УК ТО":
                        dopRazrez = "1.Работа ТО по офису";
                        break;
                }

                CreateZunFromMail(podrazd, dopRazrez, screenshotName);

                //InstructionInZUn instructionForm = new InstructionInZUn();
                //pathToFile = screenshotName;
                //preTextZun = "Ошибка зарегестрирована из MS Outlook.\nПодробности в приложенном скриншоте.";
                //instructionForm.TextZun = "При необходимости укажите подробности ошибки." + Environment.NewLine + "Либо просто нажмите ОК(Ctr+Enter)";
                //instructionForm.ShowDialog();
                //textZun = instructionForm.TextZun;
                //executorZUn = instructionForm.Executor;
                //if (instructionForm.ClickBnOk)
                //{
                //    Globals.ThisAddIn.doCreateZUn = true;
                //    this.backgroundWorkerOVAZUn.RunWorkerAsync();
                //}
                //instructionForm = null;
            }
        }

        /// <summary>
        /// Создание ЗУн в ОВА и ТО 
        /// </summary>
        internal void CreateZunFromMail(string podrazdTo,string dopRazrez,string pathToFileMsg="")
        {
            //Если пользователь работает в ОВА или ТО и не включен флаг Создать ЗУн от текущего пользователя
            //Получаем адрес отправителя из письма
            //в противном случаее получаем адрес текущего пользователя
            string pathToFile = "";
            try
            {
               
                //Если переданный путь пустой, значит надо сохранить текущее письмо в файл.
                if (String.IsNullOrEmpty(pathToFileMsg))
                {

                    pathToFile = WithABF.SaveEmailToMsg(curItem, ref lastError);
                }
                else
                {
                    pathToFile = pathToFileMsg;
                }

                //Сделать: надо обработать когда либо не сохранили письмо и вернулось пустое знаение либо скриншот пустой
                //if (pathToFileMsg == "")
                //{
                //    MessageBox.Show("При сохранении письма в файл возникла ошибка.\nПожалуйста сообщите текст ошибки в отдел УК ОВА.\n" + lastError, "Не удалось создать ЗУн в УК ОВА,не указан файл вложения.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}


                //Определяем от кого создавать ЗУн
                //Если переданная строка пустая, значит мы создаем из скриншота, а значит только от имени текущего пользователя создается ЗУн
                if (String.IsNullOrEmpty(pathToFileMsg) && ((OutlookAddInOVA.Globals.ThisAddIn.currentUserIsOVA || OutlookAddInOVA.Globals.ThisAddIn.currentUserIsTO) && !Properties.Settings.Default.prmCreateZUnFromMe))
                {
                    EMailFromCurrentMail = GetSmtpAddress(curItem);
                }
                else
                {
                    EMailFromCurrentMail = OutlookAddInOVA.Globals.ThisAddIn.currentUserMail;
                }
                              

                InstructionInZUn instructionForm = new InstructionInZUn();
                preTextZun = "Заявка создана автоматически из MS Outlook.\nАвтор не указал дополнительный текст поручения\nПодробности в приложенном письме.";
                instructionForm.TextZun = "При необходимости укажите подробности для заявки." + Environment.NewLine + "Либо просто нажмите ОК(Ctr+Enter)";
                instructionForm.ZunTo = podrazdTo;
                instructionForm.ShowDialog();
                if (instructionForm.ClickBnOk)
                {
                    Globals.ThisAddIn.doCreateZUn = true;
                    this.backgroundWorkerOVAZUn.RunWorkerAsync(FillParamsForZUn(podrazdTo, dopRazrez, instructionForm, pathToFile, EMailFromCurrentMail));
                }
                instructionForm = null;
            }
            catch (Exception err)
            {
                String sError = err.ToString();
                WithABF.CreateMailWithError(sError);
                MessageBox.Show(sError);
            }


            
        }
        /// <summary>
        /// Создается Класс с параметрами для ЗУн
        /// </summary>
        /// <param name="podrazdTo">Подразделение</param>
        /// <param name="dopRazrez">Дополнительный разрез</param>
        /// <param name="forminstruction">Форма ввода данных для зун, тип класс InstructionInZUn</param>
        /// <param name="pathToMsgFile">Путь к файлу который надо вложить</param>
        /// <returns></returns>
        private ParamsZUn FillParamsForZUn(string podrazdTo, string dopRazrez,InstructionInZUn forminstruction, string pathToMsgFile,string EMailFromCurrentMail="")
        {
            ParamsZUn paramsZUN = new ParamsZUn();
            string textZUn = forminstruction.TextZun;
            if (String.IsNullOrEmpty(EMailFromCurrentMail))
            {
                EMailFromCurrentMail = OutlookAddInOVA.Globals.ThisAddIn.currentUserMail;
            }
            if (String.IsNullOrEmpty(textZUn))
            {
                textZUn = "Заявка создана автоматически из MS Outlook.\nАвтор не указал дополнительный текст поручения\nПодробности в приложенном письме.";
            }
          
            paramsZUN.textZun = textZUn;
            paramsZUN.commentExecutorZUn = forminstruction.CommentExecutor;
            paramsZUN.executorZUn = forminstruction.Executor;
            paramsZUN.pathToFile = pathToMsgFile;
            paramsZUN.approval = forminstruction.ApproveList;
            paramsZUN.dopRazrez = dopRazrez;
            paramsZUN.podrazdTo = podrazdTo;
            paramsZUN.zunfrom = EMailFromCurrentMail;

            return paramsZUN;
        }

        /// <summary>
        /// В зависимости от окружения текущего Item, определеям этот самый Item и сохраняем в глобальной переменной
        /// </summary>
        /// <param name="selectedItem"></param>
        /// <returns></returns>
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
        //private void button1_Click(object sender, RibbonControlEventArgs e)
        //{
        //    notifyIconOVA.Icon = Properties.Resources.ico_1ab;
        //    notifyIconOVA.BalloonTipIcon = ToolTipIcon.Error;
        //    notifyIconOVA.BalloonTipText = "Заявка универсальная №УК12/12312 от 12.12.2017";
        //    notifyIconOVA.BalloonTipTitle = "Создана Заявка ниверсальная";
        //    notifyIconOVA.Text = "Двойной клик по иконке копировать данные в буфер";
        //    notifyIconOVA.Visible = true;

        //    var myContextMenu = new ContextMenuStrip();
        //    var exit = new ToolStripMenuItem("Скопировать ЗУн в буфер");
        //    myContextMenu.Items.Add(exit);
        //    exit.Click += copyZUn_Click;
        //    notifyIconOVA.ContextMenuStrip = myContextMenu;
        //    notifyIconOVA.ShowBalloonTip(50000);
        //}

        private void copyZUn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(createZunResult);
            notifyIconOVA.Visible = false; ;
        }

        /// <summary>
        /// Определяем адрес с которого пришло письмо
        /// </summary>
        /// <param name="oItem">Тип Outlook.MailItem </param>
        /// <returns></returns>
        private string GetSmtpAddress(Outlook.MailItem oItem)
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
                executorSMART = OutlookAddInOVA.Globals.ThisAddIn.currentUserMail;
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
                    executorSMART = OutlookAddInOVA.Globals.ThisAddIn.currentUserMail;
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

        /// <summary>
        /// Перересуем Рибон в зависимости от настроек
        /// </summary>
        internal void ReLoadRibbon()
        {
            
            groupSettingOVA.Visible = OutlookAddInOVA.Globals.ThisAddIn.currentUserIsOVA || OutlookAddInOVA.Globals.ThisAddIn.currentUserIsTO;
            groupSmart.Visible = Properties.Settings.Default.prmCreateSMART;
            groupCreateZUnOVA.Visible = Properties.Settings.Default.prmCreateZUnOVA;
            groupCreateZUnTO.Visible = Properties.Settings.Default.prmCreateZUnTO;
            groupCreateOtherZUN.Visible = Properties.Settings.Default.prmCreateOtherZUn;
            
            buttonCreateOtherZUn.Label = Properties.Settings.Default.prmZUnButtonName;
        }




        #endregion Другие функции
    }
}

