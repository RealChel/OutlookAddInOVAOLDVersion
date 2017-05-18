using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OutlookAddInOVA
{
	public partial class instructionInZUn : Form
	{
		private string errorCreateZunVal;
		private string PathToFileShotVal;
		private string preTextZunVal;

		public string preTextZun
		{
			get { return preTextZunVal; }
			set { preTextZunVal = value; }
		}

		public string PathToFile
		{
			get { return PathToFileShotVal; }
			set { PathToFileShotVal = value; }
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

			dynamic result=null;
			string createZunResult;
			V83.COMConnector com1s = new V83.COMConnector();
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




				com1s.PoolCapacity = 1;
				com1s.PoolTimeout = 1;
				com1s.MaxConnections = 1;
				string connectString = "Srvr="+ Srvr + ";Ref=" + Ref + ";Usr="+user+";Pwd=" + pas + ";";
				//string connectString = "File=" + file + ";Usr=" + user + ";Pwd=" + pas + ";";
				
				result = com1s.Connect(connectString);
				//createZunResult = result.ДляВнешнихСоединений.CreateZUN("glaal" + "@1ab.ru", PathToFileShotVal, textZun, errorCreateZun);
				createZunResult = result.ДляВнешнихСоединений.CreateZUN(SystemInformation.UserName + "@1ab.ru", PathToFileShotVal, preTextZun+ textZun, errorCreateZun);
					

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
			finally
			{

				
				
				Marshal.ReleaseComObject(result);
				result = null;

				Marshal.ReleaseComObject(com1s);
				com1s = null;
				GC.Collect();
				GC.WaitForPendingFinalizers();
				GC.Collect();
			}


		}


	}
}
