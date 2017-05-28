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
			this.tabControlSettings = new System.Windows.Forms.TabControl();
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
			this.tabPageZUn = new System.Windows.Forms.TabPage();
			this.btnOK = new System.Windows.Forms.Button();
			this.buttonCаncel = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.tabControlSettings.SuspendLayout();
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
			this.tabPageZUn.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlSettings
			// 
			this.tabControlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlSettings.Controls.Add(this.tabPageSMART);
			this.tabControlSettings.Controls.Add(this.tabPageZUn);
			this.tabControlSettings.Location = new System.Drawing.Point(1, 0);
			this.tabControlSettings.Name = "tabControlSettings";
			this.tabControlSettings.SelectedIndex = 0;
			this.tabControlSettings.Size = new System.Drawing.Size(600, 457);
			this.tabControlSettings.TabIndex = 0;
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
			// tabPageZUn
			// 
			this.tabPageZUn.Controls.Add(this.linkLabel1);
			this.tabPageZUn.Location = new System.Drawing.Point(4, 22);
			this.tabPageZUn.Name = "tabPageZUn";
			this.tabPageZUn.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageZUn.Size = new System.Drawing.Size(592, 431);
			this.tabPageZUn.TabIndex = 1;
			this.tabPageZUn.Text = "Заявка универсальная";
			this.tabPageZUn.ToolTipText = "Настройки для создания Заявки универсальной";
			this.tabPageZUn.UseVisualStyleBackColor = true;
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
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(41, 36);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(501, 26);
			this.linkLabel1.TabIndex = 0;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Необходимость создавать индивидуальные настройки для Заявок универсальных обсужда" +
    "ется.\r\nКликнув можно отправить письмо с пожеланиями.";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
			this.tabPageZUn.ResumeLayout(false);
			this.tabPageZUn.PerformLayout();
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
		private System.Windows.Forms.LinkLabel linkLabel1;
	}
}