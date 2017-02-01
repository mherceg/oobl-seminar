namespace Tracktor.Desktop
{
	partial class CRUD_User
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
			this.lblUserCrudName = new System.Windows.Forms.Label();
			this.tbUserCrudName = new System.Windows.Forms.TextBox();
			this.tbUserCrudFullName = new System.Windows.Forms.TextBox();
			this.lblUserCrudFullName = new System.Windows.Forms.Label();
			this.lblUserCrudType = new System.Windows.Forms.Label();
			this.rbUserCrudTypeReg = new System.Windows.Forms.RadioButton();
			this.rbUserCrudTypePrem = new System.Windows.Forms.RadioButton();
			this.rbUserCrudTypeAdmin = new System.Windows.Forms.RadioButton();
			this.btnUserCrudCancel = new System.Windows.Forms.Button();
			this.btnUserCrudOK = new System.Windows.Forms.Button();
			this.tbUserCrudUID = new System.Windows.Forms.TextBox();
			this.lblUserCrudUID = new System.Windows.Forms.Label();
			this.cbUserCrudActive = new System.Windows.Forms.CheckBox();
			this.tbUserCrudPass = new System.Windows.Forms.TextBox();
			this.lblUserCrudPass = new System.Windows.Forms.Label();
			this.lblUserCrudError = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblUserCrudName
			// 
			this.lblUserCrudName.AutoSize = true;
			this.lblUserCrudName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblUserCrudName.Location = new System.Drawing.Point(29, 57);
			this.lblUserCrudName.Name = "lblUserCrudName";
			this.lblUserCrudName.Size = new System.Drawing.Size(96, 20);
			this.lblUserCrudName.TabIndex = 0;
			this.lblUserCrudName.Text = "Username: ";
			// 
			// tbUserCrudName
			// 
			this.tbUserCrudName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbUserCrudName.Location = new System.Drawing.Point(147, 57);
			this.tbUserCrudName.Name = "tbUserCrudName";
			this.tbUserCrudName.Size = new System.Drawing.Size(194, 26);
			this.tbUserCrudName.TabIndex = 1;
			// 
			// tbUserCrudFullName
			// 
			this.tbUserCrudFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbUserCrudFullName.Location = new System.Drawing.Point(147, 102);
			this.tbUserCrudFullName.Name = "tbUserCrudFullName";
			this.tbUserCrudFullName.Size = new System.Drawing.Size(194, 26);
			this.tbUserCrudFullName.TabIndex = 3;
			// 
			// lblUserCrudFullName
			// 
			this.lblUserCrudFullName.AutoSize = true;
			this.lblUserCrudFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblUserCrudFullName.Location = new System.Drawing.Point(29, 102);
			this.lblUserCrudFullName.Name = "lblUserCrudFullName";
			this.lblUserCrudFullName.Size = new System.Drawing.Size(87, 20);
			this.lblUserCrudFullName.TabIndex = 2;
			this.lblUserCrudFullName.Text = "Full name:";
			// 
			// lblUserCrudType
			// 
			this.lblUserCrudType.AutoSize = true;
			this.lblUserCrudType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblUserCrudType.Location = new System.Drawing.Point(29, 206);
			this.lblUserCrudType.Name = "lblUserCrudType";
			this.lblUserCrudType.Size = new System.Drawing.Size(91, 20);
			this.lblUserCrudType.TabIndex = 4;
			this.lblUserCrudType.Text = "User type: ";
			// 
			// rbUserCrudTypeReg
			// 
			this.rbUserCrudTypeReg.AutoSize = true;
			this.rbUserCrudTypeReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rbUserCrudTypeReg.Location = new System.Drawing.Point(147, 202);
			this.rbUserCrudTypeReg.Name = "rbUserCrudTypeReg";
			this.rbUserCrudTypeReg.Size = new System.Drawing.Size(88, 24);
			this.rbUserCrudTypeReg.TabIndex = 5;
			this.rbUserCrudTypeReg.TabStop = true;
			this.rbUserCrudTypeReg.Text = "Regular";
			this.rbUserCrudTypeReg.UseVisualStyleBackColor = true;
			// 
			// rbUserCrudTypePrem
			// 
			this.rbUserCrudTypePrem.AutoSize = true;
			this.rbUserCrudTypePrem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rbUserCrudTypePrem.Location = new System.Drawing.Point(147, 231);
			this.rbUserCrudTypePrem.Name = "rbUserCrudTypePrem";
			this.rbUserCrudTypePrem.Size = new System.Drawing.Size(97, 24);
			this.rbUserCrudTypePrem.TabIndex = 6;
			this.rbUserCrudTypePrem.TabStop = true;
			this.rbUserCrudTypePrem.Text = "Premium";
			this.rbUserCrudTypePrem.UseVisualStyleBackColor = true;
			// 
			// rbUserCrudTypeAdmin
			// 
			this.rbUserCrudTypeAdmin.AutoSize = true;
			this.rbUserCrudTypeAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rbUserCrudTypeAdmin.Location = new System.Drawing.Point(147, 260);
			this.rbUserCrudTypeAdmin.Name = "rbUserCrudTypeAdmin";
			this.rbUserCrudTypeAdmin.Size = new System.Drawing.Size(130, 24);
			this.rbUserCrudTypeAdmin.TabIndex = 7;
			this.rbUserCrudTypeAdmin.TabStop = true;
			this.rbUserCrudTypeAdmin.Text = "Administrator";
			this.rbUserCrudTypeAdmin.UseVisualStyleBackColor = true;
			// 
			// btnUserCrudCancel
			// 
			this.btnUserCrudCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnUserCrudCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnUserCrudCancel.Location = new System.Drawing.Point(147, 357);
			this.btnUserCrudCancel.Name = "btnUserCrudCancel";
			this.btnUserCrudCancel.Size = new System.Drawing.Size(97, 30);
			this.btnUserCrudCancel.TabIndex = 8;
			this.btnUserCrudCancel.Text = "Cancel";
			this.btnUserCrudCancel.UseVisualStyleBackColor = true;
			this.btnUserCrudCancel.Click += new System.EventHandler(this.btnUserCrudCancel_Click);
			// 
			// btnUserCrudOK
			// 
			this.btnUserCrudOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnUserCrudOK.Location = new System.Drawing.Point(244, 357);
			this.btnUserCrudOK.Name = "btnUserCrudOK";
			this.btnUserCrudOK.Size = new System.Drawing.Size(97, 30);
			this.btnUserCrudOK.TabIndex = 9;
			this.btnUserCrudOK.Text = "OK";
			this.btnUserCrudOK.UseVisualStyleBackColor = true;
			this.btnUserCrudOK.Click += new System.EventHandler(this.btnUserCrudOK_Click);
			// 
			// tbUserCrudUID
			// 
			this.tbUserCrudUID.Enabled = false;
			this.tbUserCrudUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbUserCrudUID.Location = new System.Drawing.Point(147, 12);
			this.tbUserCrudUID.Name = "tbUserCrudUID";
			this.tbUserCrudUID.Size = new System.Drawing.Size(194, 26);
			this.tbUserCrudUID.TabIndex = 11;
			this.tbUserCrudUID.Text = "Test tekst";
			// 
			// lblUserCrudUID
			// 
			this.lblUserCrudUID.AutoSize = true;
			this.lblUserCrudUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblUserCrudUID.Location = new System.Drawing.Point(29, 12);
			this.lblUserCrudUID.Name = "lblUserCrudUID";
			this.lblUserCrudUID.Size = new System.Drawing.Size(36, 20);
			this.lblUserCrudUID.TabIndex = 10;
			this.lblUserCrudUID.Text = "ID: ";
			// 
			// cbUserCrudActive
			// 
			this.cbUserCrudActive.AutoSize = true;
			this.cbUserCrudActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.cbUserCrudActive.Location = new System.Drawing.Point(147, 302);
			this.cbUserCrudActive.Name = "cbUserCrudActive";
			this.cbUserCrudActive.Size = new System.Drawing.Size(77, 24);
			this.cbUserCrudActive.TabIndex = 8;
			this.cbUserCrudActive.Text = "Active";
			this.cbUserCrudActive.UseVisualStyleBackColor = true;
			// 
			// tbUserCrudPass
			// 
			this.tbUserCrudPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbUserCrudPass.Location = new System.Drawing.Point(147, 146);
			this.tbUserCrudPass.Name = "tbUserCrudPass";
			this.tbUserCrudPass.PasswordChar = '*';
			this.tbUserCrudPass.Size = new System.Drawing.Size(194, 26);
			this.tbUserCrudPass.TabIndex = 4;
			// 
			// lblUserCrudPass
			// 
			this.lblUserCrudPass.AutoSize = true;
			this.lblUserCrudPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblUserCrudPass.Location = new System.Drawing.Point(29, 146);
			this.lblUserCrudPass.Name = "lblUserCrudPass";
			this.lblUserCrudPass.Size = new System.Drawing.Size(93, 20);
			this.lblUserCrudPass.TabIndex = 14;
			this.lblUserCrudPass.Text = "Password: ";
			// 
			// lblUserCrudError
			// 
			this.lblUserCrudError.BackColor = System.Drawing.SystemColors.Info;
			this.lblUserCrudError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblUserCrudError.Location = new System.Drawing.Point(46, 404);
			this.lblUserCrudError.Name = "lblUserCrudError";
			this.lblUserCrudError.Size = new System.Drawing.Size(325, 99);
			this.lblUserCrudError.TabIndex = 53;
			this.lblUserCrudError.Text = "Error";
			this.lblUserCrudError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblUserCrudError.Visible = false;
			// 
			// CRUD_User
			// 
			this.AcceptButton = this.btnUserCrudOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnUserCrudCancel;
			this.ClientSize = new System.Drawing.Size(402, 512);
			this.Controls.Add(this.lblUserCrudError);
			this.Controls.Add(this.tbUserCrudPass);
			this.Controls.Add(this.lblUserCrudPass);
			this.Controls.Add(this.cbUserCrudActive);
			this.Controls.Add(this.tbUserCrudUID);
			this.Controls.Add(this.lblUserCrudUID);
			this.Controls.Add(this.btnUserCrudOK);
			this.Controls.Add(this.btnUserCrudCancel);
			this.Controls.Add(this.rbUserCrudTypeAdmin);
			this.Controls.Add(this.rbUserCrudTypePrem);
			this.Controls.Add(this.rbUserCrudTypeReg);
			this.Controls.Add(this.lblUserCrudType);
			this.Controls.Add(this.tbUserCrudFullName);
			this.Controls.Add(this.lblUserCrudFullName);
			this.Controls.Add(this.tbUserCrudName);
			this.Controls.Add(this.lblUserCrudName);
			this.Name = "CRUD_User";
			this.Text = "User Details";
			this.Load += new System.EventHandler(this.CRUDUser_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblUserCrudName;
		private System.Windows.Forms.TextBox tbUserCrudName;
		private System.Windows.Forms.TextBox tbUserCrudFullName;
		private System.Windows.Forms.Label lblUserCrudFullName;
		private System.Windows.Forms.Label lblUserCrudType;
		private System.Windows.Forms.RadioButton rbUserCrudTypeReg;
		private System.Windows.Forms.RadioButton rbUserCrudTypePrem;
		private System.Windows.Forms.RadioButton rbUserCrudTypeAdmin;
		private System.Windows.Forms.Button btnUserCrudCancel;
		private System.Windows.Forms.Button btnUserCrudOK;
		private System.Windows.Forms.TextBox tbUserCrudUID;
		private System.Windows.Forms.Label lblUserCrudUID;
		private System.Windows.Forms.CheckBox cbUserCrudActive;
		private System.Windows.Forms.TextBox tbUserCrudPass;
		private System.Windows.Forms.Label lblUserCrudPass;
		private System.Windows.Forms.Label lblUserCrudError;
	}
}