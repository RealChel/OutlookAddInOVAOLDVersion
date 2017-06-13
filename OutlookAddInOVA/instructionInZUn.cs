using System;
using System.Drawing;
using System.Windows.Forms;

namespace OutlookAddInOVA
{
    public partial class instructionInZUn : Form
    {
        private bool doEntertext = false;

        #region Параметры

        private bool clickBnOkVal;
        private string textZunVal;
        private string executorVal;

        public string executor { get { return executorVal; } set { executorVal = value; } }

        public string textZun { get { return textZunVal; } set { textZunVal = value; } }

        public bool clickBnOk { get { return clickBnOkVal; } set { clickBnOkVal = value; } }

        #endregion Параметры

        #region Старт формы

        public instructionInZUn()
        {
            InitializeComponent();
        }

        private void instructionInZUn_Shown(object sender, EventArgs e)
        {
            tbInstruction.Text = textZun;
            tbInstruction.ForeColor = Color.Silver;
            tbInstruction.SelectionStart = 0;
            clickBnOk = false;
            comboBoxExecutor.DataSource = OutlookAddInOVA.Globals.ThisAddIn.listMyCoWorker;
            executor = "";
            if (!OutlookAddInOVA.Globals.ThisAddIn.currentUserIsOVA)
            {
                labelExecutor.Visible = false;
                comboBoxExecutor.Visible = false;
                tbInstruction.Location = new Point(0, 0);
                tbInstruction.Height += 32;
            }
        }

        #endregion Старт формы

        #region Кнопки

        private void btnOK_Click(object sender, EventArgs e)
        {
            CloseFormOnOK();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clickBnOk = false;
            textZun = "";
            executor = "";
            this.Hide();
        }

        #endregion Кнопки

        #region События

        private void tbInstruction_KeyDown(object sender, KeyEventArgs e)
        {
            if (!doEntertext)
            {
                tbInstruction.ForeColor = Color.Black;
                tbInstruction.Font = new Font(tbInstruction.Font.FontFamily, (float)10);
                tbInstruction.Text = "";
                doEntertext = true;
            }
            if (e.KeyCode == Keys.Return && e.Modifiers == Keys.Control)
            {
                CloseFormOnOK();
            }
        }

        private void comboBoxExecutor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            executor = comboBoxExecutor.SelectedValue.ToString();
        }

        #endregion События

        #region Другие функции

        private void CloseFormOnOK()
        {
            clickBnOk = true;
            textZun = tbInstruction.Text;
            this.Hide();
        }

        #endregion Другие функции
    }
}