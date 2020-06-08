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
            this.components = new System.ComponentModel.Container();
            this.tabOVA = this.Factory.CreateRibbonTab();
            this.groupCreateZUnOVA = this.Factory.CreateRibbonGroup();
            this.btnCreateZUnInABF = this.Factory.CreateRibbonButton();
            this.buttonCreateZunWithMsg = this.Factory.CreateRibbonButton();
            this.groupCreateZUnTO = this.Factory.CreateRibbonGroup();
            this.btnCreateZUnInTO = this.Factory.CreateRibbonButton();
            this.buttonCreateZunInToWithMsg = this.Factory.CreateRibbonButton();
            this.groupCreateOtherZUN = this.Factory.CreateRibbonGroup();
            this.buttonCreateOtherZUn = this.Factory.CreateRibbonButton();
            this.groupSmart = this.Factory.CreateRibbonGroup();
            this.buttonCreateSmartToMe = this.Factory.CreateRibbonButton();
            this.buttonCreateSmartToExcevutor = this.Factory.CreateRibbonButton();
            this.groupSettingOVA = this.Factory.CreateRibbonGroup();
            this.cbCreateZunFromMe = this.Factory.CreateRibbonCheckBox();
            this.groupTestMode = this.Factory.CreateRibbonGroup();
            this.labelToDeveloper = this.Factory.CreateRibbonLabel();
            this.buttonToDeveloper = this.Factory.CreateRibbonButton();
            this.backgroundWorkerOVAZUn = new System.ComponentModel.BackgroundWorker();
            this.notifyIconOVA = new System.Windows.Forms.NotifyIcon(this.components);
            this.backgroundWorkerOVASMART = new System.ComponentModel.BackgroundWorker();
            this.buttonSetting = this.Factory.CreateRibbonButton();
            this.btnAboutProg = this.Factory.CreateRibbonButton();
            this.tabOVA.SuspendLayout();
            this.groupCreateZUnOVA.SuspendLayout();
            this.groupCreateZUnTO.SuspendLayout();
            this.groupCreateOtherZUN.SuspendLayout();
            this.groupSmart.SuspendLayout();
            this.groupSettingOVA.SuspendLayout();
            this.groupTestMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOVA
            // 
            this.tabOVA.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabOVA.Groups.Add(this.groupCreateZUnOVA);
            this.tabOVA.Groups.Add(this.groupCreateZUnTO);
            this.tabOVA.Groups.Add(this.groupCreateOtherZUN);
            this.tabOVA.Groups.Add(this.groupSmart);
            this.tabOVA.Groups.Add(this.groupSettingOVA);
            this.tabOVA.Groups.Add(this.groupTestMode);
            this.tabOVA.Label = "АБФ";
            this.tabOVA.Name = "tabOVA";
            // 
            // groupCreateZUnOVA
            // 
            this.groupCreateZUnOVA.Items.Add(this.btnCreateZUnInABF);
            this.groupCreateZUnOVA.Items.Add(this.buttonCreateZunWithMsg);
            this.groupCreateZUnOVA.Label = "Создать ЗУн в УК ОВА";
            this.groupCreateZUnOVA.Name = "groupCreateZUnOVA";
            this.groupCreateZUnOVA.Visible = false;
            // 
            // btnCreateZUnInABF
            // 
            this.btnCreateZUnInABF.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnCreateZUnInABF.Image = global::OutlookAddInOVA.Properties.Resources.screenshot;
            this.btnCreateZUnInABF.Label = "Зарегистрировать ошибку в АБФ";
            this.btnCreateZUnInABF.Name = "btnCreateZUnInABF";
            this.btnCreateZUnInABF.ShowImage = true;
            this.btnCreateZUnInABF.SuperTip = "Создать Заявку универсальную в  УК ОВА с добавлением скриншота из буфера обмена";
            this.btnCreateZUnInABF.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnCreateZUnWithScreenShootToOVA_Click);
            // 
            // buttonCreateZunWithMsg
            // 
            this.buttonCreateZunWithMsg.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonCreateZunWithMsg.Image = global::OutlookAddInOVA.Properties.Resources.forward;
            this.buttonCreateZunWithMsg.Label = "Создать ЗУн из письма";
            this.buttonCreateZunWithMsg.Name = "buttonCreateZunWithMsg";
            this.buttonCreateZunWithMsg.ShowImage = true;
            this.buttonCreateZunWithMsg.SuperTip = "Создать ЗУн в УК ОВА приложив текущее письмо в виде msg";
            this.buttonCreateZunWithMsg.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnCreateZunWithMsgToOVA_Click);
            // 
            // groupCreateZUnTO
            // 
            this.groupCreateZUnTO.Items.Add(this.btnCreateZUnInTO);
            this.groupCreateZUnTO.Items.Add(this.buttonCreateZunInToWithMsg);
            this.groupCreateZUnTO.Label = "Создать ЗУн в УК ТО";
            this.groupCreateZUnTO.Name = "groupCreateZUnTO";
            this.groupCreateZUnTO.Visible = false;
            // 
            // btnCreateZUnInTO
            // 
            this.btnCreateZUnInTO.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnCreateZUnInTO.Image = global::OutlookAddInOVA.Properties.Resources.screenshot;
            this.btnCreateZUnInTO.Label = "Зарегистрировать ошибку в АБФ";
            this.btnCreateZUnInTO.Name = "btnCreateZUnInTO";
            this.btnCreateZUnInTO.ShowImage = true;
            this.btnCreateZUnInTO.SuperTip = "Создать Заявку универсальную в  УК ТО с добавлением скриншота из буфера обмена";
            this.btnCreateZUnInTO.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnCreateZUnWithScreenShootInTO_Click);
            // 
            // buttonCreateZunInToWithMsg
            // 
            this.buttonCreateZunInToWithMsg.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonCreateZunInToWithMsg.Image = global::OutlookAddInOVA.Properties.Resources.forward;
            this.buttonCreateZunInToWithMsg.Label = "Создать ЗУн из письма";
            this.buttonCreateZunInToWithMsg.Name = "buttonCreateZunInToWithMsg";
            this.buttonCreateZunInToWithMsg.ShowImage = true;
            this.buttonCreateZunInToWithMsg.SuperTip = "Создать ЗУн в УК ТО  приложив текущее письмо в виде файла msg";
            this.buttonCreateZunInToWithMsg.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonCreateZunInToWithMsg_Click);
            // 
            // groupCreateOtherZUN
            // 
            this.groupCreateOtherZUN.Items.Add(this.buttonCreateOtherZUn);
            this.groupCreateOtherZUN.Label = "Создать ЗУн в другие отделы";
            this.groupCreateOtherZUN.Name = "groupCreateOtherZUN";
            this.groupCreateOtherZUN.Visible = false;
            // 
            // buttonCreateOtherZUn
            // 
            this.buttonCreateOtherZUn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonCreateOtherZUn.Image = global::OutlookAddInOVA.Properties.Resources.forward;
            this.buttonCreateOtherZUn.Label = "Создать ЗУн из письма";
            this.buttonCreateOtherZUn.Name = "buttonCreateOtherZUn";
            this.buttonCreateOtherZUn.ShowImage = true;
            this.buttonCreateOtherZUn.SuperTip = "Создать ЗУн в АБФ приложив текущее письмо";
            this.buttonCreateOtherZUn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnCreateOtherZUn_Click);
            // 
            // groupSmart
            // 
            this.groupSmart.Items.Add(this.buttonCreateSmartToMe);
            this.groupSmart.Items.Add(this.buttonCreateSmartToExcevutor);
            this.groupSmart.Label = "Создание SMART";
            this.groupSmart.Name = "groupSmart";
            this.groupSmart.Visible = false;
            // 
            // buttonCreateSmartToMe
            // 
            this.buttonCreateSmartToMe.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonCreateSmartToMe.Image = global::OutlookAddInOVA.Properties.Resources.target_32;
            this.buttonCreateSmartToMe.Label = "Создать SMART себе";
            this.buttonCreateSmartToMe.Name = "buttonCreateSmartToMe";
            this.buttonCreateSmartToMe.ShowImage = true;
            this.buttonCreateSmartToMe.SuperTip = "Быстро создать СМАРТ задачу себе с приложением текущего письма.";
            this.buttonCreateSmartToMe.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnCreateSmartToMe_Click);
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
            this.buttonCreateSmartToExcevutor.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnCreateSmartToExcevutor_Click);
            // 
            // groupSettingOVA
            // 
            this.groupSettingOVA.Items.Add(this.cbCreateZunFromMe);
            this.groupSettingOVA.Label = "Настройки ОВА/ТО";
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
            // groupTestMode
            // 
            this.groupTestMode.Items.Add(this.labelToDeveloper);
            this.groupTestMode.Items.Add(this.buttonToDeveloper);
            this.groupTestMode.Name = "groupTestMode";
            this.groupTestMode.Visible = false;
            // 
            // labelToDeveloper
            // 
            this.labelToDeveloper.Label = "Тестовый режим. За подробностями обратитесь к разработчику";
            this.labelToDeveloper.Name = "labelToDeveloper";
            // 
            // buttonToDeveloper
            // 
            this.buttonToDeveloper.Image = global::OutlookAddInOVA.Properties.Resources.forward;
            this.buttonToDeveloper.Label = "Написать разработчику";
            this.buttonToDeveloper.Name = "buttonToDeveloper";
            this.buttonToDeveloper.ShowImage = true;
            this.buttonToDeveloper.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnToDeveloper_Click);
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
            this.groupCreateZUnOVA.ResumeLayout(false);
            this.groupCreateZUnOVA.PerformLayout();
            this.groupCreateZUnTO.ResumeLayout(false);
            this.groupCreateZUnTO.PerformLayout();
            this.groupCreateOtherZUN.ResumeLayout(false);
            this.groupCreateOtherZUN.PerformLayout();
            this.groupSmart.ResumeLayout(false);
            this.groupSmart.PerformLayout();
            this.groupSettingOVA.ResumeLayout(false);
            this.groupSettingOVA.PerformLayout();
            this.groupTestMode.ResumeLayout(false);
            this.groupTestMode.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupCreateZUnOVA;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton btnCreateZUnInABF;
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
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupTestMode;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel labelToDeveloper;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonToDeveloper;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupCreateOtherZUN;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonCreateOtherZUn;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupCreateZUnTO;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnCreateZUnInTO;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonCreateZunInToWithMsg;
    }

    partial class ThisRibbonCollection
	{
		internal RibbonOVA RibbonOVA
		{
			get { return this.GetRibbon<RibbonOVA>(); }
		}
	}

    
}
