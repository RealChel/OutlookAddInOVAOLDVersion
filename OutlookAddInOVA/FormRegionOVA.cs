using System;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using WithABF = OutlookAddInOVA.InteractionWithABF;

namespace OutlookAddInOVA
{
    partial class FormRegionOVA
    {
        internal bool checkedDoZunOVA;
        internal string textZUn;
        Outlook.MailItem mailItem=null;
        private bool ShowFormRegion=false;
        public ParamsZUn paramsZUn=new ParamsZUn();

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
                if (Properties.Settings.Default.prmHideFormRegion)
                {
                    e.Cancel = true;
                }
                        
                
            }
        }

        #endregion Фабрика областей формы

        private void ThisAddInPropertyChange(string name)
        {
            if (name == "To")
            {
                try
                {
                   
                    try
                    {
                        mailItem.PropertyChange -= ThisAddInPropertyChange;
                        string allmail = Globals.ThisAddIn.GetAllSMTPAddressForRecipients(mailItem);
                        bool findUserOVA = false;
                        foreach (string userOVA in Globals.ThisAddIn.arrUsersOVA)
                        {
                            if (allmail.Contains(userOVA))
                            {
                                findUserOVA = true;
                            }
                        }

                        
                        OutlookFormRegion.Visible =ShowFormRegion = findUserOVA;

                        
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                        WithABF.CreateMailWithError(e.ToString());
                        
                    }
                    finally
                    {
                        mailItem.PropertyChange += ThisAddInPropertyChange;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    WithABF.CreateMailWithError(e.ToString());
                }
            }
        }

        // Возникает перед отображением области формы.
        // Используйте this.OutlookItem для получения ссылки на текущий элемент Outlook.
        // Используйте this.OutlookFormRegion для получения ссылки на область формы.
        private void FormRegionOVA_FormRegionShowing(object sender, System.EventArgs e)
        {
            if (Globals.ThisAddIn.doCreateZunInOVA && !ShowFormRegion)
            {
                this.OutlookFormRegion.Visible = false;
                return;
            }
            mailItem = (Outlook.MailItem)this.OutlookItem;
            mailItem.PropertyChange += ThisAddInPropertyChange;
            string allmail = Globals.ThisAddIn.GetAllSMTPAddressForRecipients(mailItem);
            bool findUserOVA = false;
            foreach (string userOVA in Globals.ThisAddIn.arrUsersOVA)
            {
                if (allmail.Contains(userOVA))
                {
                    findUserOVA = true;
                }
            }
            this.OutlookFormRegion.Visible = ShowFormRegion= findUserOVA;

            mcIspolnitK.SelectionStart = paramsZUn.doDate;
            tbTextZUn.Text = paramsZUn.textZun;
            cbCreateZUn.Checked = paramsZUn.CreateZUnFlag;

            tabOVA.TabPages.Remove(tabPageApproval);

            mcIspolnitK.MinDate = DateTime.Now;
            checkBoxHideFromRegion.Checked = Properties.Settings.Default.prmHideFormRegion;
            //dataGridView1.DataSource = OutlookAddInOVA.Globals.ThisAddIn.listCoWorker;
            this.EnabledChanged += FormEnabledChange;
        }

        // Возникает перед закрытием области формы.
        // Используйте this.OutlookItem для получения ссылки на текущий элемент Outlook.
        // Используйте this.OutlookFormRegion для получения ссылки на область формы.
        private void FormRegionOVA_FormRegionClosed(object sender, System.EventArgs e)
        {
        }

        private void FormEnabledChange(object sender, EventArgs e)
        {
            if (Enabled)
            {
                checkBoxHideFromRegion.Checked = Properties.Settings.Default.prmHideFormRegion;
                cbCreateZUn.Checked = checkedDoZunOVA;
            }
            else
            {
                cbCreateZUn.Checked = false;
            }
        }

        private void cbApproval_CheckedChanged(object sender, EventArgs e)
        {
            if (cbApproval.Checked)
            {
                tabOVA.TabPages.Add(tabPageApproval);
            }
            else
            {
                tabOVA.TabPages.Remove(tabPageApproval);
            }
        }

        private void cbCreateZUn_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCreateZUn.Checked)
            {
                if (Globals.ThisAddIn.doCreateZunInOVA)
                {
                    MessageBox.Show("Вы уже создаете письмо в УК ОВА с созданием ЗУн.\nСнимите флаг создания ЗУн в другом письме и\nповторите попытку.", "Не возможно создать ЗУн");
                    cbCreateZUn.Checked = false;
                }
                else
                {
                    Globals.ThisAddIn.doCreateZunInOVA = true;
                }
            }
            else
            {
                if (Globals.ThisAddIn.doCreateZunInOVA)
                {
                    Globals.ThisAddIn.doCreateZunInOVA = false;
                }
            }

            //checkedDoZunOVA = cbCreateZUn.Checked;
            paramsZUn.CreateZUnFlag = cbCreateZUn.Checked;
        }

        private void checkBoxHideFromRegion_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.prmHideFormRegion = checkBoxHideFromRegion.Checked;
            Properties.Settings.Default.Save();
        }

        private void tbTextZUn_TextChanged(object sender, EventArgs e)
        {
            paramsZUn.textZun = tbTextZUn.Text;
        }

        private void mcIspolnitK_DateChanged(object sender, DateRangeEventArgs e)
        {
            paramsZUn.doDate = mcIspolnitK.SelectionStart;
        }
    }
}