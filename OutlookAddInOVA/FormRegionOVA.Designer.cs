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
			this.SuspendLayout();
			// 
			// mcIspolnitK
			// 
			this.mcIspolnitK.Location = new System.Drawing.Point(9, 53);
			this.mcIspolnitK.Name = "mcIspolnitK";
			this.mcIspolnitK.TabIndex = 0;
			this.toolTipRegionOVA.SetToolTip(this.mcIspolnitK, "Указать желаемую дату выполнения Заявки универсальной");
			// 
			// tbTextZUn
			// 
			this.tbTextZUn.Location = new System.Drawing.Point(204, 53);
			this.tbTextZUn.Multiline = true;
			this.tbTextZUn.Name = "tbTextZUn";
			this.tbTextZUn.Size = new System.Drawing.Size(528, 162);
			this.tbTextZUn.TabIndex = 2;
			this.toolTipRegionOVA.SetToolTip(this.tbTextZUn, "Если ввести в этом поле текст, то только он будет указан в Поручении Заявки униве" +
        "рсальной.\r\nПри этом всё письмо будет прикрепленно к ЗУн");
			// 
			// cbCreateZUn
			// 
			this.cbCreateZUn.AutoSize = true;
			this.cbCreateZUn.Location = new System.Drawing.Point(9, 24);
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
			this.cbImportant.Location = new System.Drawing.Point(204, 24);
			this.cbImportant.Name = "cbImportant";
			this.cbImportant.Size = new System.Drawing.Size(62, 17);
			this.cbImportant.TabIndex = 4;
			this.cbImportant.Text = "Срочно";
			this.toolTipRegionOVA.SetToolTip(this.cbImportant, "Указать Срочность заявки");
			this.cbImportant.UseVisualStyleBackColor = true;
			// 
			// FormRegionOVA
			// 
			this.AccessibleName = "";
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.cbImportant);
			this.Controls.Add(this.cbCreateZUn);
			this.Controls.Add(this.tbTextZUn);
			this.Controls.Add(this.mcIspolnitK);
			this.Name = "FormRegionOVA";
			this.Size = new System.Drawing.Size(821, 227);
			this.toolTipRegionOVA.SetToolTip(this, "В этой области вводятся дополнительные данные для создания Заявки универсальной в" +
        " УК ОВА");
			this.FormRegionShowing += new System.EventHandler(this.FormRegionOVA_FormRegionShowing);
			this.FormRegionClosed += new System.EventHandler(this.FormRegionOVA_FormRegionClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

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
