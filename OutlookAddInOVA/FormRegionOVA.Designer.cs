namespace OutlookAddInOVA
{
	[System.ComponentModel.ToolboxItemAttribute(false)]
	partial class FormRegionOVA : Microsoft.Office.Tools.Outlook.FormRegionBase
	{



		public FormRegionOVA(Microsoft.Office.Interop.Outlook.FormRegion formRegion)
			: base(Globals.Factory, formRegion)
		{
			this.InitializeComponent();
		}

		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mcIspolnitK = new System.Windows.Forms.MonthCalendar();
            this.tbTextZUn = new System.Windows.Forms.TextBox();
            this.cbCreateZUn = new System.Windows.Forms.CheckBox();
            this.cbImportant = new System.Windows.Forms.CheckBox();
            this.toolTipRegionOVA = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxHideFromRegion = new System.Windows.Forms.CheckBox();
            this.tabOVA = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.comboBoxDopRazrez = new System.Windows.Forms.ComboBox();
            this.cbApproval = new System.Windows.Forms.CheckBox();
            this.tabPageApproval = new System.Windows.Forms.TabPage();
            this.dataGVWapproval = new System.Windows.Forms.DataGridView();
            this.tabPageAdditionalForOVA = new System.Windows.Forms.TabPage();
            this.labelExecutor = new System.Windows.Forms.Label();
            this.tbCommentToExecutor = new System.Windows.Forms.TextBox();
            this.comboBoxExecutor = new System.Windows.Forms.ComboBox();
            this.thisAddInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CoWorker = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Degree = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabOVA.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageApproval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVWapproval)).BeginInit();
            this.tabPageAdditionalForOVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thisAddInBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mcIspolnitK
            // 
            this.mcIspolnitK.Location = new System.Drawing.Point(9, 34);
            this.mcIspolnitK.Name = "mcIspolnitK";
            this.mcIspolnitK.TabIndex = 0;
            this.toolTipRegionOVA.SetToolTip(this.mcIspolnitK, "Указать желаемую дату выполнения Заявки универсальной");
            this.mcIspolnitK.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcIspolnitK_DateChanged);
            // 
            // tbTextZUn
            // 
            this.tbTextZUn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTextZUn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTextZUn.Location = new System.Drawing.Point(185, 34);
            this.tbTextZUn.Multiline = true;
            this.tbTextZUn.Name = "tbTextZUn";
            this.tbTextZUn.Size = new System.Drawing.Size(615, 162);
            this.tbTextZUn.TabIndex = 2;
            this.tbTextZUn.Text = "При необходимости введите текст поручения ЗУн";
            this.toolTipRegionOVA.SetToolTip(this.tbTextZUn, "Если ввести в этом поле текст, то только он будет указан в Поручении Заявки униве" +
        "рсальной.\r\nПри этом всё письмо будет прикрепленно к ЗУн");
            this.tbTextZUn.TextChanged += new System.EventHandler(this.tbTextZUn_TextChanged);
            this.tbTextZUn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTextZUn_KeyDown);
            // 
            // cbCreateZUn
            // 
            this.cbCreateZUn.AutoSize = true;
            this.cbCreateZUn.Location = new System.Drawing.Point(9, 9);
            this.cbCreateZUn.Name = "cbCreateZUn";
            this.cbCreateZUn.Size = new System.Drawing.Size(144, 17);
            this.cbCreateZUn.TabIndex = 3;
            this.cbCreateZUn.Text = "Создать ЗУн в УК ОВА";
            this.toolTipRegionOVA.SetToolTip(this.cbCreateZUn, "При включении этого флага, на основании письма будет создана Заявка универсальная" +
        "в УК ОВА");
            this.cbCreateZUn.UseVisualStyleBackColor = true;
            this.cbCreateZUn.CheckedChanged += new System.EventHandler(this.cbCreateZUn_CheckedChanged);
            // 
            // cbImportant
            // 
            this.cbImportant.AutoSize = true;
            this.cbImportant.Location = new System.Drawing.Point(185, 9);
            this.cbImportant.Name = "cbImportant";
            this.cbImportant.Size = new System.Drawing.Size(62, 17);
            this.cbImportant.TabIndex = 4;
            this.cbImportant.Text = "Срочно";
            this.toolTipRegionOVA.SetToolTip(this.cbImportant, "Указать Срочность заявки");
            this.cbImportant.UseVisualStyleBackColor = true;
            this.cbImportant.CheckedChanged += new System.EventHandler(this.cbImportant_CheckedChanged);
            // 
            // checkBoxHideFromRegion
            // 
            this.checkBoxHideFromRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxHideFromRegion.AutoSize = true;
            this.checkBoxHideFromRegion.Location = new System.Drawing.Point(576, 9);
            this.checkBoxHideFromRegion.Name = "checkBoxHideFromRegion";
            this.checkBoxHideFromRegion.Size = new System.Drawing.Size(224, 17);
            this.checkBoxHideFromRegion.TabIndex = 6;
            this.checkBoxHideFromRegion.Text = "Не показывать эту область в будущем";
            this.toolTipRegionOVA.SetToolTip(this.checkBoxHideFromRegion, "При включении этого флага, эта область впредь не будет показваться.\r\nДля включени" +
        "я показа, необходимо открыть Настройки этой Надстройки.\r\nМеню Файл/Надстройки/На" +
        "стройки OutlookAddInOVA");
            this.checkBoxHideFromRegion.UseVisualStyleBackColor = false;
            this.checkBoxHideFromRegion.CheckedChanged += new System.EventHandler(this.checkBoxHideFromRegion_CheckedChanged);
            // 
            // tabOVA
            // 
            this.tabOVA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOVA.Controls.Add(this.tabPageMain);
            this.tabOVA.Controls.Add(this.tabPageApproval);
            this.tabOVA.Controls.Add(this.tabPageAdditionalForOVA);
            this.tabOVA.Location = new System.Drawing.Point(0, 0);
            this.tabOVA.Name = "tabOVA";
            this.tabOVA.SelectedIndex = 0;
            this.tabOVA.Size = new System.Drawing.Size(814, 222);
            this.tabOVA.TabIndex = 5;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.comboBoxDopRazrez);
            this.tabPageMain.Controls.Add(this.checkBoxHideFromRegion);
            this.tabPageMain.Controls.Add(this.cbApproval);
            this.tabPageMain.Controls.Add(this.tbTextZUn);
            this.tabPageMain.Controls.Add(this.cbImportant);
            this.tabPageMain.Controls.Add(this.mcIspolnitK);
            this.tabPageMain.Controls.Add(this.cbCreateZUn);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(806, 196);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Поручение";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // comboBoxDopRazrez
            // 
            this.comboBoxDopRazrez.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDopRazrez.FormattingEnabled = true;
            this.comboBoxDopRazrez.Items.AddRange(new object[] {
            "1.Любые вопросы в ОВА (выбирайте этот разрез, если есть сомнения в выборе другого" +
                " разреза)",
            "2.Изменение (редактирование) данных; Права доступа",
            "3.Доработка АБФ",
            "4.Запрос данных (информации)"});
            this.comboBoxDopRazrez.Location = new System.Drawing.Point(358, 7);
            this.comboBoxDopRazrez.Name = "comboBoxDopRazrez";
            this.comboBoxDopRazrez.Size = new System.Drawing.Size(212, 21);
            this.comboBoxDopRazrez.TabIndex = 7;
            this.comboBoxDopRazrez.Visible = false;
            this.comboBoxDopRazrez.SelectedIndexChanged += new System.EventHandler(this.comboBoxDopRazrez_SelectedIndexChanged);
            // 
            // cbApproval
            // 
            this.cbApproval.AutoSize = true;
            this.cbApproval.Location = new System.Drawing.Point(254, 9);
            this.cbApproval.Name = "cbApproval";
            this.cbApproval.Size = new System.Drawing.Size(98, 17);
            this.cbApproval.TabIndex = 5;
            this.cbApproval.Text = "Согласование";
            this.cbApproval.UseVisualStyleBackColor = true;
            this.cbApproval.Visible = false;
            this.cbApproval.CheckedChanged += new System.EventHandler(this.cbApproval_CheckedChanged);
            // 
            // tabPageApproval
            // 
            this.tabPageApproval.Controls.Add(this.dataGVWapproval);
            this.tabPageApproval.Location = new System.Drawing.Point(4, 22);
            this.tabPageApproval.Name = "tabPageApproval";
            this.tabPageApproval.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApproval.Size = new System.Drawing.Size(806, 196);
            this.tabPageApproval.TabIndex = 1;
            this.tabPageApproval.Text = "Согласование";
            this.tabPageApproval.UseVisualStyleBackColor = true;
            // 
            // dataGVWapproval
            // 
            this.dataGVWapproval.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGVWapproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVWapproval.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CoWorker,
            this.Degree});
            this.dataGVWapproval.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGVWapproval.Location = new System.Drawing.Point(0, 0);
            this.dataGVWapproval.Name = "dataGVWapproval";
            this.dataGVWapproval.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGVWapproval.Size = new System.Drawing.Size(805, 195);
            this.dataGVWapproval.TabIndex = 0;
            this.dataGVWapproval.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVWapproval_CellClick);
            this.dataGVWapproval.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVWapproval_CellValueChanged);
            // 
            // tabPageAdditionalForOVA
            // 
            this.tabPageAdditionalForOVA.Controls.Add(this.labelExecutor);
            this.tabPageAdditionalForOVA.Controls.Add(this.tbCommentToExecutor);
            this.tabPageAdditionalForOVA.Controls.Add(this.comboBoxExecutor);
            this.tabPageAdditionalForOVA.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdditionalForOVA.Name = "tabPageAdditionalForOVA";
            this.tabPageAdditionalForOVA.Size = new System.Drawing.Size(806, 196);
            this.tabPageAdditionalForOVA.TabIndex = 2;
            this.tabPageAdditionalForOVA.Text = "Дополнительное";
            this.tabPageAdditionalForOVA.UseVisualStyleBackColor = true;
            // 
            // labelExecutor
            // 
            this.labelExecutor.AutoSize = true;
            this.labelExecutor.Location = new System.Drawing.Point(3, 15);
            this.labelExecutor.Name = "labelExecutor";
            this.labelExecutor.Size = new System.Drawing.Size(77, 13);
            this.labelExecutor.TabIndex = 5;
            this.labelExecutor.Text = "Исполнитель:";
            // 
            // tbCommentToExecutor
            // 
            this.tbCommentToExecutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCommentToExecutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCommentToExecutor.Location = new System.Drawing.Point(3, 39);
            this.tbCommentToExecutor.Multiline = true;
            this.tbCommentToExecutor.Name = "tbCommentToExecutor";
            this.tbCommentToExecutor.Size = new System.Drawing.Size(802, 154);
            this.tbCommentToExecutor.TabIndex = 4;
            this.tbCommentToExecutor.Text = "При необходимости укажите текст поручения Исполнителю ЗУн\r\n";
            this.tbCommentToExecutor.TextChanged += new System.EventHandler(this.tbCommentToExecutor_TextChanged);
            this.tbCommentToExecutor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCommentToExecutor_KeyDown);
            // 
            // comboBoxExecutor
            // 
            this.comboBoxExecutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxExecutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxExecutor.CausesValidation = false;
            this.comboBoxExecutor.DisplayMember = "FIO";
            this.comboBoxExecutor.FormattingEnabled = true;
            this.comboBoxExecutor.Location = new System.Drawing.Point(86, 12);
            this.comboBoxExecutor.Name = "comboBoxExecutor";
            this.comboBoxExecutor.Size = new System.Drawing.Size(209, 21);
            this.comboBoxExecutor.TabIndex = 3;
            this.comboBoxExecutor.ValueMember = "EMail";
            this.comboBoxExecutor.SelectedIndexChanged += new System.EventHandler(this.comboBoxExecutor_SelectedIndexChanged);
            // 
            // thisAddInBindingSource
            // 
            this.thisAddInBindingSource.DataSource = typeof(OutlookAddInOVA.ThisAddIn);
            // 
            // CoWorker
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.CoWorker.DefaultCellStyle = dataGridViewCellStyle1;
            this.CoWorker.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.CoWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CoWorker.HeaderText = "Сотрудник";
            this.CoWorker.Name = "CoWorker";
            this.CoWorker.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CoWorker.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CoWorker.Width = 250;
            // 
            // Degree
            // 
            this.Degree.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Degree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Degree.HeaderText = "Степень";
            this.Degree.Items.AddRange(new object[] {
            "Согласовать",
            "Ознакомиться"});
            this.Degree.Name = "Degree";
            this.Degree.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Degree.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormRegionOVA
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabOVA);
            this.Name = "FormRegionOVA";
            this.Size = new System.Drawing.Size(817, 222);
            this.toolTipRegionOVA.SetToolTip(this, "В этой области вводятся дополнительные данные для создания Заявки универсальной в" +
        " УК ОВА");
            this.FormRegionShowing += new System.EventHandler(this.FormRegionOVA_FormRegionShowing);
            this.FormRegionClosed += new System.EventHandler(this.FormRegionOVA_FormRegionClosed);
            this.tabOVA.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.tabPageApproval.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVWapproval)).EndInit();
            this.tabPageAdditionalForOVA.ResumeLayout(false);
            this.tabPageAdditionalForOVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thisAddInBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		#region Код, созданный конструктором областей формы

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private static void InitializeManifest(Microsoft.Office.Tools.Outlook.FormRegionManifest manifest, Microsoft.Office.Tools.Outlook.Factory factory)
		{
            manifest.FormRegionName = "Создание ЗУн в УК ОВА";
            manifest.FormRegionType = Microsoft.Office.Tools.Outlook.FormRegionType.Adjoining;
            manifest.ShowInspectorRead = false;
            manifest.ShowReadingPane = false;

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcIspolnitK;
		private System.Windows.Forms.TextBox tbTextZUn;
		private System.Windows.Forms.CheckBox cbCreateZUn;
		private System.Windows.Forms.CheckBox cbImportant;
		private System.Windows.Forms.ToolTip toolTipRegionOVA;
		private System.Windows.Forms.TabControl tabOVA;
		private System.Windows.Forms.TabPage tabPageMain;
		private System.Windows.Forms.CheckBox cbApproval;
		private System.Windows.Forms.TabPage tabPageApproval;
		private System.Windows.Forms.DataGridView dataGVWapproval;
        private System.Windows.Forms.CheckBox checkBoxHideFromRegion;
        private System.Windows.Forms.ComboBox comboBoxDopRazrez;
        private System.Windows.Forms.TabPage tabPageAdditionalForOVA;
        private System.Windows.Forms.TextBox tbCommentToExecutor;
        private System.Windows.Forms.ComboBox comboBoxExecutor;
        private System.Windows.Forms.Label labelExecutor;
        private System.Windows.Forms.BindingSource thisAddInBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn CoWorker;
        private System.Windows.Forms.DataGridViewComboBoxColumn Degree;

        public partial class FormRegionOVAFactory : Microsoft.Office.Tools.Outlook.IFormRegionFactory
		{
			public event Microsoft.Office.Tools.Outlook.FormRegionInitializingEventHandler FormRegionInitializing;

			private Microsoft.Office.Tools.Outlook.FormRegionManifest _Manifest;

			[System.Diagnostics.DebuggerNonUserCodeAttribute()]
			public FormRegionOVAFactory()
			{
				this._Manifest = Globals.Factory.CreateFormRegionManifest();
				FormRegionOVA.InitializeManifest(this._Manifest, Globals.Factory);
				this.FormRegionInitializing += new Microsoft.Office.Tools.Outlook.FormRegionInitializingEventHandler(this.FormRegionOVAFactory_FormRegionInitializing);
                
			}

			[System.Diagnostics.DebuggerNonUserCodeAttribute()]
			public Microsoft.Office.Tools.Outlook.FormRegionManifest Manifest
			{
				get
				{
					return this._Manifest;
				}
			}

			[System.Diagnostics.DebuggerNonUserCodeAttribute()]
			Microsoft.Office.Tools.Outlook.IFormRegion Microsoft.Office.Tools.Outlook.IFormRegionFactory.CreateFormRegion(Microsoft.Office.Interop.Outlook.FormRegion formRegion)
			{
				FormRegionOVA form = new FormRegionOVA(formRegion);
				form.Factory = this;
				return form;
			}

			[System.Diagnostics.DebuggerNonUserCodeAttribute()]
			byte[] Microsoft.Office.Tools.Outlook.IFormRegionFactory.GetFormRegionStorage(object outlookItem, Microsoft.Office.Interop.Outlook.OlFormRegionMode formRegionMode, Microsoft.Office.Interop.Outlook.OlFormRegionSize formRegionSize)
			{
				throw new System.NotSupportedException();
			}

			[System.Diagnostics.DebuggerNonUserCodeAttribute()]
			bool Microsoft.Office.Tools.Outlook.IFormRegionFactory.IsDisplayedForItem(object outlookItem, Microsoft.Office.Interop.Outlook.OlFormRegionMode formRegionMode, Microsoft.Office.Interop.Outlook.OlFormRegionSize formRegionSize)
			{
				if (this.FormRegionInitializing != null)
				{
					Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs cancelArgs = Globals.Factory.CreateFormRegionInitializingEventArgs(outlookItem, formRegionMode, formRegionSize, false);
					this.FormRegionInitializing(this, cancelArgs);
					return !cancelArgs.Cancel;
				}
				else
				{
					return true;
				}
			}

			[System.Diagnostics.DebuggerNonUserCodeAttribute()]
			Microsoft.Office.Tools.Outlook.FormRegionKindConstants Microsoft.Office.Tools.Outlook.IFormRegionFactory.Kind
			{
				get
				{
					return Microsoft.Office.Tools.Outlook.FormRegionKindConstants.WindowsForms;
				}
			}
		}
	}

	partial class WindowFormRegionCollection
	{
		internal FormRegionOVA FormRegionOVA
		{
			get
			{
				foreach (var item in this)
				{
					if (item.GetType() == typeof(FormRegionOVA))
						return (FormRegionOVA)item;
				}
				return null;
			}
		}
	}
}
