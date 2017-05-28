using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OutlookAddInOVA
{
	public partial class instructionInZUn : Form
	{
		private bool clickBnOkVal;
		private string textZunVal;
		

		public string textZun
		{
			get { return textZunVal; }
			set { textZunVal = value; }
		}

		public bool clickBnOk
		{
			get { return clickBnOkVal; }
			set { clickBnOkVal = value; }
		}
				
		public instructionInZUn()
		{
			InitializeComponent();
		
			
			
		}

		private bool doEntertext = false;

		private void btnOK_Click(object sender, EventArgs e)
		{
			CloseFormOnOK();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			clickBnOk = false;
			textZun = "";
			this.Hide();
		}
		private void CloseFormOnOK()
		{
			clickBnOk = true;
			textZun = tbInstruction.Text;
			this.Hide();
		}

		private void tbInstruction_KeyDown(object sender, KeyEventArgs e)
		{
			if (!doEntertext)
			{
				tbInstruction.ForeColor = Color.Black;
				tbInstruction.Font = new Font(tbInstruction.Font.FontFamily,(float)10);
				tbInstruction.Text = "";
				doEntertext = true;
			}
			if (e.KeyCode == Keys.Return && e.Modifiers == Keys.Control)
			{
				CloseFormOnOK();
			}
		}

		private void instructionInZUn_Shown(object sender, EventArgs e)
		{
			tbInstruction.Text = textZun;
			tbInstruction.ForeColor = Color.Silver;
			tbInstruction.SelectionStart = 0;
		}
	}
}
