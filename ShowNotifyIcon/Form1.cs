using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowNotifyIcon
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
			notifyIcon1.BalloonTipText = "В УК ОВА было отпралено письмо с ошибкой.";
			notifyIcon1.BalloonTipTitle = "При создании ЗУн возникла ошибка";
			notifyIcon1.ShowBalloonTip(10000);
		}
	}
}
