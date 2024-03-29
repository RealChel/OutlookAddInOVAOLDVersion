﻿namespace OutlookAddInOVA
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonOVA));
			this.tabOVA = this.Factory.CreateRibbonTab();
			this.groupCreateErrorZUn = this.Factory.CreateRibbonGroup();
			this.btnCreateZUnInABF = this.Factory.CreateRibbonButton();
			this.groupCreateZunWithMsg = this.Factory.CreateRibbonGroup();
			this.buttonCreateZunWithMsg = this.Factory.CreateRibbonButton();
			this.groupParametrsABF = this.Factory.CreateRibbonGroup();
			this.checPriStarteOutlook = this.Factory.CreateRibbonCheckBox();
			this.checkPriCreateZUn = this.Factory.CreateRibbonCheckBox();
			this.groupParametrsMail = this.Factory.CreateRibbonGroup();
			this.cbQuestionNew = this.Factory.CreateRibbonCheckBox();
			this.cbQuestionAnswer = this.Factory.CreateRibbonCheckBox();
			this.cbQuestionForward = this.Factory.CreateRibbonCheckBox();
			this.backgroundWorkerOVA = new System.ComponentModel.BackgroundWorker();
			this.tabOVA.SuspendLayout();
			this.groupCreateErrorZUn.SuspendLayout();
			this.groupCreateZunWithMsg.SuspendLayout();
			this.groupParametrsABF.SuspendLayout();
			this.groupParametrsMail.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabOVA
			// 
			this.tabOVA.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.tabOVA.Groups.Add(this.groupCreateErrorZUn);
			this.tabOVA.Groups.Add(this.groupCreateZunWithMsg);
			this.tabOVA.Groups.Add(this.groupParametrsABF);
			this.tabOVA.Groups.Add(this.groupParametrsMail);
			this.tabOVA.Label = "УК ОВА";
			this.tabOVA.Name = "tabOVA";
			// 
			// groupCreateErrorZUn
			// 
			this.groupCreateErrorZUn.Items.Add(this.btnCreateZUnInABF);
			this.groupCreateErrorZUn.Name = "groupCreateErrorZUn";
			// 
			// btnCreateZUnInABF
			// 
			this.btnCreateZUnInABF.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.btnCreateZUnInABF.Image = global::OutlookAddInOVA.Properties.Resources.mini;
			this.btnCreateZUnInABF.Label = "Зарегестрировать ошибку в АБФ";
			this.btnCreateZUnInABF.Name = "btnCreateZUnInABF";
			this.btnCreateZUnInABF.ShowImage = true;
			this.btnCreateZUnInABF.SuperTip = "Создать Заявку универсальную в  УК ОВА с добавлением скриншота из буфер";
			this.btnCreateZUnInABF.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnCreateZUnInABF_Click);
			// 
			// groupCreateZunWithMsg
			// 
			this.groupCreateZunWithMsg.Items.Add(this.buttonCreateZunWithMsg);
			this.groupCreateZunWithMsg.Name = "groupCreateZunWithMsg";
			// 
			// buttonCreateZunWithMsg
			// 
			this.buttonCreateZunWithMsg.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.buttonCreateZunWithMsg.Image = global::OutlookAddInOVA.Properties.Resources.forward;
			this.buttonCreateZunWithMsg.Label = "Создать ЗУн из письма";
			this.buttonCreateZunWithMsg.Name = "buttonCreateZunWithMsg";
			this.buttonCreateZunWithMsg.ShowImage = true;
			this.buttonCreateZunWithMsg.SuperTip = "Создать ЗУн в АБФ приложив текущее письмо";
			this.buttonCreateZunWithMsg.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonCreateZunWithMsg_Click);
			// 
			// groupParametrsABF
			// 
			this.groupParametrsABF.Items.Add(this.checPriStarteOutlook);
			this.groupParametrsABF.Items.Add(this.checkPriCreateZUn);
			this.groupParametrsABF.Label = "Вариант подключения к АБФ";
			this.groupParametrsABF.Name = "groupParametrsABF";
			this.groupParametrsABF.Visible = false;
			// 
			// checPriStarteOutlook
			// 
			this.checPriStarteOutlook.Label = "При запуске Outlook";
			this.checPriStarteOutlook.Name = "checPriStarteOutlook";
			this.checPriStarteOutlook.SuperTip = resources.GetString("checPriStarteOutlook.SuperTip");
			// 
			// checkPriCreateZUn
			// 
			this.checkPriCreateZUn.Label = "При создании ЗУн";
			this.checkPriCreateZUn.Name = "checkPriCreateZUn";
			this.checkPriCreateZUn.SuperTip = resources.GetString("checkPriCreateZUn.SuperTip");
			// 
			// groupParametrsMail
			// 
			this.groupParametrsMail.Items.Add(this.cbQuestionNew);
			this.groupParametrsMail.Items.Add(this.cbQuestionAnswer);
			this.groupParametrsMail.Items.Add(this.cbQuestionForward);
			this.groupParametrsMail.Label = "Запрос на создание ЗУн в ОВА";
			this.groupParametrsMail.Name = "groupParametrsMail";
			this.groupParametrsMail.Visible = false;
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
			// RibbonOVA
			// 
			this.Name = "RibbonOVA";
			this.RibbonType = "Microsoft.Outlook.Explorer, Microsoft.Outlook.Mail.Compose, Microsoft.Outlook.Mai" +
    "l.Read, Microsoft.Outlook.MeetingRequest.Read";
			this.Tabs.Add(this.tabOVA);
			this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibbonOVA_Load);
			this.tabOVA.ResumeLayout(false);
			this.tabOVA.PerformLayout();
			this.groupCreateErrorZUn.ResumeLayout(false);
			this.groupCreateErrorZUn.PerformLayout();
			this.groupCreateZunWithMsg.ResumeLayout(false);
			this.groupCreateZunWithMsg.PerformLayout();
			this.groupParametrsABF.ResumeLayout(false);
			this.groupParametrsABF.PerformLayout();
			this.groupParametrsMail.ResumeLayout(false);
			this.groupParametrsMail.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tabOVA;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupCreateErrorZUn;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton btnCreateZUnInABF;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupParametrsMail;
		internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbQuestionNew;
		internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbQuestionAnswer;
		internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbQuestionForward;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupParametrsABF;
		internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checPriStarteOutlook;
		internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkPriCreateZUn;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupCreateZunWithMsg;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonCreateZunWithMsg;
		private System.ComponentModel.BackgroundWorker backgroundWorkerOVA;
	}

	partial class ThisRibbonCollection
	{
		internal RibbonOVA RibbonOVA
		{
			get { return this.GetRibbon<RibbonOVA>(); }
		}
	}
}
