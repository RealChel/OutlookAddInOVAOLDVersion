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
			//tbInstruction.ForeColor = Color.Silver;
			
			
		}
		//private void tbInstruction_KeyDown(object sender, KeyEventArgs e)
		//{
		//	tbInstruction.ForeColor = Color.Black;
			
		//	tbInstruction.Text = "";
		//}

		private void btnOK_Click(object sender, EventArgs e)
		{
			clickBnOk = true;
			textZun = tbInstruction.Text;
			this.Hide();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			clickBnOk = false;
			textZun = "";
			this.Hide();
		}

	}
}
