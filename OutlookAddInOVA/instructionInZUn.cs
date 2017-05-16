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
		private string errorCreateZunVal;
		private string PathToScreenShotVal;

		public string PathToScreenShot
		{
			get { return PathToScreenShotVal; }
			set { PathToScreenShotVal = value; }
		}
		public string errorCreateZun
		{
			get { return errorCreateZunVal; }
			set { errorCreateZunVal = value; }
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

			this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			bool result = createZUn();
			if (result)
			{
				this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Hide();
			}
			else
			{
				this.Cursor = System.Windows.Forms.Cursors.Default;

			}

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			
			this.Hide();
		}

		private bool createZUn()
		{
			try
			{
					string textZun = tbInstruction.Text;
					if (textZun.Contains("При необходимости укажите подробности ошибки."))
					{
						textZun = "";
					}


				string user = @"""Create_ZUn""";
				string pas = @"""bF6k6mjbCEfEJayL""";
				//string user = @"""glaal""";
				//string pas = @"""Josefina1975""";
				//string file = @"""G:\\ABF""";
				//string file = "Srvr=""1ab-1cv81"";Ref=""pav-oper82""";
				string Srvr = @"""1ab-1cv80""";
				string Ref = @"""pav-oper82""";
				dynamic result;

					V83.COMConnector com1s = new V83.COMConnector();

					//com1s.PoolCapacity = 10;
					//com1s.PoolTimeout = 60;
					//com1s.MaxConnections = 2;
					string connectString = "Srvr="+ Srvr + ";Ref=" + Ref + ";Usr="+user+";Pwd=" + pas + ";";
					//string connectString = "File=" + file + ";Usr=" + user + ";Pwd=" + pas + ";";
				
					result = com1s.Connect(connectString);
					//string createZunResult = result.ДляВнешнихСоединений.CreateZUN("glaal" + "@1ab.ru", PathToScreenShotVal, textZun, errorCreateZun);
					string createZunResult = result.ДляВнешнихСоединений.CreateZUN(SystemInformation.UserName + "@1ab.ru", PathToScreenShotVal, textZun, errorCreateZun);
				

					if (createZunResult == "")
					{
						MessageBox.Show("При создании ЗУн возникла ошибка.\nПожалуйста сообщите текст ошибки в отдел УК ОВА.\n" + errorCreateZun, "Не удалось создать ЗУн в УК ОВА", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
					else
					{
						MessageBox.Show("Создана заявка универсальная в УК ОВА.\n" + createZunResult, "Заявка создана успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return true;
					}

		


			}
			catch(Exception err)
			{
				MessageBox.Show(err.ToString());
				return false;
			}


		}


	}
}
