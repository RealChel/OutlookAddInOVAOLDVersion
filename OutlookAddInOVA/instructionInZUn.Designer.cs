namespace OutlookAddInOVA
{
	partial class instructionInZUn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(instructionInZUn));
            this.tbInstruction = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTipInstruction = new System.Windows.Forms.ToolTip(this.components);
            this.labelExecutor = new System.Windows.Forms.Label();
            this.comboBoxExecutor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbInstruction
            // 
            this.tbInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInstruction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInstruction.Location = new System.Drawing.Point(1, 32);
            this.tbInstruction.Multiline = true;
            this.tbInstruction.Name = "tbInstruction";
            this.tbInstruction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInstruction.Size = new System.Drawing.Size(683, 199);
            this.tbInstruction.TabIndex = 0;
            this.toolTipInstruction.SetToolTip(this.tbInstruction, "В этом поле можно указать дополнительную информацию о возникшей ситуации,\r\nэтот т" +
        "екст будет добавлен в текст поручения Заявки универсальной.");
            this.tbInstruction.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInstruction_KeyDown);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(504, 202);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "ОК";
            this.toolTipInstruction.SetToolTip(this.btnOK, "Создать заявку в УК ОВА");
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(585, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelExecutor
            // 
            this.labelExecutor.AutoSize = true;
            this.labelExecutor.Location = new System.Drawing.Point(4, 9);
            this.labelExecutor.Name = "labelExecutor";
            this.labelExecutor.Size = new System.Drawing.Size(77, 13);
            this.labelExecutor.TabIndex = 5;
            this.labelExecutor.Text = "Исполнитель:";
            // 
            // comboBoxExecutor
            // 
            this.comboBoxExecutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxExecutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxExecutor.CausesValidation = false;
            this.comboBoxExecutor.DisplayMember = "FIO";
            this.comboBoxExecutor.FormattingEnabled = true;
            this.comboBoxExecutor.Location = new System.Drawing.Point(87, 5);
            this.comboBoxExecutor.Name = "comboBoxExecutor";
            this.comboBoxExecutor.Size = new System.Drawing.Size(209, 21);
            this.comboBoxExecutor.TabIndex = 4;
            this.comboBoxExecutor.ValueMember = "EMail";
            this.comboBoxExecutor.SelectionChangeCommitted += new System.EventHandler(this.comboBoxExecutor_SelectionChangeCommitted);
            // 
            // instructionInZUn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(683, 234);
            this.Controls.Add(this.labelExecutor);
            this.Controls.Add(this.comboBoxExecutor);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbInstruction);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "instructionInZUn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Текст поручения для ЗУн";
            this.Shown += new System.EventHandler(this.instructionInZUn_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbInstruction;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ToolTip toolTipInstruction;
        private System.Windows.Forms.Label labelExecutor;
        private System.Windows.Forms.ComboBox comboBoxExecutor;
    }
}