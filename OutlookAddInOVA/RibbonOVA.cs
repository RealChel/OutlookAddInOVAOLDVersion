using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;


namespace OutlookAddInOVA
{
	public partial class RibbonOVA
	{
		private void RibbonOVA_Load(object sender, RibbonUIEventArgs e)
		{
			cbQuestionAnswer.Checked = Properties.Settings.Default.PrnQuestionAnswer;
			cbQuestionForward.Checked = Properties.Settings.Default.prnQuestionForward;
			cbQuestionNew.Checked = Properties.Settings.Default.PrnQuestionNew;
		}

		private void cbQuestionNew_Click(object sender, RibbonControlEventArgs e)
		{
			Properties.Settings.Default.PrnQuestionNew = cbQuestionNew.Checked;
			Properties.Settings.Default.Save();
		}

		private void cbQuestionAnswer_Click(object sender, RibbonControlEventArgs e)
		{
			Properties.Settings.Default.PrnQuestionNew = cbQuestionAnswer.Checked;
			Properties.Settings.Default.Save();
		}

		private void cbQuestionForward_Click(object sender, RibbonControlEventArgs e)
		{
			Properties.Settings.Default.prnQuestionForward = cbQuestionForward.Checked;
			Properties.Settings.Default.Save();
		}

		
		private void btnCreateZUnInABF_Click(object sender, RibbonControlEventArgs e)
		{
			Outlook.MailItem mailItem = (Outlook.MailItem)
			OutlookAddInOVA.Globals.ThisAddIn.Application.CreateItem(Outlook.OlItemType.olMailItem);
			mailItem.Subject = "Тестовое письмо";
			mailItem.To = "test@csharpcoderr.com";
			mailItem.Body = "Текст сообщения";
			mailItem.Importance = Outlook.OlImportance.olImportanceLow;
			mailItem.Display(false);
		}
	}
}
