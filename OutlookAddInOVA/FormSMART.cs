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
	public partial class FormSMART : Form
	{
		private bool clickBnOkVal;
		private string textFormulirovkaVal;
		private string textKriteriiVal;
		private DateTime DoDateVal;
		private int vesSmartVal;
		private string executorVal;

		public string executor
		{
			get { return executorVal; }
			set { executorVal = value; }
		}

		public int VesSmart
		{
			get { return vesSmartVal; }
			set { vesSmartVal = value; }
		}

		public DateTime DoDate
		{
			get { return DoDateVal; }
			set { DoDateVal = value; }
		}

		public string textKriterii
		{
			get { return textKriteriiVal; }
			set { textKriteriiVal = value; }
		}
		public string textFormulirovka
		{
			get { return textFormulirovkaVal; }
			set { textFormulirovkaVal = value; }
		}

		public bool clickBnOk
		{
			get { return clickBnOkVal; }
			set { clickBnOkVal = value; }
		}

		public FormSMART()
		{
			InitializeComponent();
			dTPDoDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
			comboBoxExecutor.DataSource = OutlookAddInOVA.Globals.ThisAddIn.listMyCoWorker;
			tbFormulirovka.Text= "Задача созданна автоматически из MS Outlook." + Environment.NewLine + "Подробности в приложенном письме.";
			tbKriterii.Text = "Задача выполнена, сдана руководителю на проверку.";

		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			CloseFormOnOK();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			clickBnOk = false;
			textFormulirovka = "";
			textKriterii = "";
			VesSmart = 0;
			executor = "";
			DoDate = DateTime.Now;
			this.Hide();
		}

		private void CloseFormOnOK()
		{
			clickBnOk = true;
			textFormulirovka = tbFormulirovka.Text;
			textKriterii = tbKriterii.Text;
			VesSmart = (int)nUDVes.Value;
			executor = comboBoxExecutor.SelectedValue.ToString() ;
			DoDate = dTPDoDate.Value;
			this.Hide();
		}
	}
}
