using System;
using System.Windows.Forms;

namespace OutlookAddInOVA
{
	public partial class FormSMART : Form
	{
		#region Parametrs
		private bool clickBnOkVal;
		private string textFormulirovkaVal;
		private string textKriteriiVal;
		private DateTime DoDateVal;
		private int vesSmartVal;
		private string executorVal;

		public string executor { get { return executorVal; } set { executorVal = value; } }

		public int VesSmart { get { return vesSmartVal; } set { vesSmartVal = value; } }

		public DateTime DoDate { get { return DoDateVal; } set { DoDateVal = value; } }

		public string textKriterii { get { return textKriteriiVal; } set { textKriteriiVal = value; } }

		public string textFormulirovka { get { return textFormulirovkaVal; } set { textFormulirovkaVal = value; } }

		public bool clickBnOk { get { return clickBnOkVal; } set { clickBnOkVal = value; } }
		#endregion

		#region Запуск формы
		public FormSMART()
		{
			InitializeComponent();
		}

		private void FormSMART_Shown(object sender, EventArgs e)
		{
			dTPDoDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
			comboBoxExecutor.DataSource = OutlookAddInOVA.Globals.ThisAddIn.listMyCoWorker;
			clickBnOk = false;
			tbFormulirovka.Text = textFormulirovka;
			tbKriterii.Text = textKriterii;
			dTPDoDate.MinDate = DateTime.Now;
		}

		#endregion
		#region Кнопки
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
		#endregion

		private void CloseFormOnOK()
		{
			clickBnOk = true;
			textFormulirovka = tbFormulirovka.Text;
			textKriterii = tbKriterii.Text;
			VesSmart = (int)nUDVes.Value;
			executor = comboBoxExecutor.SelectedValue.ToString();
			DoDate = dTPDoDate.Value;
			this.Hide();
		}

       
    }
}