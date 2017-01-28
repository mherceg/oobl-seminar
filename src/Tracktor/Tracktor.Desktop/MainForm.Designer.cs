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
			this.tabCtrlMainForm = new System.Windows.Forms.TabControl();
			this.TabMap = new System.Windows.Forms.TabPage();
			this.TabUsers = new System.Windows.Forms.TabPage();
			this.btnUserAdd = new System.Windows.Forms.Button();
			this.btnUserEdit = new System.Windows.Forms.Button();
			this.btnUserDelete = new System.Windows.Forms.Button();
			this.btnUserDetails = new System.Windows.Forms.Button();
			this.tableUsers = new System.Windows.Forms.TableLayoutPanel();
			this.TabInformations = new System.Windows.Forms.TabPage();
			this.btnInfoAdd = new System.Windows.Forms.Button();
			this.btnInfoEdit = new System.Windows.Forms.Button();
			this.btnInfoDelete = new System.Windows.Forms.Button();
			this.btnInfoDetails = new System.Windows.Forms.Button();
			this.tableInformations = new System.Windows.Forms.TableLayoutPanel();
			this.TabLocations = new System.Windows.Forms.TabPage();
			this.btnLocationAdd = new System.Windows.Forms.Button();
			this.btnLocationEdit = new System.Windows.Forms.Button();
			this.btnLocationDelete = new System.Windows.Forms.Button();
			this.btnLocationDetails = new System.Windows.Forms.Button();
			this.tablePlaces = new System.Windows.Forms.TableLayoutPanel();
			this.lblLoggedIn = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.tabCtrlMainForm.SuspendLayout();
			this.TabUsers.SuspendLayout();
			this.TabInformations.SuspendLayout();
			this.TabLocations.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabCtrlMainForm
			// 
			this.tabCtrlMainForm.Controls.Add(this.TabMap);
			this.tabCtrlMainForm.Controls.Add(this.TabUsers);
			this.tabCtrlMainForm.Controls.Add(this.TabInformations);
			this.tabCtrlMainForm.Controls.Add(this.TabLocations);
			this.tabCtrlMainForm.Location = new System.Drawing.Point(12, 71);
			this.tabCtrlMainForm.Name = "tabCtrlMainForm";
			this.tabCtrlMainForm.SelectedIndex = 0;
			this.tabCtrlMainForm.Size = new System.Drawing.Size(683, 575);
			this.tabCtrlMainForm.TabIndex = 0;
			// 
			// TabMap
			// 
			this.TabMap.Location = new System.Drawing.Point(4, 25);
			this.TabMap.Name = "TabMap";
			this.TabMap.Padding = new System.Windows.Forms.Padding(3);
			this.TabMap.Size = new System.Drawing.Size(675, 546);
			this.TabMap.TabIndex = 0;
			this.TabMap.Text = "Map";
			this.TabMap.UseVisualStyleBackColor = true;
			this.TabMap.Click += new System.EventHandler(this.tabMap_Click);
			// 
			// TabUsers
			// 
			this.TabUsers.BackColor = System.Drawing.Color.DarkGray;
			this.TabUsers.Controls.Add(this.btnUserAdd);
			this.TabUsers.Controls.Add(this.btnUserEdit);
			this.TabUsers.Controls.Add(this.btnUserDelete);
			this.TabUsers.Controls.Add(this.btnUserDetails);
			this.TabUsers.Controls.Add(this.tableUsers);
			this.TabUsers.Location = new System.Drawing.Point(4, 25);
			this.TabUsers.Name = "TabUsers";
			this.TabUsers.Padding = new System.Windows.Forms.Padding(3);
			this.TabUsers.Size = new System.Drawing.Size(675, 546);
			this.TabUsers.TabIndex = 1;
			this.TabUsers.Text = "Users";
			this.TabUsers.Click += new System.EventHandler(this.TabUsers_Click);
			// 
			// btnUserAdd
			// 
			this.btnUserAdd.Location = new System.Drawing.Point(545, 484);
			this.btnUserAdd.Name = "btnUserAdd";
			this.btnUserAdd.Size = new System.Drawing.Size(110, 56);
			this.btnUserAdd.TabIndex = 8;
			this.btnUserAdd.Text = "Add User...";
			this.btnUserAdd.UseVisualStyleBackColor = true;
			this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
			// 
			// btnUserEdit
			// 
			this.btnUserEdit.Location = new System.Drawing.Point(400, 484);
			this.btnUserEdit.Name = "btnUserEdit";
			this.btnUserEdit.Size = new System.Drawing.Size(110, 56);
			this.btnUserEdit.TabIndex = 7;
			this.btnUserEdit.Text = "Edit User...";
			this.btnUserEdit.UseVisualStyleBackColor = true;
			this.btnUserEdit.Click += new System.EventHandler(this.btnUserEdit_Click);
			// 
			// btnUserDelete
			// 
			this.btnUserDelete.Location = new System.Drawing.Point(255, 484);
			this.btnUserDelete.Name = "btnUserDelete";
			this.btnUserDelete.Size = new System.Drawing.Size(110, 56);
			this.btnUserDelete.TabIndex = 6;
			this.btnUserDelete.Text = "Delete User";
			this.btnUserDelete.UseVisualStyleBackColor = true;
			// 
			// btnUserDetails
			// 
			this.btnUserDetails.Location = new System.Drawing.Point(110, 484);
			this.btnUserDetails.Name = "btnUserDetails";
			this.btnUserDetails.Size = new System.Drawing.Size(110, 56);
			this.btnUserDetails.TabIndex = 5;
			this.btnUserDetails.Text = "User Details...";
			this.btnUserDetails.UseVisualStyleBackColor = true;
			this.btnUserDetails.Click += new System.EventHandler(this.btnUserDetails_Click);
			// 
			// tableUsers
			// 
			this.tableUsers.AutoSize = true;
			this.tableUsers.BackColor = System.Drawing.Color.White;
			this.tableUsers.ColumnCount = 5;
			this.tableUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableUsers.Location = new System.Drawing.Point(6, 6);
			this.tableUsers.Name = "tableUsers";
			this.tableUsers.RowCount = 2;
			this.tableUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.983193F));
			this.tableUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.01681F));
			this.tableUsers.Size = new System.Drawing.Size(649, 472);
			this.tableUsers.TabIndex = 0;
			// 
			// TabInformations
			// 
			this.TabInformations.BackColor = System.Drawing.Color.DarkGray;
			this.TabInformations.Controls.Add(this.btnInfoAdd);
			this.TabInformations.Controls.Add(this.btnInfoEdit);
			this.TabInformations.Controls.Add(this.btnInfoDelete);
			this.TabInformations.Controls.Add(this.btnInfoDetails);
			this.TabInformations.Controls.Add(this.tableInformations);
			this.TabInformations.Location = new System.Drawing.Point(4, 25);
			this.TabInformations.Name = "TabInformations";
			this.TabInformations.Padding = new System.Windows.Forms.Padding(3);
			this.TabInformations.Size = new System.Drawing.Size(675, 546);
			this.TabInformations.TabIndex = 2;
			this.TabInformations.Text = "Informations";
			// 
			// btnInfoAdd
			// 
			this.btnInfoAdd.Location = new System.Drawing.Point(544, 488);
			this.btnInfoAdd.Name = "btnInfoAdd";
			this.btnInfoAdd.Size = new System.Drawing.Size(110, 52);
			this.btnInfoAdd.TabIndex = 8;
			this.btnInfoAdd.Text = "Add Information...";
			this.btnInfoAdd.UseVisualStyleBackColor = true;
			this.btnInfoAdd.Click += new System.EventHandler(this.btnInfoAdd_Click);
			// 
			// btnInfoEdit
			// 
			this.btnInfoEdit.Location = new System.Drawing.Point(399, 488);
			this.btnInfoEdit.Name = "btnInfoEdit";
			this.btnInfoEdit.Size = new System.Drawing.Size(110, 52);
			this.btnInfoEdit.TabIndex = 7;
			this.btnInfoEdit.Text = "Edit Information...";
			this.btnInfoEdit.UseVisualStyleBackColor = true;
			this.btnInfoEdit.Click += new System.EventHandler(this.btnInfoEdit_Click);
			// 
			// btnInfoDelete
			// 
			this.btnInfoDelete.Location = new System.Drawing.Point(254, 488);
			this.btnInfoDelete.Name = "btnInfoDelete";
			this.btnInfoDelete.Size = new System.Drawing.Size(110, 52);
			this.btnInfoDelete.TabIndex = 6;
			this.btnInfoDelete.Text = "Delete Information";
			this.btnInfoDelete.UseVisualStyleBackColor = true;
			// 
			// btnInfoDetails
			// 
			this.btnInfoDetails.Location = new System.Drawing.Point(109, 488);
			this.btnInfoDetails.Name = "btnInfoDetails";
			this.btnInfoDetails.Size = new System.Drawing.Size(110, 52);
			this.btnInfoDetails.TabIndex = 5;
			this.btnInfoDetails.Text = "Information Details...";
			this.btnInfoDetails.UseVisualStyleBackColor = true;
			this.btnInfoDetails.Click += new System.EventHandler(this.btnInfoDetails_Click);
			// 
			// tableInformations
			// 
			this.tableInformations.BackColor = System.Drawing.Color.White;
			this.tableInformations.ColumnCount = 5;
			this.tableInformations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableInformations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableInformations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableInformations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableInformations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableInformations.Location = new System.Drawing.Point(5, 6);
			this.tableInformations.Name = "tableInformations";
			this.tableInformations.RowCount = 2;
			this.tableInformations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.983193F));
			this.tableInformations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.01681F));
			this.tableInformations.Size = new System.Drawing.Size(649, 476);
			this.tableInformations.TabIndex = 1;
			this.tableInformations.Paint += new System.Windows.Forms.PaintEventHandler(this.tableInformations_Paint);
			// 
			// TabLocations
			// 
			this.TabLocations.BackColor = System.Drawing.Color.DarkGray;
			this.TabLocations.Controls.Add(this.btnLocationAdd);
			this.TabLocations.Controls.Add(this.btnLocationEdit);
			this.TabLocations.Controls.Add(this.btnLocationDelete);
			this.TabLocations.Controls.Add(this.btnLocationDetails);
			this.TabLocations.Controls.Add(this.tablePlaces);
			this.TabLocations.Location = new System.Drawing.Point(4, 25);
			this.TabLocations.Name = "TabLocations";
			this.TabLocations.Padding = new System.Windows.Forms.Padding(3);
			this.TabLocations.Size = new System.Drawing.Size(675, 546);
			this.TabLocations.TabIndex = 3;
			this.TabLocations.Text = "Locations";
			// 
			// btnLocationAdd
			// 
			this.btnLocationAdd.Location = new System.Drawing.Point(544, 488);
			this.btnLocationAdd.Name = "btnLocationAdd";
			this.btnLocationAdd.Size = new System.Drawing.Size(110, 52);
			this.btnLocationAdd.TabIndex = 12;
			this.btnLocationAdd.Text = "Add Location...";
			this.btnLocationAdd.UseVisualStyleBackColor = true;
			this.btnLocationAdd.Click += new System.EventHandler(this.btnLocationAdd_Click);
			// 
			// btnLocationEdit
			// 
			this.btnLocationEdit.Location = new System.Drawing.Point(399, 488);
			this.btnLocationEdit.Name = "btnLocationEdit";
			this.btnLocationEdit.Size = new System.Drawing.Size(110, 52);
			this.btnLocationEdit.TabIndex = 11;
			this.btnLocationEdit.Text = "Edit Location...";
			this.btnLocationEdit.UseVisualStyleBackColor = true;
			this.btnLocationEdit.Click += new System.EventHandler(this.btnLocationEdit_Click);
			// 
			// btnLocationDelete
			// 
			this.btnLocationDelete.Location = new System.Drawing.Point(254, 488);
			this.btnLocationDelete.Name = "btnLocationDelete";
			this.btnLocationDelete.Size = new System.Drawing.Size(110, 52);
			this.btnLocationDelete.TabIndex = 10;
			this.btnLocationDelete.Text = "Delete Location";
			this.btnLocationDelete.UseVisualStyleBackColor = true;
			// 
			// btnLocationDetails
			// 
			this.btnLocationDetails.Location = new System.Drawing.Point(109, 488);
			this.btnLocationDetails.Name = "btnLocationDetails";
			this.btnLocationDetails.Size = new System.Drawing.Size(110, 52);
			this.btnLocationDetails.TabIndex = 9;
			this.btnLocationDetails.Text = "Location Details...";
			this.btnLocationDetails.UseVisualStyleBackColor = true;
			this.btnLocationDetails.Click += new System.EventHandler(this.btnLocationDetails_Click);
			// 
			// tablePlaces
			// 
			this.tablePlaces.BackColor = System.Drawing.Color.White;
			this.tablePlaces.ColumnCount = 5;
			this.tablePlaces.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tablePlaces.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tablePlaces.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tablePlaces.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tablePlaces.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tablePlaces.Location = new System.Drawing.Point(5, 6);
			this.tablePlaces.Name = "tablePlaces";
			this.tablePlaces.RowCount = 2;
			this.tablePlaces.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.983193F));
			this.tablePlaces.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.01681F));
			this.tablePlaces.Size = new System.Drawing.Size(649, 476);
			this.tablePlaces.TabIndex = 1;
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(707, 658);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.lblLoggedIn);
			this.Controls.Add(this.tabCtrlMainForm);
			this.Name = "MainForm";
			this.Text = "Tracktor";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabCtrlMainForm.ResumeLayout(false);
			this.TabUsers.ResumeLayout(false);
			this.TabUsers.PerformLayout();
			this.TabInformations.ResumeLayout(false);
			this.TabLocations.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabCtrlMainForm;
		private System.Windows.Forms.TabPage TabMap;
		private System.Windows.Forms.TabPage TabUsers;
		private System.Windows.Forms.TabPage TabInformations;
		private System.Windows.Forms.TabPage TabLocations;
		private System.Windows.Forms.TableLayoutPanel tableUsers;
		private System.Windows.Forms.TableLayoutPanel tableInformations;
		private System.Windows.Forms.TableLayoutPanel tablePlaces;
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
	}
}