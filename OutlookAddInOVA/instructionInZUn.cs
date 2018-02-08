using System;
using System.Drawing;
using System.Windows.Forms;

namespace OutlookAddInOVA
{
    public partial class InstructionInZUn : Form
    {
        private bool doEnterInstruction = false;
        private bool doEnterCommentToExecutor = false;

        #region Параметры

        private string[,] approveList;

        public string Executor { get; set; }

        public string TextZun { get; set; }

        public bool ClickBnOk { get; set; }

        public string[,] ApproveList
        {
            get
            {
                int rowscount = dataGVWapproval.RowCount - 1;
                if (rowscount > 1)
                {
                    approveList = new string[rowscount, 2];
                    for (int i = 0; i <= rowscount - 1; i++)
                    {
                        approveList[i, 0] = (string)dataGVWapproval.Rows[i].Cells[0].Value;
                        approveList[i, 1] = (string)dataGVWapproval.Rows[i].Cells[1].Value;
                    }
                }
                return approveList;
            }
        }

        public string CommentExecutor { get; set; }

        #endregion Параметры

        #region Старт формы

        public InstructionInZUn()
        {
            InitializeComponent();
        }

        private void instructionInZUn_Shown(object sender, EventArgs e)
        {
            tbInstruction.Text = TextZun;
            tbInstruction.ForeColor = Color.Silver;
            tbInstruction.SelectionStart = 0;
            tbCommentToExecutor.ForeColor = Color.Silver;
            tbCommentToExecutor.SelectionStart = 0;
            comboBoxExecutor.SelectedIndex = -1;

            ClickBnOk = false;
            comboBoxExecutor.DataSource = OutlookAddInOVA.Globals.ThisAddIn.listMyCoWorker;
            Executor = "";
            //if (!OutlookAddInOVA.Globals.ThisAddIn.currentUserIsOVA)
            //{
            //    labelExecutor.Visible = false;
            //    comboBoxExecutor.Visible = false;
            //    tbInstruction.Location = new Point(0, 0);
            //    tbInstruction.Height += 32;
            //}
            if (!OutlookAddInOVA.Globals.ThisAddIn.currentUserIsOVA)
            {
                tabControlZUn.TabPages.Remove(tabPageOVA);
                tabControlZUn.TabPages.Remove(tabPageApproved);
            }
            else
            {
                comboBoxExecutor.DataSource = OutlookAddInOVA.Globals.ThisAddIn.listMyCoWorker;
                CoWorker.DataSource = OutlookAddInOVA.Globals.ThisAddIn.listAllCoWorker;
                CoWorker.ValueMember = "Email";
                CoWorker.DisplayMember = "FIO";
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
            ClickBnOk = false;
            TextZun = "";
            Executor = "";
            this.Hide();
        }

        #endregion Кнопки

        #region События

        private void tbInstruction_KeyDown(object sender, KeyEventArgs e)
        {
            if (!doEnterInstruction)
            {
                tbInstruction.ForeColor = Color.Black;
                tbInstruction.Font = new Font(tbInstruction.Font.FontFamily, (float)10);
                tbInstruction.Text = "";
                doEnterInstruction = true;
            }
            if (e.KeyCode == Keys.Return && e.Modifiers == Keys.Control)
            {
                CloseFormOnOK();
            }
        }

        private void comboBoxExecutor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Executor = comboBoxExecutor.SelectedValue.ToString();
        }

        private void tbCommentToExecutor_KeyDown(object sender, KeyEventArgs e)
        {
            if (!doEnterCommentToExecutor)
            {
                tbCommentToExecutor.ForeColor = Color.Black;
                tbCommentToExecutor.Font = new Font(tbInstruction.Font.FontFamily, (float)10);
                tbCommentToExecutor.Text = "";
                doEnterCommentToExecutor = true;
            }
        }

        private void tbInstruction_TextChanged(object sender, EventArgs e)
        {
            TextZun = tbInstruction.Text;
        }

        private void tbCommentToExecutor_TextChanged(object sender, EventArgs e)
        {
            CommentExecutor = tbCommentToExecutor.Text;
        }

        #endregion События

        #region Другие функции

        private void CloseFormOnOK()
        {
            ClickBnOk = true;
            TextZun = tbInstruction.Text;
            this.Hide();
        }

        #endregion Другие функции
    }
}

//Сделать: Добавлять согласующих