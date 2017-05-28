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
	public partial class FormSettings : Form
	{
		public FormSettings()
		{
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.prmSmartExecutorFormulirovka=tbFormulirovkaExecutorSmart.Text ;
			Properties.Settings.Default.prmSmartExecutorKriterii=tbKriteriiExecutorSmart.Text;
			Properties.Settings.Default.prmSmartFastFormulirovka=tbFormulirovkaFastSmart.Text ;
			Properties.Settings.Default.prmSmartFastKriterii=tbKriteriiFastSmart.Text;
			Properties.Settings.Default.Save();
		}

		private void buttonCаncel_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void FormSettings_Shown(object sender, EventArgs e)
		{
			tbFormulirovkaExecutorSmart.Text = Properties.Settings.Default.prmSmartExecutorFormulirovka;
			tbKriteriiExecutorSmart.Text= Properties.Settings.Default.prmSmartExecutorKriterii;
			tbFormulirovkaFastSmart.Text = Properties.Settings.Default.prmSmartFastFormulirovka;
			tbKriteriiFastSmart.Text = Properties.Settings.Default.prmSmartFastKriterii;
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			DialogResult mbbAnswer = MessageBox.Show("Закрыть окно настроек и создать письмо?\nНастройки не будут сохранены.", "Отправить письмо с пожеланиями?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			if (mbbAnswer==DialogResult.Yes)
			{
				this.Hide();
				System.Diagnostics.Process.Start("mailto:glaal@1ab.ru");
			}
			
		}
	}
}
