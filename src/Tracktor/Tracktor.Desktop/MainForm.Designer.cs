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
			this.btnPlaceAdd = new System.Windows.Forms.Button();
			this.btnPlaceEdit = new System.Windows.Forms.Button();
			this.btnPlaceDelete = new System.Windows.Forms.Button();
			this.btnPlaceDetails = new System.Windows.Forms.Button();
			this.TabCategories = new System.Windows.Forms.TabPage();
			this.dgvCategoryTable = new System.Windows.Forms.DataGridView();
			this.btnCategoryAdd = new System.Windows.Forms.Button();
			this.btnCategoryEdit = new System.Windows.Forms.Button();
			this.btnCategoryDelete = new System.Windows.Forms.Button();
			this.btnCategoryDetails = new System.Windows.Forms.Button();
			this.TabComments = new System.Windows.Forms.TabPage();
			this.btnCommentCrudAdd = new System.Windows.Forms.Button();
			this.dgvCommentTable = new System.Windows.Forms.DataGridView();
			this.btnCommentCrudEdit = new System.Windows.Forms.Button();
			this.btnCommentCrudDelete = new System.Windows.Forms.Button();
			this.btnCommentCrudDetails = new System.Windows.Forms.Button();
			this.TabUserTypes = new System.Windows.Forms.TabPage();
			this.btnUTCrudAdd = new System.Windows.Forms.Button();
			this.btnUTCrudEdit = new System.Windows.Forms.Button();
			this.btnUTCrudDelete = new System.Windows.Forms.Button();
			this.btnUTCrudDetails = new System.Windows.Forms.Button();
			this.dgvUTTable = new System.Windows.Forms.DataGridView();
			this.lblLoggedIn = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.btnLogOut = new System.Windows.Forms.Button();
			this.cRUDInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tabCtrlMainForm.SuspendLayout();
			this.TabUsers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUserTable)).BeginInit();
			this.TabInformations.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvInfoTable)).BeginInit();
			this.TabLocations.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPlaceTable)).BeginInit();
			this.TabCategories.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCategoryTable)).BeginInit();
			this.TabComments.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCommentTable)).BeginInit();
			this.TabUserTypes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUTTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cRUDInformationBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tabCtrlMainForm
			// 
			this.tabCtrlMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabCtrlMainForm.Controls.Add(this.TabUsers);
			this.tabCtrlMainForm.Controls.Add(this.TabInformations);
			this.tabCtrlMainForm.Controls.Add(this.TabLocations);
			this.tabCtrlMainForm.Controls.Add(this.TabCategories);
			this.tabCtrlMainForm.Controls.Add(this.TabComments);
			this.tabCtrlMainForm.Controls.Add(this.TabUserTypes);
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
			this.btnUserAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
			this.btnUserEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
			this.btnUserDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
			this.btnUserDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
			this.btnInfoDelete.Click += new System.EventHandler(this.btnInfoDelete_Click);
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
			this.TabLocations.Controls.Add(this.btnPlaceAdd);
			this.TabLocations.Controls.Add(this.btnPlaceEdit);
			this.TabLocations.Controls.Add(this.btnPlaceDelete);
			this.TabLocations.Controls.Add(this.btnPlaceDetails);
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
			// btnPlaceAdd
			// 
			this.btnPlaceAdd.Location = new System.Drawing.Point(793, 488);
			this.btnPlaceAdd.Name = "btnPlaceAdd";
			this.btnPlaceAdd.Size = new System.Drawing.Size(110, 52);
			this.btnPlaceAdd.TabIndex = 12;
			this.btnPlaceAdd.Text = "Add Place...";
			this.btnPlaceAdd.UseVisualStyleBackColor = true;
			this.btnPlaceAdd.Click += new System.EventHandler(this.btnPlaceAdd_Click);
			// 
			// btnPlaceEdit
			// 
			this.btnPlaceEdit.Location = new System.Drawing.Point(648, 488);
			this.btnPlaceEdit.Name = "btnPlaceEdit";
			this.btnPlaceEdit.Size = new System.Drawing.Size(110, 52);
			this.btnPlaceEdit.TabIndex = 11;
			this.btnPlaceEdit.Text = "Edit Place...";
			this.btnPlaceEdit.UseVisualStyleBackColor = true;
			this.btnPlaceEdit.Click += new System.EventHandler(this.btnPlaceEdit_Click);
			// 
			// btnPlaceDelete
			// 
			this.btnPlaceDelete.Location = new System.Drawing.Point(503, 488);
			this.btnPlaceDelete.Name = "btnPlaceDelete";
			this.btnPlaceDelete.Size = new System.Drawing.Size(110, 52);
			this.btnPlaceDelete.TabIndex = 10;
			this.btnPlaceDelete.Text = "Delete Place";
			this.btnPlaceDelete.UseVisualStyleBackColor = true;
			this.btnPlaceDelete.Click += new System.EventHandler(this.btnPlaceDelete_Click);
			// 
			// btnPlaceDetails
			// 
			this.btnPlaceDetails.Location = new System.Drawing.Point(358, 488);
			this.btnPlaceDetails.Name = "btnPlaceDetails";
			this.btnPlaceDetails.Size = new System.Drawing.Size(110, 52);
			this.btnPlaceDetails.TabIndex = 9;
			this.btnPlaceDetails.Text = "Place Details...";
			this.btnPlaceDetails.UseVisualStyleBackColor = true;
			this.btnPlaceDetails.Click += new System.EventHandler(this.btnPlaceDetails_Click);
			// 
			// TabCategories
			// 
			this.TabCategories.Controls.Add(this.dgvCategoryTable);
			this.TabCategories.Controls.Add(this.btnCategoryAdd);
			this.TabCategories.Controls.Add(this.btnCategoryEdit);
			this.TabCategories.Controls.Add(this.btnCategoryDelete);
			this.TabCategories.Controls.Add(this.btnCategoryDetails);
			this.TabCategories.Location = new System.Drawing.Point(4, 25);
			this.TabCategories.Name = "TabCategories";
			this.TabCategories.Padding = new System.Windows.Forms.Padding(3);
			this.TabCategories.Size = new System.Drawing.Size(909, 546);
			this.TabCategories.TabIndex = 4;
			this.TabCategories.Text = "Categories";
			this.TabCategories.UseVisualStyleBackColor = true;
			// 
			// dgvCategoryTable
			// 
			this.dgvCategoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCategoryTable.Location = new System.Drawing.Point(6, 8);
			this.dgvCategoryTable.Name = "dgvCategoryTable";
			this.dgvCategoryTable.ReadOnly = true;
			this.dgvCategoryTable.RowTemplate.Height = 24;
			this.dgvCategoryTable.Size = new System.Drawing.Size(897, 472);
			this.dgvCategoryTable.TabIndex = 18;
			// 
			// btnCategoryAdd
			// 
			this.btnCategoryAdd.Location = new System.Drawing.Point(793, 486);
			this.btnCategoryAdd.Name = "btnCategoryAdd";
			this.btnCategoryAdd.Size = new System.Drawing.Size(110, 52);
			this.btnCategoryAdd.TabIndex = 17;
			this.btnCategoryAdd.Text = "Add Category...";
			this.btnCategoryAdd.UseVisualStyleBackColor = true;
			this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
			// 
			// btnCategoryEdit
			// 
			this.btnCategoryEdit.Location = new System.Drawing.Point(648, 486);
			this.btnCategoryEdit.Name = "btnCategoryEdit";
			this.btnCategoryEdit.Size = new System.Drawing.Size(110, 52);
			this.btnCategoryEdit.TabIndex = 16;
			this.btnCategoryEdit.Text = "Edit Category...";
			this.btnCategoryEdit.UseVisualStyleBackColor = true;
			this.btnCategoryEdit.Click += new System.EventHandler(this.btnCategoryEdit_Click);
			// 
			// btnCategoryDelete
			// 
			this.btnCategoryDelete.Location = new System.Drawing.Point(503, 486);
			this.btnCategoryDelete.Name = "btnCategoryDelete";
			this.btnCategoryDelete.Size = new System.Drawing.Size(110, 52);
			this.btnCategoryDelete.TabIndex = 15;
			this.btnCategoryDelete.Text = "Delete Category";
			this.btnCategoryDelete.UseVisualStyleBackColor = true;
			this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
			// 
			// btnCategoryDetails
			// 
			this.btnCategoryDetails.Location = new System.Drawing.Point(358, 486);
			this.btnCategoryDetails.Name = "btnCategoryDetails";
			this.btnCategoryDetails.Size = new System.Drawing.Size(110, 52);
			this.btnCategoryDetails.TabIndex = 14;
			this.btnCategoryDetails.Text = "Category Details...";
			this.btnCategoryDetails.UseVisualStyleBackColor = true;
			this.btnCategoryDetails.Click += new System.EventHandler(this.btnCategoryDetails_Click);
			// 
			// TabComments
			// 
			this.TabComments.Controls.Add(this.btnCommentCrudAdd);
			this.TabComments.Controls.Add(this.dgvCommentTable);
			this.TabComments.Controls.Add(this.btnCommentCrudEdit);
			this.TabComments.Controls.Add(this.btnCommentCrudDelete);
			this.TabComments.Controls.Add(this.btnCommentCrudDetails);
			this.TabComments.Location = new System.Drawing.Point(4, 25);
			this.TabComments.Name = "TabComments";
			this.TabComments.Padding = new System.Windows.Forms.Padding(3);
			this.TabComments.Size = new System.Drawing.Size(909, 546);
			this.TabComments.TabIndex = 5;
			this.TabComments.Text = "Comments";
			this.TabComments.UseVisualStyleBackColor = true;
			// 
			// btnCommentCrudAdd
			// 
			this.btnCommentCrudAdd.Location = new System.Drawing.Point(793, 488);
			this.btnCommentCrudAdd.Name = "btnCommentCrudAdd";
			this.btnCommentCrudAdd.Size = new System.Drawing.Size(110, 52);
			this.btnCommentCrudAdd.TabIndex = 24;
			this.btnCommentCrudAdd.Text = "Add Comment...";
			this.btnCommentCrudAdd.UseVisualStyleBackColor = true;
			this.btnCommentCrudAdd.Click += new System.EventHandler(this.btnCommentCrudAdd_Click);
			// 
			// dgvCommentTable
			// 
			this.dgvCommentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCommentTable.Location = new System.Drawing.Point(6, 8);
			this.dgvCommentTable.Name = "dgvCommentTable";
			this.dgvCommentTable.ReadOnly = true;
			this.dgvCommentTable.RowTemplate.Height = 24;
			this.dgvCommentTable.Size = new System.Drawing.Size(897, 472);
			this.dgvCommentTable.TabIndex = 23;
			// 
			// btnCommentCrudEdit
			// 
			this.btnCommentCrudEdit.Location = new System.Drawing.Point(654, 488);
			this.btnCommentCrudEdit.Name = "btnCommentCrudEdit";
			this.btnCommentCrudEdit.Size = new System.Drawing.Size(110, 52);
			this.btnCommentCrudEdit.TabIndex = 21;
			this.btnCommentCrudEdit.Text = "Edit Comment...";
			this.btnCommentCrudEdit.UseVisualStyleBackColor = true;
			this.btnCommentCrudEdit.Click += new System.EventHandler(this.btnCommentCrudEdit_Click);
			// 
			// btnCommentCrudDelete
			// 
			this.btnCommentCrudDelete.Location = new System.Drawing.Point(515, 488);
			this.btnCommentCrudDelete.Name = "btnCommentCrudDelete";
			this.btnCommentCrudDelete.Size = new System.Drawing.Size(110, 52);
			this.btnCommentCrudDelete.TabIndex = 20;
			this.btnCommentCrudDelete.Text = "Delete Comment";
			this.btnCommentCrudDelete.UseVisualStyleBackColor = true;
			this.btnCommentCrudDelete.Click += new System.EventHandler(this.btnCommentCrudDelete_Click);
			// 
			// btnCommentCrudDetails
			// 
			this.btnCommentCrudDetails.Location = new System.Drawing.Point(376, 488);
			this.btnCommentCrudDetails.Name = "btnCommentCrudDetails";
			this.btnCommentCrudDetails.Size = new System.Drawing.Size(110, 52);
			this.btnCommentCrudDetails.TabIndex = 19;
			this.btnCommentCrudDetails.Text = "Comment Details...";
			this.btnCommentCrudDetails.UseVisualStyleBackColor = true;
			this.btnCommentCrudDetails.Click += new System.EventHandler(this.btnCommentCrudDetails_Click);
			// 
			// TabUserTypes
			// 
			this.TabUserTypes.Controls.Add(this.btnUTCrudAdd);
			this.TabUserTypes.Controls.Add(this.btnUTCrudEdit);
			this.TabUserTypes.Controls.Add(this.btnUTCrudDelete);
			this.TabUserTypes.Controls.Add(this.btnUTCrudDetails);
			this.TabUserTypes.Controls.Add(this.dgvUTTable);
			this.TabUserTypes.Location = new System.Drawing.Point(4, 25);
			this.TabUserTypes.Name = "TabUserTypes";
			this.TabUserTypes.Padding = new System.Windows.Forms.Padding(3);
			this.TabUserTypes.Size = new System.Drawing.Size(909, 546);
			this.TabUserTypes.TabIndex = 6;
			this.TabUserTypes.Text = "User Types";
			this.TabUserTypes.UseVisualStyleBackColor = true;
			// 
			// btnUTCrudAdd
			// 
			this.btnUTCrudAdd.Location = new System.Drawing.Point(793, 488);
			this.btnUTCrudAdd.Name = "btnUTCrudAdd";
			this.btnUTCrudAdd.Size = new System.Drawing.Size(110, 52);
			this.btnUTCrudAdd.TabIndex = 31;
			this.btnUTCrudAdd.Text = "Add User Type...";
			this.btnUTCrudAdd.UseVisualStyleBackColor = true;
			this.btnUTCrudAdd.Click += new System.EventHandler(this.btnUTCrudAdd_Click);
			// 
			// btnUTCrudEdit
			// 
			this.btnUTCrudEdit.Location = new System.Drawing.Point(648, 488);
			this.btnUTCrudEdit.Name = "btnUTCrudEdit";
			this.btnUTCrudEdit.Size = new System.Drawing.Size(110, 52);
			this.btnUTCrudEdit.TabIndex = 30;
			this.btnUTCrudEdit.Text = "Edit User Type...";
			this.btnUTCrudEdit.UseVisualStyleBackColor = true;
			this.btnUTCrudEdit.Click += new System.EventHandler(this.btnUTCrudEdit_Click);
			// 
			// btnUTCrudDelete
			// 
			this.btnUTCrudDelete.Location = new System.Drawing.Point(503, 488);
			this.btnUTCrudDelete.Name = "btnUTCrudDelete";
			this.btnUTCrudDelete.Size = new System.Drawing.Size(110, 52);
			this.btnUTCrudDelete.TabIndex = 29;
			this.btnUTCrudDelete.Text = "Delete User Type";
			this.btnUTCrudDelete.UseVisualStyleBackColor = true;
			this.btnUTCrudDelete.Click += new System.EventHandler(this.btnUTCrudDelete_Click);
			// 
			// btnUTCrudDetails
			// 
			this.btnUTCrudDetails.Location = new System.Drawing.Point(358, 488);
			this.btnUTCrudDetails.Name = "btnUTCrudDetails";
			this.btnUTCrudDetails.Size = new System.Drawing.Size(110, 52);
			this.btnUTCrudDetails.TabIndex = 28;
			this.btnUTCrudDetails.Text = "User Type Details...";
			this.btnUTCrudDetails.UseVisualStyleBackColor = true;
			this.btnUTCrudDetails.Click += new System.EventHandler(this.btnUTCrudDetails_Click);
			// 
			// dgvUTTable
			// 
			this.dgvUTTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUTTable.Location = new System.Drawing.Point(6, 7);
			this.dgvUTTable.Name = "dgvUTTable";
			this.dgvUTTable.ReadOnly = true;
			this.dgvUTTable.RowTemplate.Height = 24;
			this.dgvUTTable.Size = new System.Drawing.Size(897, 472);
			this.dgvUTTable.TabIndex = 27;
			// 
			// lblLoggedIn
			// 
			this.lblLoggedIn.AutoSize = true;
			this.lblLoggedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblLoggedIn.Location = new System.Drawing.Point(8, 9);
			this.lblLoggedIn.Name = "lblLoggedIn";
			this.lblLoggedIn.Size = new System.Drawing.Size(115, 20);
			this.lblLoggedIn.TabIndex = 1;
			this.lblLoggedIn.Text = "Logged in as: ";
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblUser.Location = new System.Drawing.Point(129, 9);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(62, 20);
			this.lblUser.TabIndex = 2;
			this.lblUser.Text = "<user>";
			// 
			// btnLogOut
			// 
			this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnLogOut.Location = new System.Drawing.Point(809, 12);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(110, 53);
			this.btnLogOut.TabIndex = 3;
			this.btnLogOut.Text = "Log out";
			this.btnLogOut.UseVisualStyleBackColor = true;
			this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
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
			this.Controls.Add(this.btnLogOut);
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
			this.TabCategories.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCategoryTable)).EndInit();
			this.TabComments.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCommentTable)).EndInit();
			this.TabUserTypes.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvUTTable)).EndInit();
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
		private System.Windows.Forms.Button btnPlaceAdd;
		private System.Windows.Forms.Button btnPlaceEdit;
		private System.Windows.Forms.Button btnPlaceDelete;
		private System.Windows.Forms.Button btnPlaceDetails;
		private System.Windows.Forms.Label lblLoggedIn;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.DataGridView dgvUserTable;
		private System.Windows.Forms.DataGridView dgvInfoTable;
		private System.Windows.Forms.DataGridView dgvPlaceTable;
		private System.Windows.Forms.BindingSource cRUDInformationBindingSource;
		private System.Windows.Forms.TabPage TabCategories;
		private System.Windows.Forms.DataGridView dgvCategoryTable;
		private System.Windows.Forms.Button btnCategoryAdd;
		private System.Windows.Forms.Button btnCategoryEdit;
		private System.Windows.Forms.Button btnCategoryDelete;
		private System.Windows.Forms.Button btnCategoryDetails;
		private System.Windows.Forms.TabPage TabComments;
		private System.Windows.Forms.DataGridView dgvCommentTable;
		private System.Windows.Forms.Button btnCommentCrudEdit;
		private System.Windows.Forms.Button btnCommentCrudDelete;
		private System.Windows.Forms.Button btnCommentCrudDetails;
		private System.Windows.Forms.Button btnLogOut;
		private System.Windows.Forms.TabPage TabUserTypes;
		private System.Windows.Forms.Button btnUTCrudAdd;
		private System.Windows.Forms.Button btnUTCrudEdit;
		private System.Windows.Forms.Button btnUTCrudDelete;
		private System.Windows.Forms.Button btnUTCrudDetails;
		private System.Windows.Forms.DataGridView dgvUTTable;
		private System.Windows.Forms.Button btnCommentCrudAdd;
	}
}