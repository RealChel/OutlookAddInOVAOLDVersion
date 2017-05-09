using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Office = Microsoft.Office.Core;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace OutlookAddInOVA
{
	partial class frMailOVA
	{
		#region Фабрика областей формы 

		[Microsoft.Office.Tools.Outlook.FormRegionMessageClass(Microsoft.Office.Tools.Outlook.FormRegionMessageClassAttribute.Note)]
		[Microsoft.Office.Tools.Outlook.FormRegionName("OutlookAddInOVA.FormRegion1")]
		public partial class FormRegion1Factory
		{
			// Возникает перед инициализацией области формы.
			// Чтобы исключить появление области формы, задайте для параметра e.Cancel значение true.
			// Используйте e.OutlookItem для получения ссылки на текущий элемент Outlook.
			private void FormRegion1Factory_FormRegionInitializing(object sender, Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs e)
			{
			}
		}

		#endregion

		// Возникает перед отображением области формы.
		// Используйте this.OutlookItem для получения ссылки на текущий элемент Outlook.
		// Используйте this.OutlookFormRegion для получения ссылки на область формы.
		private void FormRegion1_FormRegionShowing(object sender, System.EventArgs e)
		{
		}

		// Возникает перед закрытием области формы.
		// Используйте this.OutlookItem для получения ссылки на текущий элемент Outlook.
		// Используйте this.OutlookFormRegion для получения ссылки на область формы.
		private void FormRegion1_FormRegionClosed(object sender, System.EventArgs e)
		{
		}
	}
}
