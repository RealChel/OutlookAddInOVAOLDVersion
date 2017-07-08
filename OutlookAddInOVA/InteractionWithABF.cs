﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace OutlookAddInOVA
{
    internal static class InteractionWithABF
    {
        internal static bool Create_ZUn(ParamsZUn paramsZUn)
        {
            try
            {
                ////По простому проверяю изменили текст или сразу нажали ОК
                //if (textZun.Contains("При необходимости укажите"))
                //{
                //    textZun = "";
                //}

                //if (!String.IsNullOrEmpty(textZun))
                //{
                //    textZun += "\n\n";
                //}

                string doDate = "";
                if (paramsZUn.doDate==null)
                {
                    doDate = DateTime.Now.ToString("yyyyMMdd190000");
                }
                else
                {
                    doDate = paramsZUn.doDate.ToString("yyyyMMdd190000");
                }
                


            //    string textZun, string pathToFile, string AddTextZun, string executorZUn, string commentExecutor,
            //string dopRazrez,bool important, DateTime doDate,string[] approvals, ref string errorCreateZun, ref string createZunResult

                if (!CreateConnection())
                {
                    paramsZUn.errorCreateZun = "Не удалось создать подключение к 1С";
                    return false;
                }




#if DEBUG
                paramsZUn.createZunResult = Globals.ThisAddIn.ConnetionTo1C.ДляВнешнихСоединений.Create_ZUn
                    ("glaal@1ab.ru", paramsZUn.pathToFile, paramsZUn.textZun + paramsZUn.preTextZun, ref paramsZUn.errorCreateZun,paramsZUn.executorZUn,paramsZUn.dopRazrez,paramsZUn.commentExecutorZUn,doDate,paramsZUn.importan,paramsZUn.approval);
                //createZunResult = result.ДляВнешнихСоединений.Create_ZUn("glaal12@1ab.ru", pathToFile, preTextZun + textZun,ref errorCreateZun,executorZUn,dopRazrez);
#else
                createZunResult = result.ДляВнешнихСоединений.Create_ZUn(EMailFromCurrentMail, pathToFile, textZun + preTextZun, ref errorCreateZun,executorZUn);
                //createZunResult = result.ДляВнешнихСоединений.GetResultCommand("Результат=10",  ref errorCreateZun);
                //MessageBox.Show(createZunResult);
#endif
                if (paramsZUn.createZunResult == "")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                CreateMailWithError(e.ToString());
                paramsZUn.errorCreateZun = "Возникла не предвиденная ошика.";
                return false;
            }
            //finally //пока не удалять, посмотрю будет ли много лицензий
            //{
            //    Marshal.ReleaseComObject(result);
            //    result = null;

            //    Marshal.ReleaseComObject(com1s);
            //    com1s = null;
            //    GC.Collect();
            //    GC.WaitForPendingFinalizers();
            //    GC.Collect();
            //}
        }

        internal static bool CreateConnection()
        {
            try
            {
                if (Globals.ThisAddIn.com1s == null)
                {
                    Globals.ThisAddIn.com1s = new V83.COMConnector();
                }

                if (Globals.ThisAddIn.ConnetionTo1C == null)
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
#endif
                    Globals.ThisAddIn.com1s.PoolCapacity = 1;
                    Globals.ThisAddIn.com1s.PoolTimeout = 1;
                    Globals.ThisAddIn.com1s.MaxConnections = 1;
#if DEBUG
                    string connectString = "File=" + file + ";Usr=" + user + ";Pwd=" + pas + ";";
#else
				    string connectString = "Srvr=" + Srvr + ";Ref=" + Ref + ";Usr=" + user + ";Pwd=" + pas + ";";
#endif
                    Globals.ThisAddIn.ConnetionTo1C = Globals.ThisAddIn.com1s.Connect(connectString);
                }
                return true;
            }
            catch (Exception e)
            {
                CreateMailWithError(e.ToString());
                return false;
            }
        }

        internal static string SaveEmailToMsg(Outlook.MailItem mailItem, ref string lastError)
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
                CreateMailWithError(lastError);
                return "";
            }
        }

        private static string GetPathToSave(string extension)
        {
            string tempFolder = Path.GetTempPath();
            string tempFileName = SystemInformation.ComputerName + "_" + SystemInformation.UserName + "_" + DateTime.Now.ToString("dd.MM.yyyy_hhmmss") + "." + extension;

            return tempFolder + tempFileName;
        }

        public static string SaveClipBoardToPicture(ref string lastError)
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
                CreateMailWithError(lastError);
                return "";
            }
        }

        internal static void CreateMailWithError(string sError = "")
        {
            Outlook.MailItem mailItem = (Outlook.MailItem)
            OutlookAddInOVA.Globals.ThisAddIn.Application.CreateItem(Outlook.OlItemType.olMailItem);
            mailItem.Subject = "В работе надстройки OutlookAddInOVA возникла ошибка";
            mailItem.To = "glaal@1ab.ru";
            mailItem.Body = sError;
            mailItem.Importance = Outlook.OlImportance.olImportanceHigh;
            mailItem.Send();
        }
    }

    internal class ParamsZUn
    {
        internal string textZun;
        internal string preTextZun;
        internal string pathToFile;
        internal string executorZUn;
        internal string commentExecutorZUn;
        internal string dopRazrez;
        internal DateTime doDate;
        internal bool importan;
        internal bool doComplit;
        internal string[,] approval;
        internal string errorCreateZun;
        internal string createZunResult;

        internal ParamsZUn()
        {
            doComplit = false;
            textZun = "";
            preTextZun = "";
            pathToFile = "";
            executorZUn = "";
            commentExecutorZUn = "";
            dopRazrez = "";
            doDate = DateTime.Now;
            importan = false;
            
        }

        internal ParamsZUn(string textZun, string preTextZun, string pathToFile, string executorZUn, string commentExecutorZUn, string dopRazrez, DateTime doDate, bool importan, string[,] approval)
        {
            this.textZun = textZun;
            this.preTextZun = preTextZun;
            this.pathToFile = pathToFile;
            this.executorZUn = executorZUn;
            this.commentExecutorZUn = commentExecutorZUn;
            this.dopRazrez = dopRazrez;
            this.doDate = doDate;
            this.importan = importan;
            this.approval = approval;    
        }
    }
}