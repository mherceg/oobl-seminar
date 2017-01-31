namespace Tracktor.Desktop
{
	partial class PestForm
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
			this.lblPestDialog = new System.Windows.Forms.Label();
			this.btnPestYes = new System.Windows.Forms.Button();
			this.btnPestNo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblPestDialog
			// 
			this.lblPestDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblPestDialog.Location = new System.Drawing.Point(12, 9);
			this.lblPestDialog.Name = "lblPestDialog";
			this.lblPestDialog.Size = new System.Drawing.Size(423, 109);
			this.lblPestDialog.TabIndex = 0;
			this.lblPestDialog.Text = "Pest";
			this.lblPestDialog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnPestYes
			// 
			this.btnPestYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnPestYes.Location = new System.Drawing.Point(232, 121);
			this.btnPestYes.Name = "btnPestYes";
			this.btnPestYes.Size = new System.Drawing.Size(104, 42);
			this.btnPestYes.TabIndex = 2;
			this.btnPestYes.Text = "Yes";
			this.btnPestYes.UseVisualStyleBackColor = true;
			this.btnPestYes.Click += new System.EventHandler(this.btnPestYes_Click);
			// 
			// btnPestNo
			// 
			this.btnPestNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnPestNo.Location = new System.Drawing.Point(95, 121);
			this.btnPestNo.Name = "btnPestNo";
			this.btnPestNo.Size = new System.Drawing.Size(104, 42);
			this.btnPestNo.TabIndex = 1;
			this.btnPestNo.Text = "No";
			this.btnPestNo.UseVisualStyleBackColor = true;
			// 
			// PestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 185);
			this.Controls.Add(this.btnPestNo);
			this.Controls.Add(this.btnPestYes);
			this.Controls.Add(this.lblPestDialog);
			this.Name = "PestForm";
			this.Text = "PestDialog";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblPestDialog;
		private System.Windows.Forms.Button btnPestYes;
		private System.Windows.Forms.Button btnPestNo;
	}
}