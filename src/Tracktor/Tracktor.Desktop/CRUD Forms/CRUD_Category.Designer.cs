namespace Tracktor.Desktop.CRUD_Forms
{
	partial class CRUD_Category
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
			this.tbCategoryCrudID = new System.Windows.Forms.TextBox();
			this.lblPlaceCrudID = new System.Windows.Forms.Label();
			this.tbCategoryCrudName = new System.Windows.Forms.TextBox();
			this.lblCatCrudName = new System.Windows.Forms.Label();
			this.lblCategoryCrudError = new System.Windows.Forms.Label();
			this.btnCategoryCrudOK = new System.Windows.Forms.Button();
			this.btnCategoryCrudCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbCategoryCrudID
			// 
			this.tbCategoryCrudID.Enabled = false;
			this.tbCategoryCrudID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbCategoryCrudID.Location = new System.Drawing.Point(145, 9);
			this.tbCategoryCrudID.Name = "tbCategoryCrudID";
			this.tbCategoryCrudID.Size = new System.Drawing.Size(179, 26);
			this.tbCategoryCrudID.TabIndex = 27;
			// 
			// lblPlaceCrudID
			// 
			this.lblPlaceCrudID.AutoSize = true;
			this.lblPlaceCrudID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblPlaceCrudID.Location = new System.Drawing.Point(108, 15);
			this.lblPlaceCrudID.Name = "lblPlaceCrudID";
			this.lblPlaceCrudID.Size = new System.Drawing.Size(31, 20);
			this.lblPlaceCrudID.TabIndex = 26;
			this.lblPlaceCrudID.Text = "ID:";
			// 
			// tbCategoryCrudName
			// 
			this.tbCategoryCrudName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbCategoryCrudName.Location = new System.Drawing.Point(145, 55);
			this.tbCategoryCrudName.Name = "tbCategoryCrudName";
			this.tbCategoryCrudName.Size = new System.Drawing.Size(179, 26);
			this.tbCategoryCrudName.TabIndex = 23;
			// 
			// lblCatCrudName
			// 
			this.lblCatCrudName.AutoSize = true;
			this.lblCatCrudName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblCatCrudName.Location = new System.Drawing.Point(12, 55);
			this.lblCatCrudName.Name = "lblCatCrudName";
			this.lblCatCrudName.Size = new System.Drawing.Size(127, 20);
			this.lblCatCrudName.TabIndex = 22;
			this.lblCatCrudName.Text = "Category name:";
			// 
			// lblCategoryCrudError
			// 
			this.lblCategoryCrudError.AutoSize = true;
			this.lblCategoryCrudError.BackColor = System.Drawing.SystemColors.Info;
			this.lblCategoryCrudError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblCategoryCrudError.Location = new System.Drawing.Point(12, 158);
			this.lblCategoryCrudError.Name = "lblCategoryCrudError";
			this.lblCategoryCrudError.Size = new System.Drawing.Size(47, 20);
			this.lblCategoryCrudError.TabIndex = 30;
			this.lblCategoryCrudError.Text = "Error";
			this.lblCategoryCrudError.Visible = false;
			// 
			// btnCategoryCrudOK
			// 
			this.btnCategoryCrudOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnCategoryCrudOK.Location = new System.Drawing.Point(227, 123);
			this.btnCategoryCrudOK.Name = "btnCategoryCrudOK";
			this.btnCategoryCrudOK.Size = new System.Drawing.Size(97, 30);
			this.btnCategoryCrudOK.TabIndex = 29;
			this.btnCategoryCrudOK.Text = "OK";
			this.btnCategoryCrudOK.UseVisualStyleBackColor = true;
			this.btnCategoryCrudOK.Click += new System.EventHandler(this.btnCategoryCrudOK_Click);
			// 
			// btnCategoryCrudCancel
			// 
			this.btnCategoryCrudCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCategoryCrudCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnCategoryCrudCancel.Location = new System.Drawing.Point(130, 123);
			this.btnCategoryCrudCancel.Name = "btnCategoryCrudCancel";
			this.btnCategoryCrudCancel.Size = new System.Drawing.Size(97, 30);
			this.btnCategoryCrudCancel.TabIndex = 28;
			this.btnCategoryCrudCancel.Text = "Cancel";
			this.btnCategoryCrudCancel.UseVisualStyleBackColor = true;
			this.btnCategoryCrudCancel.Click += new System.EventHandler(this.btnCategoryCrudCancel_Click);
			// 
			// CRUD_Category
			// 
			this.AcceptButton = this.btnCategoryCrudOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCategoryCrudCancel;
			this.ClientSize = new System.Drawing.Size(368, 197);
			this.Controls.Add(this.lblCategoryCrudError);
			this.Controls.Add(this.btnCategoryCrudOK);
			this.Controls.Add(this.btnCategoryCrudCancel);
			this.Controls.Add(this.tbCategoryCrudID);
			this.Controls.Add(this.lblPlaceCrudID);
			this.Controls.Add(this.tbCategoryCrudName);
			this.Controls.Add(this.lblCatCrudName);
			this.Name = "CRUD_Category";
			this.Text = "CRUD_Category";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox tbCategoryCrudID;
		private System.Windows.Forms.Label lblPlaceCrudID;
		private System.Windows.Forms.TextBox tbCategoryCrudName;
		private System.Windows.Forms.Label lblCatCrudName;
		private System.Windows.Forms.Label lblCategoryCrudError;
		private System.Windows.Forms.Button btnCategoryCrudOK;
		private System.Windows.Forms.Button btnCategoryCrudCancel;
	}
}