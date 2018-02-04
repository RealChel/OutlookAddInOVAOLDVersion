namespace OutlookAddInOVA
{
	partial class InstructionInZUn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionInZUn));
            this.toolTipInstruction = new System.Windows.Forms.ToolTip(this.components);
            this.tbInstruction = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabControlZUn = new System.Windows.Forms.TabControl();
            this.tabPageInstruction = new System.Windows.Forms.TabPage();
            this.tabPageOVA = new System.Windows.Forms.TabPage();
            this.tbCommentToExecutor = new System.Windows.Forms.TextBox();
            this.labelExecutor = new System.Windows.Forms.Label();
            this.comboBoxExecutor = new System.Windows.Forms.ComboBox();
            this.tabPageApproved = new System.Windows.Forms.TabPage();
            this.dataGVWapproval = new System.Windows.Forms.DataGridView();
            this.CoWorker = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Degree = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControlZUn.SuspendLayout();
            this.tabPageInstruction.SuspendLayout();
            this.tabPageOVA.SuspendLayout();
            this.tabPageApproved.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVWapproval)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInstruction
            // 
            this.tbInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInstruction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInstruction.Location = new System.Drawing.Point(3, 3);
            this.tbInstruction.Multiline = true;
            this.tbInstruction.Name = "tbInstruction";
            this.tbInstruction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInstruction.Size = new System.Drawing.Size(662, 172);
            this.tbInstruction.TabIndex = 1;
            this.toolTipInstruction.SetToolTip(this.tbInstruction, "В этом поле можно указать дополнительную информацию о возникшей ситуации,\r\nэтот т" +
        "екст будет добавлен в текст поручения Заявки универсальной.");
            this.tbInstruction.TextChanged += new System.EventHandler(this.tbInstruction_TextChanged);
            this.tbInstruction.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInstruction_KeyDown);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(519, 206);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "ОК";
            this.toolTipInstruction.SetToolTip(this.btnOK, "Создать заявку в УК ОВА");
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tabControlZUn
            // 
            this.tabControlZUn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlZUn.Controls.Add(this.tabPageInstruction);
            this.tabControlZUn.Controls.Add(this.tabPageOVA);
            this.tabControlZUn.Controls.Add(this.tabPageApproved);
            this.tabControlZUn.Location = new System.Drawing.Point(0, 0);
            this.tabControlZUn.Name = "tabControlZUn";
            this.tabControlZUn.SelectedIndex = 0;
            this.tabControlZUn.Size = new System.Drawing.Size(679, 204);
            this.tabControlZUn.TabIndex = 6;
            // 
            // tabPageInstruction
            // 
            this.tabPageInstruction.Controls.Add(this.tbInstruction);
            this.tabPageInstruction.Location = new System.Drawing.Point(4, 22);
            this.tabPageInstruction.Name = "tabPageInstruction";
            this.tabPageInstruction.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInstruction.Size = new System.Drawing.Size(671, 178);
            this.tabPageInstruction.TabIndex = 0;
            this.tabPageInstruction.Text = "Поручение";
            this.tabPageInstruction.UseVisualStyleBackColor = true;
            // 
            // tabPageOVA
            // 
            this.tabPageOVA.Controls.Add(this.tbCommentToExecutor);
            this.tabPageOVA.Controls.Add(this.labelExecutor);
            this.tabPageOVA.Controls.Add(this.comboBoxExecutor);
            this.tabPageOVA.Location = new System.Drawing.Point(4, 22);
            this.tabPageOVA.Name = "tabPageOVA";
            this.tabPageOVA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOVA.Size = new System.Drawing.Size(671, 178);
            this.tabPageOVA.TabIndex = 1;
            this.tabPageOVA.Text = "OVA";
            this.tabPageOVA.UseVisualStyleBackColor = true;
            // 
            // tbCommentToExecutor
            // 
            this.tbCommentToExecutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCommentToExecutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCommentToExecutor.Location = new System.Drawing.Point(10, 28);
            this.tbCommentToExecutor.Multiline = true;
            this.tbCommentToExecutor.Name = "tbCommentToExecutor";
            this.tbCommentToExecutor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCommentToExecutor.Size = new System.Drawing.Size(655, 147);
            this.tbCommentToExecutor.TabIndex = 8;
            this.tbCommentToExecutor.Text = "При необходимости укажите текст поручения Исполнителю ЗУн\r\n";
            this.tbCommentToExecutor.TextChanged += new System.EventHandler(this.tbCommentToExecutor_TextChanged);
            this.tbCommentToExecutor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCommentToExecutor_KeyDown);
            // 
            // labelExecutor
            // 
            this.labelExecutor.AutoSize = true;
            this.labelExecutor.Location = new System.Drawing.Point(7, 7);
            this.labelExecutor.Name = "labelExecutor";
            this.labelExecutor.Size = new System.Drawing.Size(77, 13);
            this.labelExecutor.TabIndex = 7;
            this.labelExecutor.Text = "Исполнитель:";
            // 
            // comboBoxExecutor
            // 
            this.comboBoxExecutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxExecutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxExecutor.CausesValidation = false;
            this.comboBoxExecutor.DisplayMember = "FIO";
            this.comboBoxExecutor.FormattingEnabled = true;
            this.comboBoxExecutor.Location = new System.Drawing.Point(90, 4);
            this.comboBoxExecutor.Name = "comboBoxExecutor";
            this.comboBoxExecutor.Size = new System.Drawing.Size(209, 21);
            this.comboBoxExecutor.TabIndex = 6;
            this.comboBoxExecutor.ValueMember = "EMail";
            this.comboBoxExecutor.SelectionChangeCommitted += new System.EventHandler(this.comboBoxExecutor_SelectionChangeCommitted);
            // 
            // tabPageApproved
            // 
            this.tabPageApproved.Controls.Add(this.dataGVWapproval);
            this.tabPageApproved.Location = new System.Drawing.Point(4, 22);
            this.tabPageApproved.Name = "tabPageApproved";
            this.tabPageApproved.Size = new System.Drawing.Size(671, 178);
            this.tabPageApproved.TabIndex = 2;
            this.tabPageApproved.Text = "Согласование";
            this.tabPageApproved.UseVisualStyleBackColor = true;
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
            this.dataGVWapproval.Size = new System.Drawing.Size(671, 178);
            this.dataGVWapproval.TabIndex = 1;
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
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(600, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // InstructionInZUn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 234);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabControlZUn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstructionInZUn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Текст поручения для ЗУн";
            this.Shown += new System.EventHandler(this.instructionInZUn_Shown);
            this.tabControlZUn.ResumeLayout(false);
            this.tabPageInstruction.ResumeLayout(false);
            this.tabPageInstruction.PerformLayout();
            this.tabPageOVA.ResumeLayout(false);
            this.tabPageOVA.PerformLayout();
            this.tabPageApproved.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVWapproval)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ToolTip toolTipInstruction;
        private System.Windows.Forms.TabControl tabControlZUn;
        private System.Windows.Forms.TabPage tabPageInstruction;
        private System.Windows.Forms.TextBox tbInstruction;
        private System.Windows.Forms.TabPage tabPageOVA;
        private System.Windows.Forms.Label labelExecutor;
        private System.Windows.Forms.ComboBox comboBoxExecutor;
        private System.Windows.Forms.TabPage tabPageApproved;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dataGVWapproval;
        private System.Windows.Forms.DataGridViewComboBoxColumn CoWorker;
        private System.Windows.Forms.DataGridViewComboBoxColumn Degree;
        private System.Windows.Forms.TextBox tbCommentToExecutor;
    }
}