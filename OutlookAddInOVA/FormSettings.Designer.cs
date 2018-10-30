namespace OutlookAddInOVA
{
	partial class FormSettings
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.cbCreateZUnTO = new System.Windows.Forms.CheckBox();
            this.cbCreateOtherZUn = new System.Windows.Forms.CheckBox();
            this.cbCreateZUnOVA = new System.Windows.Forms.CheckBox();
            this.cbCreateSMART = new System.Windows.Forms.CheckBox();
            this.tabPageZUn = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPodrazdTo = new System.Windows.Forms.TextBox();
            this.labelPodrazdTo = new System.Windows.Forms.Label();
            this.tbZUnButtonName = new System.Windows.Forms.TextBox();
            this.labelZUnButtonName = new System.Windows.Forms.Label();
            this.labelAddSegment = new System.Windows.Forms.Label();
            this.tbZUnAddSegment = new System.Windows.Forms.TextBox();
            this.tabPageSMART = new System.Windows.Forms.TabPage();
            this.tabSettingsSmart = new System.Windows.Forms.TabControl();
            this.tabPageFastSmart = new System.Windows.Forms.TabPage();
            this.splitContainerFastText = new System.Windows.Forms.SplitContainer();
            this.tbFormulirovkaFastSmart = new System.Windows.Forms.TextBox();
            this.labelKriterii = new System.Windows.Forms.Label();
            this.tbKriteriiFastSmart = new System.Windows.Forms.TextBox();
            this.labelFormulirovka = new System.Windows.Forms.Label();
            this.tabPageSmartExecutor = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainerSmartExecutor = new System.Windows.Forms.SplitContainer();
            this.tbFormulirovkaExecutorSmart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKriteriiExecutorSmart = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.buttonCаncel = new System.Windows.Forms.Button();
            this.toolTipFormSettings = new System.Windows.Forms.ToolTip(this.components);
            this.tabControlSettings.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageZUn.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageSMART.SuspendLayout();
            this.tabSettingsSmart.SuspendLayout();
            this.tabPageFastSmart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFastText)).BeginInit();
            this.splitContainerFastText.Panel1.SuspendLayout();
            this.splitContainerFastText.Panel2.SuspendLayout();
            this.splitContainerFastText.SuspendLayout();
            this.tabPageSmartExecutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSmartExecutor)).BeginInit();
            this.splitContainerSmartExecutor.Panel1.SuspendLayout();
            this.splitContainerSmartExecutor.Panel2.SuspendLayout();
            this.splitContainerSmartExecutor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlSettings.Controls.Add(this.tabPageMain);
            this.tabControlSettings.Controls.Add(this.tabPageZUn);
            this.tabControlSettings.Controls.Add(this.tabPageSMART);
            this.tabControlSettings.Location = new System.Drawing.Point(1, 0);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(600, 457);
            this.tabControlSettings.TabIndex = 0;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.cbCreateZUnTO);
            this.tabPageMain.Controls.Add(this.cbCreateOtherZUn);
            this.tabPageMain.Controls.Add(this.cbCreateZUnOVA);
            this.tabPageMain.Controls.Add(this.cbCreateSMART);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Size = new System.Drawing.Size(592, 431);
            this.tabPageMain.TabIndex = 2;
            this.tabPageMain.Text = "Основные";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // cbCreateZUnTO
            // 
            this.cbCreateZUnTO.AutoSize = true;
            this.cbCreateZUnTO.Location = new System.Drawing.Point(7, 49);
            this.cbCreateZUnTO.Name = "cbCreateZUnTO";
            this.cbCreateZUnTO.Size = new System.Drawing.Size(149, 17);
            this.cbCreateZUnTO.TabIndex = 3;
            this.cbCreateZUnTO.Text = "Создавать ЗУн в УК ТО";
            this.cbCreateZUnTO.UseVisualStyleBackColor = true;
            this.cbCreateZUnTO.CheckedChanged += new System.EventHandler(this.cbCreateZUnTO_CheckedChanged);
            // 
            // cbCreateOtherZUn
            // 
            this.cbCreateOtherZUn.AutoSize = true;
            this.cbCreateOtherZUn.Location = new System.Drawing.Point(7, 72);
            this.cbCreateOtherZUn.Name = "cbCreateOtherZUn";
            this.cbCreateOtherZUn.Size = new System.Drawing.Size(190, 17);
            this.cbCreateOtherZUn.TabIndex = 2;
            this.cbCreateOtherZUn.Text = "Создавать ЗУн в другие отделы";
            this.cbCreateOtherZUn.UseVisualStyleBackColor = true;
            this.cbCreateOtherZUn.CheckedChanged += new System.EventHandler(this.cbCreateOtherZUn_CheckedChanged);
            // 
            // cbCreateZUnOVA
            // 
            this.cbCreateZUnOVA.AutoSize = true;
            this.cbCreateZUnOVA.Location = new System.Drawing.Point(7, 26);
            this.cbCreateZUnOVA.Name = "cbCreateZUnOVA";
            this.cbCreateZUnOVA.Size = new System.Drawing.Size(156, 17);
            this.cbCreateZUnOVA.TabIndex = 1;
            this.cbCreateZUnOVA.Text = "Создавать ЗУн в УК ОВА";
            this.cbCreateZUnOVA.UseVisualStyleBackColor = true;
            this.cbCreateZUnOVA.CheckedChanged += new System.EventHandler(this.cbCreateZUnOVA_CheckedChanged);
            // 
            // cbCreateSMART
            // 
            this.cbCreateSMART.AutoSize = true;
            this.cbCreateSMART.Location = new System.Drawing.Point(7, 3);
            this.cbCreateSMART.Name = "cbCreateSMART";
            this.cbCreateSMART.Size = new System.Drawing.Size(120, 17);
            this.cbCreateSMART.TabIndex = 0;
            this.cbCreateSMART.Text = "Создавать СМАРТ";
            this.cbCreateSMART.UseVisualStyleBackColor = true;
            this.cbCreateSMART.CheckedChanged += new System.EventHandler(this.cbCreateSMART_CheckedChanged);
            // 
            // tabPageZUn
            // 
            this.tabPageZUn.Controls.Add(this.groupBox1);
            this.tabPageZUn.Location = new System.Drawing.Point(4, 22);
            this.tabPageZUn.Name = "tabPageZUn";
            this.tabPageZUn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageZUn.Size = new System.Drawing.Size(592, 431);
            this.tabPageZUn.TabIndex = 1;
            this.tabPageZUn.Text = "Заявка универсальная";
            this.tabPageZUn.ToolTipText = "Настройки для создания Заявки универсальной";
            this.tabPageZUn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPodrazdTo);
            this.groupBox1.Controls.Add(this.labelPodrazdTo);
            this.groupBox1.Controls.Add(this.tbZUnButtonName);
            this.groupBox1.Controls.Add(this.labelZUnButtonName);
            this.groupBox1.Controls.Add(this.labelAddSegment);
            this.groupBox1.Controls.Add(this.tbZUnAddSegment);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание собственных ЗУн";
            // 
            // tbPodrazdTo
            // 
            this.tbPodrazdTo.Location = new System.Drawing.Point(141, 25);
            this.tbPodrazdTo.Name = "tbPodrazdTo";
            this.tbPodrazdTo.Size = new System.Drawing.Size(430, 20);
            this.tbPodrazdTo.TabIndex = 6;
            // 
            // labelPodrazdTo
            // 
            this.labelPodrazdTo.AutoSize = true;
            this.labelPodrazdTo.Location = new System.Drawing.Point(6, 25);
            this.labelPodrazdTo.Name = "labelPodrazdTo";
            this.labelPodrazdTo.Size = new System.Drawing.Size(116, 13);
            this.labelPodrazdTo.TabIndex = 5;
            this.labelPodrazdTo.Text = "Подразделение куда:";
            // 
            // tbZUnButtonName
            // 
            this.tbZUnButtonName.Location = new System.Drawing.Point(141, 100);
            this.tbZUnButtonName.Name = "tbZUnButtonName";
            this.tbZUnButtonName.Size = new System.Drawing.Size(430, 20);
            this.tbZUnButtonName.TabIndex = 4;
            // 
            // labelZUnButtonName
            // 
            this.labelZUnButtonName.AutoSize = true;
            this.labelZUnButtonName.Location = new System.Drawing.Point(6, 96);
            this.labelZUnButtonName.Name = "labelZUnButtonName";
            this.labelZUnButtonName.Size = new System.Drawing.Size(129, 26);
            this.labelZUnButtonName.TabIndex = 3;
            this.labelZUnButtonName.Text = "Краткое наименование \r\nдля кнопки:";
            // 
            // labelAddSegment
            // 
            this.labelAddSegment.AutoSize = true;
            this.labelAddSegment.Location = new System.Drawing.Point(6, 64);
            this.labelAddSegment.Name = "labelAddSegment";
            this.labelAddSegment.Size = new System.Drawing.Size(70, 13);
            this.labelAddSegment.TabIndex = 2;
            this.labelAddSegment.Text = "Доп.разрез:";
            // 
            // tbZUnAddSegment
            // 
            this.tbZUnAddSegment.AcceptsReturn = true;
            this.tbZUnAddSegment.Location = new System.Drawing.Point(141, 61);
            this.tbZUnAddSegment.Name = "tbZUnAddSegment";
            this.tbZUnAddSegment.Size = new System.Drawing.Size(430, 20);
            this.tbZUnAddSegment.TabIndex = 0;
            this.toolTipFormSettings.SetToolTip(this.tbZUnAddSegment, "Необходимо точно указать наименование дополнительного разреза.\r\nЛучше это скопиро" +
        "вать непосредственно из АБФ");
            // 
            // tabPageSMART
            // 
            this.tabPageSMART.Controls.Add(this.tabSettingsSmart);
            this.tabPageSMART.Location = new System.Drawing.Point(4, 22);
            this.tabPageSMART.Name = "tabPageSMART";
            this.tabPageSMART.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSMART.Size = new System.Drawing.Size(592, 431);
            this.tabPageSMART.TabIndex = 0;
            this.tabPageSMART.Text = "СМАРТ задача";
            this.tabPageSMART.ToolTipText = "Настройки для создания Смарт задач";
            this.tabPageSMART.UseVisualStyleBackColor = true;
            // 
            // tabSettingsSmart
            // 
            this.tabSettingsSmart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSettingsSmart.Controls.Add(this.tabPageFastSmart);
            this.tabSettingsSmart.Controls.Add(this.tabPageSmartExecutor);
            this.tabSettingsSmart.Location = new System.Drawing.Point(3, 3);
            this.tabSettingsSmart.Name = "tabSettingsSmart";
            this.tabSettingsSmart.SelectedIndex = 0;
            this.tabSettingsSmart.Size = new System.Drawing.Size(583, 422);
            this.tabSettingsSmart.TabIndex = 0;
            // 
            // tabPageFastSmart
            // 
            this.tabPageFastSmart.Controls.Add(this.splitContainerFastText);
            this.tabPageFastSmart.Controls.Add(this.labelFormulirovka);
            this.tabPageFastSmart.Location = new System.Drawing.Point(4, 22);
            this.tabPageFastSmart.Name = "tabPageFastSmart";
            this.tabPageFastSmart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFastSmart.Size = new System.Drawing.Size(575, 396);
            this.tabPageFastSmart.TabIndex = 0;
            this.tabPageFastSmart.Text = "Быстрая СМАРТ себе";
            this.tabPageFastSmart.ToolTipText = "Настройки для быстрого создания СМАРТ задачи себе";
            this.tabPageFastSmart.UseVisualStyleBackColor = true;
            // 
            // splitContainerFastText
            // 
            this.splitContainerFastText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerFastText.BackColor = System.Drawing.Color.Transparent;
            this.splitContainerFastText.Location = new System.Drawing.Point(-9, 16);
            this.splitContainerFastText.Name = "splitContainerFastText";
            this.splitContainerFastText.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerFastText.Panel1
            // 
            this.splitContainerFastText.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainerFastText.Panel1.Controls.Add(this.tbFormulirovkaFastSmart);
            // 
            // splitContainerFastText.Panel2
            // 
            this.splitContainerFastText.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainerFastText.Panel2.Controls.Add(this.labelKriterii);
            this.splitContainerFastText.Panel2.Controls.Add(this.tbKriteriiFastSmart);
            this.splitContainerFastText.Size = new System.Drawing.Size(578, 376);
            this.splitContainerFastText.SplitterDistance = 187;
            this.splitContainerFastText.TabIndex = 10;
            // 
            // tbFormulirovkaFastSmart
            // 
            this.tbFormulirovkaFastSmart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFormulirovkaFastSmart.Location = new System.Drawing.Point(15, 3);
            this.tbFormulirovkaFastSmart.Multiline = true;
            this.tbFormulirovkaFastSmart.Name = "tbFormulirovkaFastSmart";
            this.tbFormulirovkaFastSmart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFormulirovkaFastSmart.Size = new System.Drawing.Size(562, 177);
            this.tbFormulirovkaFastSmart.TabIndex = 0;
            // 
            // labelKriterii
            // 
            this.labelKriterii.AutoSize = true;
            this.labelKriterii.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelKriterii.Location = new System.Drawing.Point(13, -2);
            this.labelKriterii.Name = "labelKriterii";
            this.labelKriterii.Size = new System.Drawing.Size(180, 13);
            this.labelKriterii.TabIndex = 6;
            this.labelKriterii.Text = "Критерии успешного выполнения:";
            // 
            // tbKriteriiFastSmart
            // 
            this.tbKriteriiFastSmart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKriteriiFastSmart.Location = new System.Drawing.Point(15, 16);
            this.tbKriteriiFastSmart.Multiline = true;
            this.tbKriteriiFastSmart.Name = "tbKriteriiFastSmart";
            this.tbKriteriiFastSmart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbKriteriiFastSmart.Size = new System.Drawing.Size(562, 168);
            this.tbKriteriiFastSmart.TabIndex = 0;
            // 
            // labelFormulirovka
            // 
            this.labelFormulirovka.AutoSize = true;
            this.labelFormulirovka.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelFormulirovka.Location = new System.Drawing.Point(4, 2);
            this.labelFormulirovka.Name = "labelFormulirovka";
            this.labelFormulirovka.Size = new System.Drawing.Size(88, 13);
            this.labelFormulirovka.TabIndex = 9;
            this.labelFormulirovka.Text = "Формулировка:";
            // 
            // tabPageSmartExecutor
            // 
            this.tabPageSmartExecutor.Controls.Add(this.label2);
            this.tabPageSmartExecutor.Controls.Add(this.splitContainerSmartExecutor);
            this.tabPageSmartExecutor.Location = new System.Drawing.Point(4, 22);
            this.tabPageSmartExecutor.Name = "tabPageSmartExecutor";
            this.tabPageSmartExecutor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSmartExecutor.Size = new System.Drawing.Size(575, 396);
            this.tabPageSmartExecutor.TabIndex = 1;
            this.tabPageSmartExecutor.Text = "Смарт исполнителю";
            this.tabPageSmartExecutor.ToolTipText = "Настройки для создания СМАРТ задачи исполнителю";
            this.tabPageSmartExecutor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(4, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Формулировка:";
            // 
            // splitContainerSmartExecutor
            // 
            this.splitContainerSmartExecutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerSmartExecutor.BackColor = System.Drawing.Color.Transparent;
            this.splitContainerSmartExecutor.Location = new System.Drawing.Point(-9, 16);
            this.splitContainerSmartExecutor.Name = "splitContainerSmartExecutor";
            this.splitContainerSmartExecutor.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerSmartExecutor.Panel1
            // 
            this.splitContainerSmartExecutor.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainerSmartExecutor.Panel1.Controls.Add(this.tbFormulirovkaExecutorSmart);
            // 
            // splitContainerSmartExecutor.Panel2
            // 
            this.splitContainerSmartExecutor.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainerSmartExecutor.Panel2.Controls.Add(this.label1);
            this.splitContainerSmartExecutor.Panel2.Controls.Add(this.tbKriteriiExecutorSmart);
            this.splitContainerSmartExecutor.Size = new System.Drawing.Size(581, 376);
            this.splitContainerSmartExecutor.SplitterDistance = 187;
            this.splitContainerSmartExecutor.TabIndex = 11;
            // 
            // tbFormulirovkaExecutorSmart
            // 
            this.tbFormulirovkaExecutorSmart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFormulirovkaExecutorSmart.Location = new System.Drawing.Point(15, 3);
            this.tbFormulirovkaExecutorSmart.Multiline = true;
            this.tbFormulirovkaExecutorSmart.Name = "tbFormulirovkaExecutorSmart";
            this.tbFormulirovkaExecutorSmart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFormulirovkaExecutorSmart.Size = new System.Drawing.Size(562, 177);
            this.tbFormulirovkaExecutorSmart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(13, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Критерии успешного выполнения:";
            // 
            // tbKriteriiExecutorSmart
            // 
            this.tbKriteriiExecutorSmart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKriteriiExecutorSmart.Location = new System.Drawing.Point(15, 16);
            this.tbKriteriiExecutorSmart.Multiline = true;
            this.tbKriteriiExecutorSmart.Name = "tbKriteriiExecutorSmart";
            this.tbKriteriiExecutorSmart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbKriteriiExecutorSmart.Size = new System.Drawing.Size(562, 168);
            this.tbKriteriiExecutorSmart.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(438, 463);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // buttonCаncel
            // 
            this.buttonCаncel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCаncel.Location = new System.Drawing.Point(520, 463);
            this.buttonCаncel.Name = "buttonCаncel";
            this.buttonCаncel.Size = new System.Drawing.Size(75, 23);
            this.buttonCаncel.TabIndex = 2;
            this.buttonCаncel.Text = "Отмена";
            this.buttonCаncel.UseVisualStyleBackColor = true;
            this.buttonCаncel.Click += new System.EventHandler(this.buttonCаncel_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(601, 492);
            this.Controls.Add(this.buttonCаncel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabControlSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки для Надстройки OutlookAddinOVA";
            this.Shown += new System.EventHandler(this.FormSettings_Shown);
            this.tabControlSettings.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.tabPageZUn.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageSMART.ResumeLayout(false);
            this.tabSettingsSmart.ResumeLayout(false);
            this.tabPageFastSmart.ResumeLayout(false);
            this.tabPageFastSmart.PerformLayout();
            this.splitContainerFastText.Panel1.ResumeLayout(false);
            this.splitContainerFastText.Panel1.PerformLayout();
            this.splitContainerFastText.Panel2.ResumeLayout(false);
            this.splitContainerFastText.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFastText)).EndInit();
            this.splitContainerFastText.ResumeLayout(false);
            this.tabPageSmartExecutor.ResumeLayout(false);
            this.tabPageSmartExecutor.PerformLayout();
            this.splitContainerSmartExecutor.Panel1.ResumeLayout(false);
            this.splitContainerSmartExecutor.Panel1.PerformLayout();
            this.splitContainerSmartExecutor.Panel2.ResumeLayout(false);
            this.splitContainerSmartExecutor.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSmartExecutor)).EndInit();
            this.splitContainerSmartExecutor.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControlSettings;
		private System.Windows.Forms.TabPage tabPageSMART;
		private System.Windows.Forms.TabControl tabSettingsSmart;
		private System.Windows.Forms.TabPage tabPageFastSmart;
		private System.Windows.Forms.TabPage tabPageSmartExecutor;
		private System.Windows.Forms.TabPage tabPageZUn;
		private System.Windows.Forms.SplitContainer splitContainerFastText;
		private System.Windows.Forms.TextBox tbFormulirovkaFastSmart;
		private System.Windows.Forms.Label labelKriterii;
		private System.Windows.Forms.TextBox tbKriteriiFastSmart;
		private System.Windows.Forms.Label labelFormulirovka;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button buttonCаncel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.SplitContainer splitContainerSmartExecutor;
		private System.Windows.Forms.TextBox tbFormulirovkaExecutorSmart;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbKriteriiExecutorSmart;
        private System.Windows.Forms.ToolTip toolTipFormSettings;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.CheckBox cbCreateOtherZUn;
        private System.Windows.Forms.CheckBox cbCreateZUnOVA;
        private System.Windows.Forms.CheckBox cbCreateSMART;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAddSegment;
        private System.Windows.Forms.TextBox tbZUnAddSegment;
        private System.Windows.Forms.TextBox tbZUnButtonName;
        private System.Windows.Forms.Label labelZUnButtonName;
        private System.Windows.Forms.TextBox tbPodrazdTo;
        private System.Windows.Forms.Label labelPodrazdTo;
        private System.Windows.Forms.CheckBox cbCreateZUnTO;
    }
}