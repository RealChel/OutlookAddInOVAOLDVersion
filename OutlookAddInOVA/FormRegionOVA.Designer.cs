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
			this.mcIspolnitK = new System.Windows.Forms.MonthCalendar();
			this.tbTextZUn = new System.Windows.Forms.TextBox();
			this.cbCreateZUn = new System.Windows.Forms.CheckBox();
			this.cbImportant = new System.Windows.Forms.CheckBox();
			this.toolTipRegionOVA = new System.Windows.Forms.ToolTip(this.components);
			this.tabOVA = new System.Windows.Forms.TabControl();
			this.tabPageMain = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.cbApproval = new System.Windows.Forms.CheckBox();
			this.tabPageApproval = new System.Windows.Forms.TabPage();
			this.dataGVWapproval = new System.Windows.Forms.DataGridView();
			this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Сотрудник = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Степень = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabOVA.SuspendLayout();
			this.tabPageMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabPageApproval.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGVWapproval)).BeginInit();
			this.SuspendLayout();
			// 
			// mcIspolnitK
			// 
			this.mcIspolnitK.Location = new System.Drawing.Point(9, 34);
			this.mcIspolnitK.Name = "mcIspolnitK";
			this.mcIspolnitK.TabIndex = 0;
			this.toolTipRegionOVA.SetToolTip(this.mcIspolnitK, "Указать желаемую дату выполнения Заявки универсальной");
			// 
			// tbTextZUn
			// 
			this.tbTextZUn.Location = new System.Drawing.Point(204, 34);
			this.tbTextZUn.Multiline = true;
			this.tbTextZUn.Name = "tbTextZUn";
			this.tbTextZUn.Size = new System.Drawing.Size(24, 162);
			this.tbTextZUn.TabIndex = 2;
			this.toolTipRegionOVA.SetToolTip(this.tbTextZUn, "Если ввести в этом поле текст, то только он будет указан в Поручении Заявки униве" +
        "рсальной.\r\nПри этом всё письмо будет прикрепленно к ЗУн");
			// 
			// cbCreateZUn
			// 
			this.cbCreateZUn.AutoSize = true;
			this.cbCreateZUn.Location = new System.Drawing.Point(9, 5);
			this.cbCreateZUn.Name = "cbCreateZUn";
			this.cbCreateZUn.Size = new System.Drawing.Size(144, 17);
			this.cbCreateZUn.TabIndex = 3;
			this.cbCreateZUn.Text = "Создать ЗУн в УК ОВА";
			this.toolTipRegionOVA.SetToolTip(this.cbCreateZUn, "При включении этого флага, на основании письма будет создана Заявка универсальная" +
        "в УК ОВА");
			this.cbCreateZUn.UseVisualStyleBackColor = true;
			// 
			// cbImportant
			// 
			this.cbImportant.AutoSize = true;
			this.cbImportant.Location = new System.Drawing.Point(204, 5);
			this.cbImportant.Name = "cbImportant";
			this.cbImportant.Size = new System.Drawing.Size(62, 17);
			this.cbImportant.TabIndex = 4;
			this.cbImportant.Text = "Срочно";
			this.toolTipRegionOVA.SetToolTip(this.cbImportant, "Указать Срочность заявки");
			this.cbImportant.UseVisualStyleBackColor = true;
			// 
			// tabOVA
			// 
			this.tabOVA.Controls.Add(this.tabPageMain);
			this.tabOVA.Controls.Add(this.tabPageApproval);
			this.tabOVA.Location = new System.Drawing.Point(0, 0);
			this.tabOVA.Name = "tabOVA";
			this.tabOVA.SelectedIndex = 0;
			this.tabOVA.Size = new System.Drawing.Size(814, 222);
			this.tabOVA.TabIndex = 5;
			// 
			// tabPageMain
			// 
			this.tabPageMain.Controls.Add(this.dataGridView1);
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
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(248, 36);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(539, 143);
			this.dataGridView1.TabIndex = 6;
			// 
			// cbApproval
			// 
			this.cbApproval.AutoSize = true;
			this.cbApproval.Location = new System.Drawing.Point(273, 7);
			this.cbApproval.Name = "cbApproval";
			this.cbApproval.Size = new System.Drawing.Size(98, 17);
			this.cbApproval.TabIndex = 5;
			this.cbApproval.Text = "Согласование";
			this.cbApproval.UseVisualStyleBackColor = true;
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
			this.dataGVWapproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGVWapproval.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EMail,
            this.Сотрудник,
            this.Степень});
			this.dataGVWapproval.Location = new System.Drawing.Point(0, 27);
			this.dataGVWapproval.Name = "dataGVWapproval";
			this.dataGVWapproval.Size = new System.Drawing.Size(805, 168);
			this.dataGVWapproval.TabIndex = 0;
			// 
			// EMail
			// 
			this.EMail.HeaderText = "E-Mail";
			this.EMail.Name = "EMail";
			// 
			// Сотрудник
			// 
			this.Сотрудник.HeaderText = "Сотрудник";
			this.Сотрудник.Name = "Сотрудник";
			// 
			// Степень
			// 
			this.Степень.HeaderText = "Степень";
			this.Степень.Name = "Степень";
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
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabPageApproval.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGVWapproval)).EndInit();
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
		private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
		private System.Windows.Forms.DataGridViewTextBoxColumn Сотрудник;
		private System.Windows.Forms.DataGridViewTextBoxColumn Степень;
		private System.Windows.Forms.DataGridView dataGridView1;

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
