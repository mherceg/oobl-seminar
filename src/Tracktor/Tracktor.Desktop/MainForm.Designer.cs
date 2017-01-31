namespace Tracktor.Desktop
{
	partial class MainForm
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
			this.tabCtrlMainForm = new System.Windows.Forms.TabControl();
			this.TabUsers = new System.Windows.Forms.TabPage();
			this.dgvUserTable = new System.Windows.Forms.DataGridView();
			this.btnUserAdd = new System.Windows.Forms.Button();
			this.btnUserEdit = new System.Windows.Forms.Button();
			this.btnUserDelete = new System.Windows.Forms.Button();
			this.btnUserDetails = new System.Windows.Forms.Button();
			this.TabInformations = new System.Windows.Forms.TabPage();
			this.dgvInfoTable = new System.Windows.Forms.DataGridView();
			this.btnInfoAdd = new System.Windows.Forms.Button();
			this.btnInfoEdit = new System.Windows.Forms.Button();
			this.btnInfoDelete = new System.Windows.Forms.Button();
			this.btnInfoDetails = new System.Windows.Forms.Button();
			this.TabLocations = new System.Windows.Forms.TabPage();
			this.dgvPlaceTable = new System.Windows.Forms.DataGridView();
			this.btnLocationAdd = new System.Windows.Forms.Button();
			this.btnLocationEdit = new System.Windows.Forms.Button();
			this.btnLocationDelete = new System.Windows.Forms.Button();
			this.btnLocationDetails = new System.Windows.Forms.Button();
			this.lblLoggedIn = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.cRUDInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tabCtrlMainForm.SuspendLayout();
			this.TabUsers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUserTable)).BeginInit();
			this.TabInformations.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvInfoTable)).BeginInit();
			this.TabLocations.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPlaceTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cRUDInformationBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tabCtrlMainForm
			// 
			this.tabCtrlMainForm.Controls.Add(this.TabUsers);
			this.tabCtrlMainForm.Controls.Add(this.TabInformations);
			this.tabCtrlMainForm.Controls.Add(this.TabLocations);
			this.tabCtrlMainForm.Location = new System.Drawing.Point(12, 71);
			this.tabCtrlMainForm.Name = "tabCtrlMainForm";
			this.tabCtrlMainForm.SelectedIndex = 0;
			this.tabCtrlMainForm.Size = new System.Drawing.Size(917, 575);
			this.tabCtrlMainForm.TabIndex = 0;
			// 
			// TabUsers
			// 
			this.TabUsers.BackColor = System.Drawing.Color.DarkGray;
			this.TabUsers.Controls.Add(this.dgvUserTable);
			this.TabUsers.Controls.Add(this.btnUserAdd);
			this.TabUsers.Controls.Add(this.btnUserEdit);
			this.TabUsers.Controls.Add(this.btnUserDelete);
			this.TabUsers.Controls.Add(this.btnUserDetails);
			this.TabUsers.Location = new System.Drawing.Point(4, 25);
			this.TabUsers.Name = "TabUsers";
			this.TabUsers.Padding = new System.Windows.Forms.Padding(3);
			this.TabUsers.Size = new System.Drawing.Size(909, 546);
			this.TabUsers.TabIndex = 1;
			this.TabUsers.Text = "Users";
			// 
			// dgvUserTable
			// 
			this.dgvUserTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUserTable.Location = new System.Drawing.Point(6, 6);
			this.dgvUserTable.Name = "dgvUserTable";
			this.dgvUserTable.ReadOnly = true;
			this.dgvUserTable.RowTemplate.Height = 24;
			this.dgvUserTable.Size = new System.Drawing.Size(897, 472);
			this.dgvUserTable.TabIndex = 9;
			// 
			// btnUserAdd
			// 
			this.btnUserAdd.Location = new System.Drawing.Point(793, 484);
			this.btnUserAdd.Name = "btnUserAdd";
			this.btnUserAdd.Size = new System.Drawing.Size(110, 56);
			this.btnUserAdd.TabIndex = 8;
			this.btnUserAdd.Text = "Add User...";
			this.btnUserAdd.UseVisualStyleBackColor = true;
			this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
			// 
			// btnUserEdit
			// 
			this.btnUserEdit.Location = new System.Drawing.Point(648, 484);
			this.btnUserEdit.Name = "btnUserEdit";
			this.btnUserEdit.Size = new System.Drawing.Size(110, 56);
			this.btnUserEdit.TabIndex = 7;
			this.btnUserEdit.Text = "Edit User...";
			this.btnUserEdit.UseVisualStyleBackColor = true;
			this.btnUserEdit.Click += new System.EventHandler(this.btnUserEdit_Click);
			// 
			// btnUserDelete
			// 
			this.btnUserDelete.Location = new System.Drawing.Point(503, 484);
			this.btnUserDelete.Name = "btnUserDelete";
			this.btnUserDelete.Size = new System.Drawing.Size(110, 56);
			this.btnUserDelete.TabIndex = 6;
			this.btnUserDelete.Text = "Delete User";
			this.btnUserDelete.UseVisualStyleBackColor = true;
			this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
			// 
			// btnUserDetails
			// 
			this.btnUserDetails.Location = new System.Drawing.Point(358, 484);
			this.btnUserDetails.Name = "btnUserDetails";
			this.btnUserDetails.Size = new System.Drawing.Size(110, 56);
			this.btnUserDetails.TabIndex = 5;
			this.btnUserDetails.Text = "User Details...";
			this.btnUserDetails.UseVisualStyleBackColor = true;
			this.btnUserDetails.Click += new System.EventHandler(this.btnUserDetails_Click);
			// 
			// TabInformations
			// 
			this.TabInformations.BackColor = System.Drawing.Color.DarkGray;
			this.TabInformations.Controls.Add(this.dgvInfoTable);
			this.TabInformations.Controls.Add(this.btnInfoAdd);
			this.TabInformations.Controls.Add(this.btnInfoEdit);
			this.TabInformations.Controls.Add(this.btnInfoDelete);
			this.TabInformations.Controls.Add(this.btnInfoDetails);
			this.TabInformations.Location = new System.Drawing.Point(4, 25);
			this.TabInformations.Name = "TabInformations";
			this.TabInformations.Padding = new System.Windows.Forms.Padding(3);
			this.TabInformations.Size = new System.Drawing.Size(909, 546);
			this.TabInformations.TabIndex = 2;
			this.TabInformations.Text = "Informations";
			// 
			// dgvInfoTable
			// 
			this.dgvInfoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInfoTable.Location = new System.Drawing.Point(6, 6);
			this.dgvInfoTable.Name = "dgvInfoTable";
			this.dgvInfoTable.ReadOnly = true;
			this.dgvInfoTable.RowTemplate.Height = 24;
			this.dgvInfoTable.Size = new System.Drawing.Size(897, 472);
			this.dgvInfoTable.TabIndex = 10;
			this.dgvInfoTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfoTable_CellContentClick);
			// 
			// btnInfoAdd
			// 
			this.btnInfoAdd.Location = new System.Drawing.Point(793, 488);
			this.btnInfoAdd.Name = "btnInfoAdd";
			this.btnInfoAdd.Size = new System.Drawing.Size(110, 52);
			this.btnInfoAdd.TabIndex = 8;
			this.btnInfoAdd.Text = "Add Information...";
			this.btnInfoAdd.UseVisualStyleBackColor = true;
			this.btnInfoAdd.Click += new System.EventHandler(this.btnInfoAdd_Click);
			// 
			// btnInfoEdit
			// 
			this.btnInfoEdit.Location = new System.Drawing.Point(648, 488);
			this.btnInfoEdit.Name = "btnInfoEdit";
			this.btnInfoEdit.Size = new System.Drawing.Size(110, 52);
			this.btnInfoEdit.TabIndex = 7;
			this.btnInfoEdit.Text = "Edit Information...";
			this.btnInfoEdit.UseVisualStyleBackColor = true;
			this.btnInfoEdit.Click += new System.EventHandler(this.btnInfoEdit_Click);
			// 
			// btnInfoDelete
			// 
			this.btnInfoDelete.Location = new System.Drawing.Point(503, 488);
			this.btnInfoDelete.Name = "btnInfoDelete";
			this.btnInfoDelete.Size = new System.Drawing.Size(110, 52);
			this.btnInfoDelete.TabIndex = 6;
			this.btnInfoDelete.Text = "Delete Information";
			this.btnInfoDelete.UseVisualStyleBackColor = true;
			// 
			// btnInfoDetails
			// 
			this.btnInfoDetails.Location = new System.Drawing.Point(358, 488);
			this.btnInfoDetails.Name = "btnInfoDetails";
			this.btnInfoDetails.Size = new System.Drawing.Size(110, 52);
			this.btnInfoDetails.TabIndex = 5;
			this.btnInfoDetails.Text = "Information Details...";
			this.btnInfoDetails.UseVisualStyleBackColor = true;
			this.btnInfoDetails.Click += new System.EventHandler(this.btnInfoDetails_Click);
			// 
			// TabLocations
			// 
			this.TabLocations.BackColor = System.Drawing.Color.DarkGray;
			this.TabLocations.Controls.Add(this.dgvPlaceTable);
			this.TabLocations.Controls.Add(this.btnLocationAdd);
			this.TabLocations.Controls.Add(this.btnLocationEdit);
			this.TabLocations.Controls.Add(this.btnLocationDelete);
			this.TabLocations.Controls.Add(this.btnLocationDetails);
			this.TabLocations.Location = new System.Drawing.Point(4, 25);
			this.TabLocations.Name = "TabLocations";
			this.TabLocations.Padding = new System.Windows.Forms.Padding(3);
			this.TabLocations.Size = new System.Drawing.Size(909, 546);
			this.TabLocations.TabIndex = 3;
			this.TabLocations.Text = "Places";
			// 
			// dgvPlaceTable
			// 
			this.dgvPlaceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPlaceTable.Location = new System.Drawing.Point(6, 10);
			this.dgvPlaceTable.Name = "dgvPlaceTable";
			this.dgvPlaceTable.ReadOnly = true;
			this.dgvPlaceTable.RowTemplate.Height = 24;
			this.dgvPlaceTable.Size = new System.Drawing.Size(897, 472);
			this.dgvPlaceTable.TabIndex = 13;
			// 
			// btnLocationAdd
			// 
			this.btnLocationAdd.Location = new System.Drawing.Point(793, 488);
			this.btnLocationAdd.Name = "btnLocationAdd";
			this.btnLocationAdd.Size = new System.Drawing.Size(110, 52);
			this.btnLocationAdd.TabIndex = 12;
			this.btnLocationAdd.Text = "Add Location...";
			this.btnLocationAdd.UseVisualStyleBackColor = true;
			this.btnLocationAdd.Click += new System.EventHandler(this.btnLocationAdd_Click);
			// 
			// btnLocationEdit
			// 
			this.btnLocationEdit.Location = new System.Drawing.Point(648, 488);
			this.btnLocationEdit.Name = "btnLocationEdit";
			this.btnLocationEdit.Size = new System.Drawing.Size(110, 52);
			this.btnLocationEdit.TabIndex = 11;
			this.btnLocationEdit.Text = "Edit Location...";
			this.btnLocationEdit.UseVisualStyleBackColor = true;
			this.btnLocationEdit.Click += new System.EventHandler(this.btnLocationEdit_Click);
			// 
			// btnLocationDelete
			// 
			this.btnLocationDelete.Location = new System.Drawing.Point(503, 488);
			this.btnLocationDelete.Name = "btnLocationDelete";
			this.btnLocationDelete.Size = new System.Drawing.Size(110, 52);
			this.btnLocationDelete.TabIndex = 10;
			this.btnLocationDelete.Text = "Delete Location";
			this.btnLocationDelete.UseVisualStyleBackColor = true;
			// 
			// btnLocationDetails
			// 
			this.btnLocationDetails.Location = new System.Drawing.Point(358, 488);
			this.btnLocationDetails.Name = "btnLocationDetails";
			this.btnLocationDetails.Size = new System.Drawing.Size(110, 52);
			this.btnLocationDetails.TabIndex = 9;
			this.btnLocationDetails.Text = "Location Details...";
			this.btnLocationDetails.UseVisualStyleBackColor = true;
			this.btnLocationDetails.Click += new System.EventHandler(this.btnLocationDetails_Click);
			// 
			// lblLoggedIn
			// 
			this.lblLoggedIn.AutoSize = true;
			this.lblLoggedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblLoggedIn.Location = new System.Drawing.Point(480, 9);
			this.lblLoggedIn.Name = "lblLoggedIn";
			this.lblLoggedIn.Size = new System.Drawing.Size(115, 20);
			this.lblLoggedIn.TabIndex = 1;
			this.lblLoggedIn.Text = "Logged in as: ";
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblUser.Location = new System.Drawing.Point(601, 9);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(62, 20);
			this.lblUser.TabIndex = 2;
			this.lblUser.Text = "<user>";
			// 
			// cRUDInformationBindingSource
			// 
			this.cRUDInformationBindingSource.DataSource = typeof(Tracktor.Desktop.CRUD_Information);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(935, 658);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.lblLoggedIn);
			this.Controls.Add(this.tabCtrlMainForm);
			this.Name = "MainForm";
			this.Text = "Tracktor";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabCtrlMainForm.ResumeLayout(false);
			this.TabUsers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvUserTable)).EndInit();
			this.TabInformations.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvInfoTable)).EndInit();
			this.TabLocations.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvPlaceTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cRUDInformationBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabCtrlMainForm;
		private System.Windows.Forms.TabPage TabUsers;
		private System.Windows.Forms.TabPage TabInformations;
		private System.Windows.Forms.TabPage TabLocations;
		private System.Windows.Forms.Button btnUserAdd;
		private System.Windows.Forms.Button btnUserEdit;
		private System.Windows.Forms.Button btnUserDelete;
		private System.Windows.Forms.Button btnUserDetails;
		private System.Windows.Forms.Button btnInfoAdd;
		private System.Windows.Forms.Button btnInfoEdit;
		private System.Windows.Forms.Button btnInfoDelete;
		private System.Windows.Forms.Button btnInfoDetails;
		private System.Windows.Forms.Button btnLocationAdd;
		private System.Windows.Forms.Button btnLocationEdit;
		private System.Windows.Forms.Button btnLocationDelete;
		private System.Windows.Forms.Button btnLocationDetails;
		private System.Windows.Forms.Label lblLoggedIn;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.DataGridView dgvUserTable;
		private System.Windows.Forms.DataGridView dgvInfoTable;
		private System.Windows.Forms.DataGridView dgvPlaceTable;
		private System.Windows.Forms.BindingSource cRUDInformationBindingSource;
	}
}