namespace Tracktor.Desktop
{
	partial class CRUD_Information
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
			this.btnUserCrudOK = new System.Windows.Forms.Button();
			this.btnUserCrudCancel = new System.Windows.Forms.Button();
			this.tbInfoCrudID = new System.Windows.Forms.TextBox();
			this.lblInfoCrudID = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnUserCrudOK
			// 
			this.btnUserCrudOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnUserCrudOK.Location = new System.Drawing.Point(216, 324);
			this.btnUserCrudOK.Name = "btnUserCrudOK";
			this.btnUserCrudOK.Size = new System.Drawing.Size(90, 30);
			this.btnUserCrudOK.TabIndex = 19;
			this.btnUserCrudOK.Text = "OK";
			this.btnUserCrudOK.UseVisualStyleBackColor = true;
			// 
			// btnUserCrudCancel
			// 
			this.btnUserCrudCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnUserCrudCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnUserCrudCancel.Location = new System.Drawing.Point(122, 324);
			this.btnUserCrudCancel.Name = "btnUserCrudCancel";
			this.btnUserCrudCancel.Size = new System.Drawing.Size(90, 30);
			this.btnUserCrudCancel.TabIndex = 18;
			this.btnUserCrudCancel.Text = "Cancel";
			this.btnUserCrudCancel.UseVisualStyleBackColor = true;
			// 
			// tbInfoCrudID
			// 
			this.tbInfoCrudID.Enabled = false;
			this.tbInfoCrudID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbInfoCrudID.Location = new System.Drawing.Point(137, 12);
			this.tbInfoCrudID.Name = "tbInfoCrudID";
			this.tbInfoCrudID.Size = new System.Drawing.Size(169, 26);
			this.tbInfoCrudID.TabIndex = 21;
			this.tbInfoCrudID.Text = "Test tekst";
			// 
			// lblInfoCrudID
			// 
			this.lblInfoCrudID.AutoSize = true;
			this.lblInfoCrudID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblInfoCrudID.Location = new System.Drawing.Point(19, 15);
			this.lblInfoCrudID.Name = "lblInfoCrudID";
			this.lblInfoCrudID.Size = new System.Drawing.Size(36, 20);
			this.lblInfoCrudID.TabIndex = 20;
			this.lblInfoCrudID.Text = "ID: ";
			// 
			// CRUD_Information
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(496, 438);
			this.Controls.Add(this.tbInfoCrudID);
			this.Controls.Add(this.lblInfoCrudID);
			this.Controls.Add(this.btnUserCrudOK);
			this.Controls.Add(this.btnUserCrudCancel);
			this.Name = "CRUD_Information";
			this.Text = "CRUD_Information";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnUserCrudOK;
		private System.Windows.Forms.Button btnUserCrudCancel;
		private System.Windows.Forms.TextBox tbInfoCrudID;
		private System.Windows.Forms.Label lblInfoCrudID;
	}
}