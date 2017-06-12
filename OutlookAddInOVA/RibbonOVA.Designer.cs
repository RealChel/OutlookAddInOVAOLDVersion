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
            this.tabOVA = this.Factory.CreateRibbonTab();
            this.groupCreateZun = this.Factory.CreateRibbonGroup();
            this.btnCreateZUnInABF = this.Factory.CreateRibbonButton();
            this.buttonCreateZunWithMsg = this.Factory.CreateRibbonButton();
            this.groupSmart = this.Factory.CreateRibbonGroup();
            this.buttonCreateSmartToMe = this.Factory.CreateRibbonButton();
            this.buttonCreateSmartToExcevutor = this.Factory.CreateRibbonButton();
            this.groupSettingOVA = this.Factory.CreateRibbonGroup();
            this.cbCreateZunFromMe = this.Factory.CreateRibbonCheckBox();
            this.groupParametrsMail = this.Factory.CreateRibbonGroup();
            this.cbQuestionNew = this.Factory.CreateRibbonCheckBox();
            this.cbQuestionAnswer = this.Factory.CreateRibbonCheckBox();
            this.cbQuestionForward = this.Factory.CreateRibbonCheckBox();
            this.backgroundWorkerOVAZUn = new System.ComponentModel.BackgroundWorker();
            this.notifyIconOVA = new System.Windows.Forms.NotifyIcon(this.components);
            this.backgroundWorkerOVASMART = new System.ComponentModel.BackgroundWorker();
            this.buttonSetting = this.Factory.CreateRibbonButton();
            this.btnAboutProg = this.Factory.CreateRibbonButton();
            this.tabOVA.SuspendLayout();
            this.groupCreateZun.SuspendLayout();
            this.groupSmart.SuspendLayout();
            this.groupSettingOVA.SuspendLayout();
            this.groupParametrsMail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOVA
            // 
            this.tabOVA.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabOVA.Groups.Add(this.groupCreateZun);
            this.tabOVA.Groups.Add(this.groupSmart);
            this.tabOVA.Groups.Add(this.groupSettingOVA);
            this.tabOVA.Groups.Add(this.groupParametrsMail);
            this.tabOVA.Label = "АБФ";
            this.tabOVA.Name = "tabOVA";
            // 
            // groupCreateZun
            // 
            this.groupCreateZun.Items.Add(this.btnCreateZUnInABF);
            this.groupCreateZun.Items.Add(this.buttonCreateZunWithMsg);
            this.groupCreateZun.Label = "Создать ЗУн в УК ОВА";
            this.groupCreateZun.Name = "groupCreateZun";
            // 
            // btnCreateZUnInABF
            // 
            this.btnCreateZUnInABF.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnCreateZUnInABF.Image = global::OutlookAddInOVA.Properties.Resources.screenshot;
            this.btnCreateZUnInABF.Label = "Зарегистрировать ошибку в АБФ";
            this.btnCreateZUnInABF.Name = "btnCreateZUnInABF";
            this.btnCreateZUnInABF.ShowImage = true;
            this.btnCreateZUnInABF.SuperTip = "Создать Заявку универсальную в  УК ОВА с добавлением скриншота из буфера обмена";
            this.btnCreateZUnInABF.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnCreateZUnWithScreenShoot_Click);
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
            // groupSmart
            // 
            this.groupSmart.Items.Add(this.buttonCreateSmartToMe);
            this.groupSmart.Items.Add(this.buttonCreateSmartToExcevutor);
            this.groupSmart.Label = "Создание SMART";
            this.groupSmart.Name = "groupSmart";
            // 
            // buttonCreateSmartToMe
            // 
            this.buttonCreateSmartToMe.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonCreateSmartToMe.Image = global::OutlookAddInOVA.Properties.Resources.target_32;
            this.buttonCreateSmartToMe.Label = "Создать SMART себе";
            this.buttonCreateSmartToMe.Name = "buttonCreateSmartToMe";
            this.buttonCreateSmartToMe.ShowImage = true;
            this.buttonCreateSmartToMe.SuperTip = "Быстро создать СМАРТ задачу себе с приложением текущего письма.";
            this.buttonCreateSmartToMe.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonCreateSmartToMe_Click);
            // 
            // buttonCreateSmartToExcevutor
            // 
            this.buttonCreateSmartToExcevutor.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonCreateSmartToExcevutor.Image = global::OutlookAddInOVA.Properties.Resources.celi;
            this.buttonCreateSmartToExcevutor.Label = "Создать SMART сотруднику";
            this.buttonCreateSmartToExcevutor.Name = "buttonCreateSmartToExcevutor";
            this.buttonCreateSmartToExcevutor.ShowImage = true;
            this.buttonCreateSmartToExcevutor.SuperTip = "Позволяет создавать СМАРТ  задачу себе либо своим подчиненным, с вводом дополните" +
    "льных параметров.";
            this.buttonCreateSmartToExcevutor.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonCreateSmartToExcevutor_Click);
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
            // backgroundWorkerOVAZUn
            // 
            this.backgroundWorkerOVAZUn.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerOVAZUn_DoWork);
            this.backgroundWorkerOVAZUn.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerOVAZUn_RunWorkerCompleted);
            // 
            // notifyIconOVA
            // 
            this.notifyIconOVA.Visible = true;
            // 
            // backgroundWorkerOVASMART
            // 
            this.backgroundWorkerOVASMART.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerOVASMART_DoWork);
            this.backgroundWorkerOVASMART.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerOVASMART_RunWorkerCompleted);
            // 
            // buttonSetting
            // 
            this.buttonSetting.Image = global::OutlookAddInOVA.Properties.Resources.icon_settings_setting_set;
            this.buttonSetting.Label = "Настройки OutlookAddInOVA";
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.ShowImage = true;
            this.buttonSetting.SuperTip = "Задать значения по умолчанию для создания Смарт задачи";
            this.buttonSetting.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonSettingSMART_Click);
            // 
            // btnAboutProg
            // 
            this.btnAboutProg.Image = global::OutlookAddInOVA.Properties.Resources.logo_v99;
            this.btnAboutProg.Label = "О надстройке";
            this.btnAboutProg.Name = "btnAboutProg";
            this.btnAboutProg.ShowImage = true;
            this.btnAboutProg.SuperTip = "Информация о надстройке OutlookAddinOVA";
            this.btnAboutProg.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAboutProg_Click);
            // 
            // RibbonOVA
            // 
            this.Name = "RibbonOVA";
            // 
            // RibbonOVA.OfficeMenu
            // 
            this.OfficeMenu.Items.Add(this.buttonSetting);
            this.OfficeMenu.Items.Add(this.btnAboutProg);
            this.RibbonType = "Microsoft.Outlook.Explorer, Microsoft.Outlook.Mail.Compose, Microsoft.Outlook.Mai" +
    "l.Read, Microsoft.Outlook.MeetingRequest.Read";
            this.Tabs.Add(this.tabOVA);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibbonOVA_Load);
            this.tabOVA.ResumeLayout(false);
            this.tabOVA.PerformLayout();
            this.groupCreateZun.ResumeLayout(false);
            this.groupCreateZun.PerformLayout();
            this.groupSmart.ResumeLayout(false);
            this.groupSmart.PerformLayout();
            this.groupSettingOVA.ResumeLayout(false);
            this.groupSettingOVA.PerformLayout();
            this.groupParametrsMail.ResumeLayout(false);
            this.groupParametrsMail.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupCreateZun;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton btnCreateZUnInABF;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupParametrsMail;
		internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbQuestionNew;
		internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbQuestionAnswer;
		internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbQuestionForward;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonCreateZunWithMsg;
		private System.ComponentModel.BackgroundWorker backgroundWorkerOVAZUn;
		private System.Windows.Forms.NotifyIcon notifyIconOVA;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupSettingOVA;
		internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbCreateZunFromMe;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupSmart;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonCreateSmartToMe;
		public Microsoft.Office.Tools.Ribbon.RibbonTab tabOVA;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonCreateSmartToExcevutor;
		private System.ComponentModel.BackgroundWorker backgroundWorkerOVASMART;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonSetting;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAboutProg;
	}

	partial class ThisRibbonCollection
	{
		internal RibbonOVA RibbonOVA
		{
			get { return this.GetRibbon<RibbonOVA>(); }
		}
	}
}
