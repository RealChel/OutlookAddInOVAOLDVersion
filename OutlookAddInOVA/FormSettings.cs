using System;
using System.Windows.Forms;

namespace OutlookAddInOVA
{
    public partial class FormSettings : Form
    {
        #region Старт формы

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Shown(object sender, EventArgs e)
        {
            tbFormulirovkaExecutorSmart.Text = Properties.Settings.Default.prmSmartExecutorFormulirovka;
            tbKriteriiExecutorSmart.Text = Properties.Settings.Default.prmSmartExecutorKriterii;
            tbFormulirovkaFastSmart.Text = Properties.Settings.Default.prmSmartFastFormulirovka;
            tbKriteriiFastSmart.Text = Properties.Settings.Default.prmSmartFastKriterii;
            cbCreateOtherZUn.Checked = Properties.Settings.Default.prmCreateOtherZUn;
            cbCreateSMART.Checked = Properties.Settings.Default.prmCreateSMART;
            cbCreateZUnOVA.Checked = Properties.Settings.Default.prmCreateZUnOVA;
            cbCreateZUnTO.Checked = Properties.Settings.Default.prmCreateZUnTO;
            tbZUnAddSegment.Text = Properties.Settings.Default.prmZUnDopRazrez;
            tbZUnButtonName.Text = Properties.Settings.Default.prmZUnButtonName;
            tbPodrazdTo.Text = Properties.Settings.Default.prmPodrazdTo;

            showHideZUn();
            showHideSMART();
        }

        #endregion Старт формы

        #region Кнопки

        private void btnOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.prmSmartExecutorFormulirovka = tbFormulirovkaExecutorSmart.Text;
            Properties.Settings.Default.prmSmartExecutorKriterii = tbKriteriiExecutorSmart.Text;
            Properties.Settings.Default.prmSmartFastFormulirovka = tbFormulirovkaFastSmart.Text;
            Properties.Settings.Default.prmSmartFastKriterii = tbKriteriiFastSmart.Text;
            Properties.Settings.Default.prmCreateOtherZUn = cbCreateOtherZUn.Checked;
            Properties.Settings.Default.prmCreateSMART = cbCreateSMART.Checked;
            Properties.Settings.Default.prmCreateZUnOVA = cbCreateZUnOVA.Checked;
            Properties.Settings.Default.prmZUnDopRazrez = tbZUnAddSegment.Text.Trim();
            Properties.Settings.Default.prmZUnButtonName = tbZUnButtonName.Text.Trim();
            Properties.Settings.Default.prmPodrazdTo = tbPodrazdTo.Text.Trim();
            Properties.Settings.Default.prmCreateZUnTO = cbCreateZUnTO.Checked;
            Properties.Settings.Default.Save();

            Globals.Ribbons.RibbonOVA.ReLoadRibbon();
        }

        private void buttonCаncel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion Кнопки

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult mbbAnswer = MessageBox.Show("Закрыть окно настроек и создать письмо?\nНастройки не будут сохранены.", "Отправить письмо с пожеланиями?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (mbbAnswer == DialogResult.Yes)
            {
                this.Hide();
                System.Diagnostics.Process.Start("mailto:glaal@1ab.ru");
            }
        }

        private void showHideSMART()
        {
            if (!cbCreateSMART.Checked)
            {
                tabControlSettings.TabPages.Remove(tabPageSMART);
            }
            else
            {
                if (!tabControlSettings.Contains(tabPageSMART))
                {
                    tabControlSettings.TabPages.Insert((tabControlSettings.TabPages.Count == 1) ? 1 : 2, tabPageSMART);
                }
            }
        }
        /// <summary>
        /// Показывать скрывать группу Заявок
        /// </summary>
        private void showHideZUn()
        {
            if (!cbCreateZUnOVA.Checked & !cbCreateOtherZUn.Checked & !cbCreateZUnTO.Checked)
            {
                tabControlSettings.TabPages.Remove(tabPageZUn);
            }
            else
            {
                if (!tabControlSettings.Contains(tabPageZUn))
                {
                    tabControlSettings.TabPages.Insert(1, tabPageZUn);
                }
                
            }

        }

        private void cbCreateSMART_CheckedChanged(object sender, EventArgs e)
        {
            showHideSMART();
        }

        private void cbCreateOtherZUn_CheckedChanged(object sender, EventArgs e)
        {
            showHideZUn();
        }

        private void cbCreateZUnOVA_CheckedChanged(object sender, EventArgs e)
        {
            showHideZUn();
        }

        private void cbCreateZUnTO_CheckedChanged(object sender, EventArgs e)
        {
            showHideZUn();
        }
    }
}
