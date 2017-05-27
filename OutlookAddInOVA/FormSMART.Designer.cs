namespace OutlookAddInOVA
{
	partial class FormSMART
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSMART));
			this.toolTipSmart = new System.Windows.Forms.ToolTip(this.components);
			this.comboBoxExecutor = new System.Windows.Forms.ComboBox();
			this.splitContainerText = new System.Windows.Forms.SplitContainer();
			this.tbFormulirovka = new System.Windows.Forms.TextBox();
			this.labelKriterii = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.tbKriterii = new System.Windows.Forms.TextBox();
			this.dTPDoDate = new System.Windows.Forms.DateTimePicker();
			this.labelDate = new System.Windows.Forms.Label();
			this.labelExecutor = new System.Windows.Forms.Label();
			this.nUDVes = new System.Windows.Forms.NumericUpDown();
			this.labelVes = new System.Windows.Forms.Label();
			this.labelFormulirovka = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerText)).BeginInit();
			this.splitContainerText.Panel1.SuspendLayout();
			this.splitContainerText.Panel2.SuspendLayout();
			this.splitContainerText.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nUDVes)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBoxExecutor
			// 
			this.comboBoxExecutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboBoxExecutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBoxExecutor.CausesValidation = false;
			this.comboBoxExecutor.DisplayMember = "FIO";
			this.comboBoxExecutor.FormattingEnabled = true;
			this.comboBoxExecutor.Location = new System.Drawing.Point(269, 9);
			this.comboBoxExecutor.Name = "comboBoxExecutor";
			this.comboBoxExecutor.Size = new System.Drawing.Size(209, 21);
			this.comboBoxExecutor.TabIndex = 2;
			this.toolTipSmart.SetToolTip(this.comboBoxExecutor, "Выберите Исполнителя задачи.\r\nИли оставьте себя.");
			this.comboBoxExecutor.ValueMember = "EMail";
			// 
			// splitContainerText
			// 
			this.splitContainerText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainerText.Location = new System.Drawing.Point(3, 45);
			this.splitContainerText.Name = "splitContainerText";
			this.splitContainerText.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainerText.Panel1
			// 
			this.splitContainerText.Panel1.Controls.Add(this.tbFormulirovka);
			// 
			// splitContainerText.Panel2
			// 
			this.splitContainerText.Panel2.Controls.Add(this.labelKriterii);
			this.splitContainerText.Panel2.Controls.Add(this.btnCancel);
			this.splitContainerText.Panel2.Controls.Add(this.btnOk);
			this.splitContainerText.Panel2.Controls.Add(this.tbKriterii);
			this.splitContainerText.Size = new System.Drawing.Size(593, 367);
			this.splitContainerText.SplitterDistance = 183;
			this.splitContainerText.SplitterWidth = 2;
			this.splitContainerText.TabIndex = 8;
			// 
			// tbFormulirovka
			// 
			this.tbFormulirovka.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbFormulirovka.Location = new System.Drawing.Point(4, 4);
			this.tbFormulirovka.Multiline = true;
			this.tbFormulirovka.Name = "tbFormulirovka";
			this.tbFormulirovka.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbFormulirovka.Size = new System.Drawing.Size(586, 176);
			this.tbFormulirovka.TabIndex = 0;
			this.toolTipSmart.SetToolTip(this.tbFormulirovka, "При необходимости добавьте текст формулировки.");
			// 
			// labelKriterii
			// 
			this.labelKriterii.AutoSize = true;
			this.labelKriterii.ForeColor = System.Drawing.Color.RoyalBlue;
			this.labelKriterii.Location = new System.Drawing.Point(2, -2);
			this.labelKriterii.Name = "labelKriterii";
			this.labelKriterii.Size = new System.Drawing.Size(180, 13);
			this.labelKriterii.TabIndex = 6;
			this.labelKriterii.Text = "Критерии успешного выполнения:";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(493, 154);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.Location = new System.Drawing.Point(400, 154);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 4;
			this.btnOk.Text = "ОК";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// tbKriterii
			// 
			this.tbKriterii.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbKriterii.Location = new System.Drawing.Point(4, 16);
			this.tbKriterii.Multiline = true;
			this.tbKriterii.Name = "tbKriterii";
			this.tbKriterii.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbKriterii.Size = new System.Drawing.Size(586, 165);
			this.tbKriterii.TabIndex = 0;
			this.toolTipSmart.SetToolTip(this.tbKriterii, "При необходимости добавьте текст Критерия успешного выполнения.");
			// 
			// dTPDoDate
			// 
			this.dTPDoDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dTPDoDate.Location = new System.Drawing.Point(88, 9);
			this.dTPDoDate.Name = "dTPDoDate";
			this.dTPDoDate.Size = new System.Drawing.Size(92, 20);
			this.dTPDoDate.TabIndex = 0;
			this.toolTipSmart.SetToolTip(this.dTPDoDate, "Укажите желаемую дату выполнения задачи");
			// 
			// labelDate
			// 
			this.labelDate.AutoSize = true;
			this.labelDate.Location = new System.Drawing.Point(7, 13);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(75, 13);
			this.labelDate.TabIndex = 1;
			this.labelDate.Text = "Выполнить к:";
			// 
			// labelExecutor
			// 
			this.labelExecutor.AutoSize = true;
			this.labelExecutor.Location = new System.Drawing.Point(186, 13);
			this.labelExecutor.Name = "labelExecutor";
			this.labelExecutor.Size = new System.Drawing.Size(77, 13);
			this.labelExecutor.TabIndex = 3;
			this.labelExecutor.Text = "Исполнитель:";
			// 
			// nUDVes
			// 
			this.nUDVes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.nUDVes.Location = new System.Drawing.Point(519, 9);
			this.nUDVes.Name = "nUDVes";
			this.nUDVes.Size = new System.Drawing.Size(48, 20);
			this.nUDVes.TabIndex = 6;
			this.toolTipSmart.SetToolTip(this.nUDVes, "Укажатие вес задачи");
			this.nUDVes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// labelVes
			// 
			this.labelVes.AutoSize = true;
			this.labelVes.Location = new System.Drawing.Point(484, 13);
			this.labelVes.Name = "labelVes";
			this.labelVes.Size = new System.Drawing.Size(29, 13);
			this.labelVes.TabIndex = 7;
			this.labelVes.Text = "Вес:";
			// 
			// labelFormulirovka
			// 
			this.labelFormulirovka.AutoSize = true;
			this.labelFormulirovka.ForeColor = System.Drawing.Color.RoyalBlue;
			this.labelFormulirovka.Location = new System.Drawing.Point(5, 32);
			this.labelFormulirovka.Name = "labelFormulirovka";
			this.labelFormulirovka.Size = new System.Drawing.Size(88, 13);
			this.labelFormulirovka.TabIndex = 1;
			this.labelFormulirovka.Text = "Формулировка:";
			// 
			// FormSMART
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(603, 419);
			this.Controls.Add(this.labelFormulirovka);
			this.Controls.Add(this.labelVes);
			this.Controls.Add(this.nUDVes);
			this.Controls.Add(this.labelExecutor);
			this.Controls.Add(this.comboBoxExecutor);
			this.Controls.Add(this.labelDate);
			this.Controls.Add(this.dTPDoDate);
			this.Controls.Add(this.splitContainerText);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormSMART";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Создание Смарт задачи";
			this.splitContainerText.Panel1.ResumeLayout(false);
			this.splitContainerText.Panel1.PerformLayout();
			this.splitContainerText.Panel2.ResumeLayout(false);
			this.splitContainerText.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerText)).EndInit();
			this.splitContainerText.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nUDVes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolTip toolTipSmart;
		private System.Windows.Forms.DateTimePicker dTPDoDate;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.ComboBox comboBoxExecutor;
		private System.Windows.Forms.Label labelExecutor;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.NumericUpDown nUDVes;
		private System.Windows.Forms.Label labelVes;
		private System.Windows.Forms.SplitContainer splitContainerText;
		private System.Windows.Forms.Label labelFormulirovka;
		private System.Windows.Forms.TextBox tbFormulirovka;
		private System.Windows.Forms.Label labelKriterii;
		private System.Windows.Forms.TextBox tbKriterii;
	}
}