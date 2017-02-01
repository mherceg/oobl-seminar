namespace Tracktor.Desktop.CRUD_Forms
{
	partial class CRUD_UserType
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
			this.btnUTCrudOK = new System.Windows.Forms.Button();
			this.btnUTCrudCancel = new System.Windows.Forms.Button();
			this.tbUTCrudID = new System.Windows.Forms.TextBox();
			this.lblUTCrudID = new System.Windows.Forms.Label();
			this.tbUTCrudType = new System.Windows.Forms.TextBox();
			this.lblUTCrudName = new System.Windows.Forms.Label();
			this.lblUTCrudError = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnUTCrudOK
			// 
			this.btnUTCrudOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnUTCrudOK.Location = new System.Drawing.Point(218, 116);
			this.btnUTCrudOK.Name = "btnUTCrudOK";
			this.btnUTCrudOK.Size = new System.Drawing.Size(97, 30);
			this.btnUTCrudOK.TabIndex = 36;
			this.btnUTCrudOK.Text = "OK";
			this.btnUTCrudOK.UseVisualStyleBackColor = true;
			this.btnUTCrudOK.Click += new System.EventHandler(this.btnUTCrudOK_Click);
			// 
			// btnUTCrudCancel
			// 
			this.btnUTCrudCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnUTCrudCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnUTCrudCancel.Location = new System.Drawing.Point(121, 116);
			this.btnUTCrudCancel.Name = "btnUTCrudCancel";
			this.btnUTCrudCancel.Size = new System.Drawing.Size(97, 30);
			this.btnUTCrudCancel.TabIndex = 35;
			this.btnUTCrudCancel.Text = "Cancel";
			this.btnUTCrudCancel.UseVisualStyleBackColor = true;
			this.btnUTCrudCancel.Click += new System.EventHandler(this.btnUTCrudCancel_Click);
			// 
			// tbUTCrudID
			// 
			this.tbUTCrudID.Enabled = false;
			this.tbUTCrudID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbUTCrudID.Location = new System.Drawing.Point(121, 12);
			this.tbUTCrudID.Name = "tbUTCrudID";
			this.tbUTCrudID.Size = new System.Drawing.Size(194, 26);
			this.tbUTCrudID.TabIndex = 34;
			// 
			// lblUTCrudID
			// 
			this.lblUTCrudID.AutoSize = true;
			this.lblUTCrudID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblUTCrudID.Location = new System.Drawing.Point(12, 18);
			this.lblUTCrudID.Name = "lblUTCrudID";
			this.lblUTCrudID.Size = new System.Drawing.Size(31, 20);
			this.lblUTCrudID.TabIndex = 33;
			this.lblUTCrudID.Text = "ID:";
			// 
			// tbUTCrudName
			// 
			this.tbUTCrudType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbUTCrudType.Location = new System.Drawing.Point(121, 66);
			this.tbUTCrudType.Name = "tbUTCrudName";
			this.tbUTCrudType.Size = new System.Drawing.Size(194, 26);
			this.tbUTCrudType.TabIndex = 32;
			// 
			// lblUTCrudName
			// 
			this.lblUTCrudName.AutoSize = true;
			this.lblUTCrudName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblUTCrudName.Location = new System.Drawing.Point(12, 66);
			this.lblUTCrudName.Name = "lblUTCrudName";
			this.lblUTCrudName.Size = new System.Drawing.Size(91, 20);
			this.lblUTCrudName.TabIndex = 31;
			this.lblUTCrudName.Text = "User Type:";
			// 
			// lblUTCrudError
			// 
			this.lblUTCrudError.BackColor = System.Drawing.SystemColors.Info;
			this.lblUTCrudError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblUTCrudError.Location = new System.Drawing.Point(12, 163);
			this.lblUTCrudError.Name = "lblUTCrudError";
			this.lblUTCrudError.Size = new System.Drawing.Size(325, 99);
			this.lblUTCrudError.TabIndex = 38;
			this.lblUTCrudError.Text = "Error";
			this.lblUTCrudError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblUTCrudError.Visible = false;
			// 
			// CRUD_UserType
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 271);
			this.Controls.Add(this.lblUTCrudError);
			this.Controls.Add(this.btnUTCrudOK);
			this.Controls.Add(this.btnUTCrudCancel);
			this.Controls.Add(this.tbUTCrudID);
			this.Controls.Add(this.lblUTCrudID);
			this.Controls.Add(this.tbUTCrudType);
			this.Controls.Add(this.lblUTCrudName);
			this.Name = "CRUD_UserType";
			this.Text = "CRUD_UserType";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnUTCrudOK;
		private System.Windows.Forms.Button btnUTCrudCancel;
		private System.Windows.Forms.TextBox tbUTCrudID;
		private System.Windows.Forms.Label lblUTCrudID;
		private System.Windows.Forms.TextBox tbUTCrudType;
		private System.Windows.Forms.Label lblUTCrudName;
		private System.Windows.Forms.Label lblUTCrudError;
	}
}