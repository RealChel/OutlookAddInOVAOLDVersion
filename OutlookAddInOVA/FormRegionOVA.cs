using System;
using System.Drawing;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using WithABF = OutlookAddInOVA.InteractionWithABF;

namespace OutlookAddInOVA
{
    partial class FormRegionOVA
    {
        private bool DoEnterInstruction = false;
        private bool DoEnterComment = false;
        private string[,] approveList;

        public bool CheckedDoZunOVA { get; set; }
        public string TextZUn { get; set; }
        public DateTime DoDate { get; set; }
        public String CommentExecutor { get; set; }
        public String Executor { get; set; }

        public bool Important { get; set; }
        public string DopRazrez { get; set; }

        public string[,] ApproveList
        {
            get
            {
                int rowscount = dataGVWapproval.RowCount-1;
                if (rowscount > 1)
                {
                    approveList = new string[rowscount, 2];
                    for (int i = 0; i <= rowscount-1; i++)
                    {
                        approveList[i, 0] = (string)dataGVWapproval.Rows[i].Cells[0].Value;
                        approveList[i, 1] = (string)dataGVWapproval.Rows[i].Cells[1].Value;
                    }
                }
                return approveList;
            }
        }

        private Outlook.MailItem mailItem = null;
        //private bool ShowFormRegion=false;
        //public ParamsZUn paramsZUn=new ParamsZUn();

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

        // Возникает перед отображением области формы.
        // Используйте this.OutlookItem для получения ссылки на текущий элемент Outlook.
        // Используйте this.OutlookFormRegion для получения ссылки на область формы.
        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormRegionOVA_FormRegionShowing(object sender, System.EventArgs e)
        {
            this.OutlookFormRegion.Visible = false;
            try
            {
                Microsoft.Office.Tools.Outlook.FormRegionControl _sender = (Microsoft.Office.Tools.Outlook.FormRegionControl)sender;
                if (_sender.OutlookFormRegion.Inspector is Microsoft.Office.Interop.Outlook.Explorer)
                {
                    return;
                }
                bool currUserIsOVA = Globals.ThisAddIn.currentUserIsOVA;
                Outlook.MailItem mailItem = (Outlook.MailItem)this.OutlookItem;
                string allmail = Globals.ThisAddIn.GetAllSMTPAddressForRecipients(mailItem);
                bool findUserOVA = false;
                foreach (string userOVA in Globals.ThisAddIn.arrUsersOVA)
                {
                    if (allmail.Contains(userOVA))
                    {
                        findUserOVA = true;
                    }
                }

                this.OutlookFormRegion.Visible = findUserOVA;

                mcIspolnitK.MinDate = DateTime.Now;
                checkBoxHideFromRegion.Checked = Properties.Settings.Default.prmHideFormRegion;
                this.EnabledChanged += FormEnabledChange;
                comboBoxDopRazrez.Visible = cbApproval.Visible = currUserIsOVA;
                if (!currUserIsOVA)
                {
                    tabOVA.TabPages.Remove(tabPageAdditionalForOVA);
                }
                else
                {
                    tbCommentToExecutor.ForeColor = Color.Silver;
                    tbCommentToExecutor.SelectionStart = 0;
                    //DataGridViewComboBoxColumn CoWorkerColumn = (DataGridViewComboBoxColumn)dataGVWapproval.Columns["CoWorker"];
                    //CoWorkerColumn.DataSource = OutlookAddInOVA.Globals.ThisAddIn.listAllCoWorker;
                    comboBoxExecutor.DataSource = OutlookAddInOVA.Globals.ThisAddIn.listMyCoWorker;
                    CoWorker.DataSource= OutlookAddInOVA.Globals.ThisAddIn.listAllCoWorker;
                    CoWorker.ValueMember = "Email";
                    CoWorker.DisplayMember = "FIO";
                }
                tbTextZUn.ForeColor = Color.Silver;
                tbTextZUn.SelectionStart = 0;
                tbCommentToExecutor.ForeColor = Color.Silver;
                tbCommentToExecutor.SelectionStart = 0;
                
                tabOVA.TabPages.Remove(tabPageApproval);
                comboBoxExecutor.SelectedIndex = -1;
                comboBoxDopRazrez.SelectedIndex = 0;
            }
            catch (InvalidCastException e_cast)
            {
                //Пришлось так обработать , понимание того что форма открываеться не в одтельном инспекторе
            }
            catch (Exception err)
            {
                String sError = err.ToString();
                WithABF.CreateMailWithError(sError);
                MessageBox.Show(sError);
            }
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
                cbCreateZUn.Checked = CheckedDoZunOVA;
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
            CheckedDoZunOVA = cbCreateZUn.Checked;
        }

        private void checkBoxHideFromRegion_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.prmHideFormRegion = checkBoxHideFromRegion.Checked;
            Properties.Settings.Default.Save();
        }

        private void tbTextZUn_TextChanged(object sender, EventArgs e)
        {
            TextZUn = tbTextZUn.Text;
        }

        private void mcIspolnitK_DateChanged(object sender, DateRangeEventArgs e)
        {
            DoDate = mcIspolnitK.SelectionStart;
        }

        private void tbCommentToExecutor_TextChanged(object sender, EventArgs e)
        {
            CommentExecutor = tbCommentToExecutor.Text;
        }

        private void tbCommentToExecutor_KeyDown(object sender, KeyEventArgs e)
        {
            if (!DoEnterComment)
            {
                tbCommentToExecutor.ForeColor = Color.Black;
                tbCommentToExecutor.Font = new Font(tbCommentToExecutor.Font.FontFamily, (float)10);
                tbCommentToExecutor.Text = "";
                DoEnterComment = true;
            }
        }

        private void tbTextZUn_KeyDown(object sender, KeyEventArgs e)
        {
            if (!DoEnterInstruction)
            {
                tbTextZUn.ForeColor = Color.Black;
                tbTextZUn.Font = new Font(tbCommentToExecutor.Font.FontFamily, (float)10);
                tbTextZUn.Text = "";
                DoEnterInstruction = true;
            }
        }

        private void cbImportant_CheckedChanged(object sender, EventArgs e)
        {
            Important = cbImportant.Checked;
        }

        private void comboBoxDopRazrez_SelectedIndexChanged(object sender, EventArgs e)
        {
            DopRazrez = comboBoxDopRazrez.SelectedItem?.ToString() ?? "";
        }

        private void comboBoxExecutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Executor = comboBoxExecutor.SelectedValue?.ToString() ?? "";
        }

        private void dataGVWapproval_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGVWapproval.Rows.Count>1 && e.ColumnIndex == 0)
            {
                if (dataGVWapproval.Rows[e.RowIndex].Cells[1].Value is null)
                {
                    dataGVWapproval.Rows[e.RowIndex].Cells[1].Value = "Согласовать";
                }
            }
        }

        private void dataGVWapproval_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGVWapproval.BeginEdit(true);
            
        }
    }
}