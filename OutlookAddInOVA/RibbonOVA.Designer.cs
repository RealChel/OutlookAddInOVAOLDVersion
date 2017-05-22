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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonOVA));
			this.tabOVA = this.Factory.CreateRibbonTab();
			this.groupCreateZun = this.Factory.CreateRibbonGroup();
			this.btnCreateZUnInABF = this.Factory.CreateRibbonButton();
			this.buttonCreateZunWithMsg = this.Factory.CreateRibbonButton();
			this.groupParametrsABF = this.Factory.CreateRibbonGroup();
			this.button1 = this.Factory.CreateRibbonButton();
			this.checPriStarteOutlook = this.Factory.CreateRibbonCheckBox();
			this.checkPriCreateZUn = this.Factory.CreateRibbonCheckBox();
			this.groupParametrsMail = this.Factory.CreateRibbonGroup();
			this.cbQuestionNew = this.Factory.CreateRibbonCheckBox();
			this.cbQuestionAnswer = this.Factory.CreateRibbonCheckBox();
			this.cbQuestionForward = this.Factory.CreateRibbonCheckBox();
			this.groupSettingOVA = this.Factory.CreateRibbonGroup();
			this.cbCreateZunFromMe = this.Factory.CreateRibbonCheckBox();
			this.backgroundWorkerOVA = new System.ComponentModel.BackgroundWorker();
			this.notifyIconOVA = new System.Windows.Forms.NotifyIcon(this.components);
			this.tabOVA.SuspendLayout();
			this.groupCreateZun.SuspendLayout();
			this.groupParametrsABF.SuspendLayout();
			this.groupParametrsMail.SuspendLayout();
			this.groupSettingOVA.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabOVA
			// 
			this.tabOVA.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.tabOVA.Groups.Add(this.groupCreateZun);
			this.tabOVA.Groups.Add(this.groupParametrsABF);
			this.tabOVA.Groups.Add(this.groupParametrsMail);
			this.tabOVA.Groups.Add(this.groupSettingOVA);
			this.tabOVA.Label = "УК ОВА";
			this.tabOVA.Name = "tabOVA";
			// 
			// groupCreateZun
			// 
			this.groupCreateZun.Items.Add(this.btnCreateZUnInABF);
			this.groupCreateZun.Items.Add(this.buttonCreateZunWithMsg);
			this.groupCreateZun.Label = "ЗУн в ОВА";
			this.groupCreateZun.Name = "groupCreateZun";
			// 
			// btnCreateZUnInABF
			// 
			this.btnCreateZUnInABF.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
			this.btnCreateZUnInABF.Image = global::OutlookAddInOVA.Properties.Resources.screenshot;
			this.btnCreateZUnInABF.Label = "Зарегестрировать ошибку в АБФ";
			this.btnCreateZUnInABF.Name = "btnCreateZUnInABF";
			this.btnCreateZUnInABF.ShowImage = true;
			this.btnCreateZUnInABF.SuperTip = "Создать Заявку универсальную в  УК ОВА с добавлением скриншота из буфера обмена";
			this.btnCreateZUnInABF.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnCreateZUnInABF_Click);
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
			this.groupParametrsABF.Items.Add(this.button1);
			this.groupParametrsABF.Items.Add(this.checPriStarteOutlook);
			this.groupParametrsABF.Items.Add(this.checkPriCreateZUn);
			this.groupParametrsABF.Label = "Вариант подключения к АБФ";
			this.groupParametrsABF.Name = "groupParametrsABF";
			this.groupParametrsABF.Visible = false;
			// 
			// button1
			// 
			this.button1.Label = "button1";
			this.button1.Name = "button1";
			this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
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
			// groupSettingOVA
			// 
			this.groupSettingOVA.Items.Add(this.cbCreateZunFromMe);
			this.groupSettingOVA.Label = "Настройки ОВА";
			this.groupSettingOVA.Name = "groupSettingOVA";
			this.groupSettingOVA.Visible = false;
			// 
			// cbCreateZunFromMe
			// 
			this.cbCreateZunFromMe.Label = "Создать ЗУн от меня";
			this.cbCreateZunFromMe.Name = "cbCreateZunFromMe";
			this.cbCreateZunFromMe.SuperTip = "При включенном флаге ЗУн в АБФ  будут создаваться от моего имени";
			this.cbCreateZunFromMe.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbCreateZunFromMe_Click);
			// 
			// backgroundWorkerOVA
			// 
			this.backgroundWorkerOVA.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerOVA_DoWork_1);
			this.backgroundWorkerOVA.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerOVA_RunWorkerCompleted_1);
			// 
			// notifyIconOVA
			// 
			this.notifyIconOVA.Visible = true;
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
			this.groupCreateZun.ResumeLayout(false);
			this.groupCreateZun.PerformLayout();
			this.groupParametrsABF.ResumeLayout(false);
			this.groupParametrsABF.PerformLayout();
			this.groupParametrsMail.ResumeLayout(false);
			this.groupParametrsMail.PerformLayout();
			this.groupSettingOVA.ResumeLayout(false);
			this.groupSettingOVA.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tabOVA;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupCreateZun;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton btnCreateZUnInABF;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupParametrsMail;
		internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbQuestionNew;
		internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbQuestionAnswer;
		internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbQuestionForward;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupParametrsABF;
		internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checPriStarteOutlook;
		internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkPriCreateZUn;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonCreateZunWithMsg;
		private System.ComponentModel.BackgroundWorker backgroundWorkerOVA;
		private System.Windows.Forms.NotifyIcon notifyIconOVA;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupSettingOVA;
		internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbCreateZunFromMe;
	}

	partial class ThisRibbonCollection
	{
		internal RibbonOVA RibbonOVA
		{
			get { return this.GetRibbon<RibbonOVA>(); }
		}
	}
}
