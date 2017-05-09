namespace OutlookAddInOVA
{
	partial class RibbonOVA : Microsoft.Office.Tools.Ribbon.RibbonBase
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public RibbonOVA()
			: base(Globals.Factory.GetRibbonFactory())
		{
			InitializeComponent();
		}

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabOVA = this.Factory.CreateRibbonTab();
			this.groupOVA = this.Factory.CreateRibbonGroup();
			this.groupPrametrs = this.Factory.CreateRibbonGroup();
			this.cbQuestionNew = this.Factory.CreateRibbonCheckBox();
			this.cbQuestionAnswer = this.Factory.CreateRibbonCheckBox();
			this.cbQuestionForward = this.Factory.CreateRibbonCheckBox();
			this.btnCreateZUnInABF = this.Factory.CreateRibbonButton();
			this.tabOVA.SuspendLayout();
			this.groupOVA.SuspendLayout();
			this.groupPrametrs.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabOVA
			// 
			this.tabOVA.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.tabOVA.Groups.Add(this.groupOVA);
			this.tabOVA.Groups.Add(this.groupPrametrs);
			this.tabOVA.Label = "УК ОВА";
			this.tabOVA.Name = "tabOVA";
			// 
			// groupOVA
			// 
			this.groupOVA.Items.Add(this.btnCreateZUnInABF);
			this.groupOVA.Name = "groupOVA";
			// 
			// groupPrametrs
			// 
			this.groupPrametrs.Items.Add(this.cbQuestionNew);
			this.groupPrametrs.Items.Add(this.cbQuestionAnswer);
			this.groupPrametrs.Items.Add(this.cbQuestionForward);
			this.groupPrametrs.Label = "Запрос на создание ЗУн в ОВА";
			this.groupPrametrs.Name = "groupPrametrs";
			// 
			// cbQuestionNew
			// 
			this.cbQuestionNew.Label = "При новом письме";
			this.cbQuestionNew.Name = "cbQuestionNew";
			this.cbQuestionNew.ScreenTip = "При создании нового письма в УК ОВА";
			this.cbQuestionNew.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbQuestionNew_Click);
			// 
			// cbQuestionAnswer
			// 
			this.cbQuestionAnswer.Label = "При ответе";
			this.cbQuestionAnswer.Name = "cbQuestionAnswer";
			this.cbQuestionAnswer.ScreenTip = "При ответе на письмо с указанием сотрудника УК ОВА";
			this.cbQuestionAnswer.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbQuestionAnswer_Click);
			// 
			// cbQuestionForward
			// 
			this.cbQuestionForward.Label = "При пересылке";
			this.cbQuestionForward.Name = "cbQuestionForward";
			this.cbQuestionForward.ScreenTip = "При пересылке письма с указанием сотрудника УК ОВА";
			this.cbQuestionForward.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbQuestionForward_Click);
			// 
			// btnCreateZUnInABF
			// 
			this.btnCreateZUnInABF.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.btnCreateZUnInABF.Description = "asdfasdfasdfdsafsdfsadf";
			this.btnCreateZUnInABF.Image = global::OutlookAddInOVA.Properties.Resources.mini;
			this.btnCreateZUnInABF.Label = "Зарегестрировать ошибку в АБФ";
			this.btnCreateZUnInABF.Name = "btnCreateZUnInABF";
			this.btnCreateZUnInABF.ScreenTip = "Создать Заявку универсальную в  УК ОВА с добавлением скриншота из буфер";
			this.btnCreateZUnInABF.ShowImage = true;
			this.btnCreateZUnInABF.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnCreateZUnInABF_Click);
			// 
			// RibbonOVA
			// 
			this.Name = "RibbonOVA";
			this.RibbonType = "Microsoft.Outlook.Explorer";
			this.Tabs.Add(this.tabOVA);
			this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibbonOVA_Load);
			this.tabOVA.ResumeLayout(false);
			this.tabOVA.PerformLayout();
			this.groupOVA.ResumeLayout(false);
			this.groupOVA.PerformLayout();
			this.groupPrametrs.ResumeLayout(false);
			this.groupPrametrs.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tabOVA;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupOVA;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton btnCreateZUnInABF;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupPrametrs;
		internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbQuestionNew;
		internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbQuestionAnswer;
		internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbQuestionForward;
	}

	partial class ThisRibbonCollection
	{
		internal RibbonOVA RibbonOVA
		{
			get { return this.GetRibbon<RibbonOVA>(); }
		}
	}
}
