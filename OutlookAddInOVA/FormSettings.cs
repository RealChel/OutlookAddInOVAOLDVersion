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
            tbZUnAddSegment.Text = Properties.Settings.Default.prmZUnAddSegment;
            tbZUnButtonName.Text = Properties.Settings.Default.prmZUnButtonName;

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
            Properties.Settings.Default.prmZUnAddSegment = tbZUnAddSegment.Text.Trim();
            Properties.Settings.Default.prmZUnButtonName = tbZUnButtonName.Text.Trim();
            Properties.Settings.Default.Save();
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
        }
        private void showHideZUn()
        {
            if (!cbCreateZUnOVA.Checked & !cbCreateOtherZUn.Checked)
            {
                tabControlSettings.TabPages.Remove(tabPageZUn);
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
    }
}
//Ошибка: не перерисуются вкладки при включении флагов