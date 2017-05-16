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
			this.tbInstruction = new System.Windows.Forms.TextBox();
			this.lblTextinstruction = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.toolTipInstruction = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// tbInstruction
			// 
			this.tbInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbInstruction.Location = new System.Drawing.Point(12, 24);
			this.tbInstruction.Multiline = true;
			this.tbInstruction.Name = "tbInstruction";
			this.tbInstruction.Size = new System.Drawing.Size(623, 200);
			this.tbInstruction.TabIndex = 0;
			this.toolTipInstruction.SetToolTip(this.tbInstruction, "При необходимости укажите подробности ошибки.\r\nЛибо просто нажмите ОК");
			// 
			// lblTextinstruction
			// 
			this.lblTextinstruction.AutoSize = true;
			this.lblTextinstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblTextinstruction.Location = new System.Drawing.Point(9, 6);
			this.lblTextinstruction.Name = "lblTextinstruction";
			this.lblTextinstruction.Size = new System.Drawing.Size(558, 13);
			this.lblTextinstruction.TabIndex = 1;
			this.lblTextinstruction.Text = "При необходимости введите текст поручения для Заявки универсальной либо нажмите О" +
    "К.";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(454, 230);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "ОК";
			this.toolTipInstruction.SetToolTip(this.btnOK, "Создать заявку в УК ОВА");
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(560, 230);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// instructionInZUn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(647, 261);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.lblTextinstruction);
			this.Controls.Add(this.tbInstruction);
			this.Name = "instructionInZUn";
			this.Text = "Текст поручения для ЗУн";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbInstruction;
		private System.Windows.Forms.Label lblTextinstruction;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ToolTip toolTipInstruction;
	}
}