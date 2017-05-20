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
			this.SuspendLayout();
			// 
			// tbInstruction
			// 
			this.tbInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbInstruction.Location = new System.Drawing.Point(0, 0);
			this.tbInstruction.Multiline = true;
			this.tbInstruction.Name = "tbInstruction";
			this.tbInstruction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbInstruction.Size = new System.Drawing.Size(683, 198);
			this.tbInstruction.TabIndex = 0;
			this.toolTipInstruction.SetToolTip(this.tbInstruction, "В этом поле можно указать дополнительную информацию о возникшей ситуации,\r\nэтот т" +
        "екст будет добавлен в текст поручения Заявки универсальной.");
			this.tbInstruction.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInstruction_KeyDown);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(504, 174);
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
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(585, 174);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// instructionInZUn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(683, 199);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.tbInstruction);
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
	}
}