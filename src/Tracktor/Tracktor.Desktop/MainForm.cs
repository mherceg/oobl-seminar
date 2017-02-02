using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using Tracktor.Domain;
using Tracktor.Business;
using Tracktor.Business.Interface;
using Tracktor.Business.Implementation;
using Tracktor.WebService.Models;
using Tracktor.DAL.Database;
using Tracktor.DAL.Repositories;
using Tracktor.Desktop.CRUD_Forms;

namespace Tracktor.Desktop
{
	public partial class MainForm : Form
	{
		private BindingList<UserEntity> AllUsers;
		private BindingList<InfoEntity> AllInfos;
		private BindingList<PlaceEntity> AllPlaces;
		private BindingList<CategoryEntity> AllCategories;
		private BindingList<CommentEntity> AllComments;
		private BindingList<UserTypeEntity> AllUserTypes;

		private UserEntity login;

		BindingList<CustomPlace> viewPlaces;

		public MainForm()
		{
			InitializeComponent();
			login = new UserEntity();
			login.Id = 1;
			login.Username = "testing";
			lblUser.Text = login.Username;
		}

		public MainForm(UserEntity login)
		{
			InitializeComponent();
			this.login = login;
			lblUser.Text = login.Username;
		}


		private void MainForm_Load(object sender, EventArgs e)
		{
			LoadUserData();
			LoadInfoData();
			LoadPlaceData();
			LoadCategoryData();
			LoadCommentData();
			LoadUserTypeData();

			CreateUserGrid();
			CreateInfoGrid();
			CreatePlaceGrid();
			CreateCategoryGrid();
			CreateCommentGrid();
			CreateUserTypeGrid();
		}

		#region Loading data and filling datagridview
		private void CreateUserGrid()
		{
			dgvUserTable.AutoGenerateColumns = false;

			DataGridViewTextBoxColumn UserIdCol = new DataGridViewTextBoxColumn();
			UserIdCol.DataPropertyName = "Id";
			UserIdCol.HeaderText = "User ID";
			UserIdCol.Name = "UserId";
			UserIdCol.Width = 50;
			dgvUserTable.Columns.Add(UserIdCol);

			DataGridViewTextBoxColumn UserNameCol = new DataGridViewTextBoxColumn();
			UserNameCol.DataPropertyName = "Username";
			UserNameCol.HeaderText = "Username";
			UserNameCol.Name = "Username";
			dgvUserTable.Columns.Add(UserNameCol);

			DataGridViewTextBoxColumn FullNameCol = new DataGridViewTextBoxColumn();
			FullNameCol.DataPropertyName = "FullName";
			FullNameCol.HeaderText = "Full Name";
			FullNameCol.Name = "FullNameCol";
			dgvUserTable.Columns.Add(FullNameCol);

			DataGridViewTextBoxColumn ActiveCol = new DataGridViewTextBoxColumn();
			ActiveCol.DataPropertyName = "IsActive";
			ActiveCol.HeaderText = "Is Active";
			ActiveCol.Name = "IsActiveCol";
			ActiveCol.Width = 50;
			dgvUserTable.Columns.Add(ActiveCol);

			DataGridViewTextBoxColumn UserTypeCol = new DataGridViewTextBoxColumn();
			UserTypeCol.DataPropertyName = "UserTypeId";
			UserTypeCol.HeaderText = "User Type ID";
			UserTypeCol.Name = "UserTypeId";
			dgvUserTable.Columns.Add(UserTypeCol);

			dgvUserTable.DataSource = AllUsers;
		}

		private void CreateInfoGrid()
		{
			dgvInfoTable.AutoGenerateColumns = false;

			DataGridViewTextBoxColumn InfoIdCol = new DataGridViewTextBoxColumn();
			InfoIdCol.DataPropertyName = "Id";
			InfoIdCol.HeaderText = "Information ID";
			InfoIdCol.Name = "InfoId";
			InfoIdCol.Width = 50;
			dgvInfoTable.Columns.Add(InfoIdCol);

			DataGridViewTextBoxColumn InfoTimeCol = new DataGridViewTextBoxColumn();
			InfoTimeCol.DataPropertyName = "time";
			InfoTimeCol.HeaderText = "Start Time";
			InfoTimeCol.Name = "InfoTime";
			dgvInfoTable.Columns.Add(InfoTimeCol);

			DataGridViewTextBoxColumn InfoEndTimeCol = new DataGridViewTextBoxColumn();
			InfoEndTimeCol.DataPropertyName = "endTime";
			InfoEndTimeCol.HeaderText = "End Time";
			InfoEndTimeCol.Name = "InfoEndTime";
			dgvInfoTable.Columns.Add(InfoEndTimeCol);

			DataGridViewTextBoxColumn InfoContentCol = new DataGridViewTextBoxColumn();
			InfoContentCol.DataPropertyName = "content";
			InfoContentCol.HeaderText = "Content";
			InfoContentCol.Name = "InfoContent";
			InfoContentCol.Width = 200;
			dgvInfoTable.Columns.Add(InfoContentCol);

			DataGridViewTextBoxColumn InfoUserIdCol = new DataGridViewTextBoxColumn();
			InfoUserIdCol.DataPropertyName = "userId";
			InfoUserIdCol.HeaderText = "User ID";
			InfoUserIdCol.Name = "InfoUserId";
			InfoUserIdCol.Width = 50;
			dgvInfoTable.Columns.Add(InfoUserIdCol);

			DataGridViewTextBoxColumn InfoPlaceIdCol = new DataGridViewTextBoxColumn();
			InfoPlaceIdCol.DataPropertyName = "placeId";
			InfoPlaceIdCol.HeaderText = "Place ID";
			InfoPlaceIdCol.Name = "InfoPlaceId";
			InfoPlaceIdCol.Width = 50;
			dgvInfoTable.Columns.Add(InfoPlaceIdCol);

			DataGridViewTextBoxColumn InfoCategoryIdCol = new DataGridViewTextBoxColumn();
			InfoCategoryIdCol.DataPropertyName = "categoryId";
			InfoCategoryIdCol.HeaderText = "Category ID";
			InfoCategoryIdCol.Name = "InfoCategoryId";
			InfoCategoryIdCol.Width = 50;
			dgvInfoTable.Columns.Add(InfoCategoryIdCol);

			dgvInfoTable.DataSource = AllInfos;
		}

		private void CreatePlaceGrid()
		{
			viewPlaces = new BindingList<CustomPlace>();
			foreach (PlaceEntity place in AllPlaces)
			{
				viewPlaces.Add(new CustomPlace(place));
			}

			dgvPlaceTable.AutoGenerateColumns = false;

			DataGridViewTextBoxColumn PlaceIdCol = new DataGridViewTextBoxColumn();
			PlaceIdCol.DataPropertyName = "Id";
			PlaceIdCol.HeaderText = "Place ID";
			PlaceIdCol.Name = "PlaceId";
			dgvPlaceTable.Columns.Add(PlaceIdCol);

			DataGridViewTextBoxColumn PlaceNameCol = new DataGridViewTextBoxColumn();
			PlaceNameCol.DataPropertyName = "Name";
			PlaceNameCol.HeaderText = "Place Name";
			PlaceNameCol.Name = "PlaceName";
			dgvPlaceTable.Columns.Add(PlaceNameCol);

			DataGridViewTextBoxColumn PlaceLatCol = new DataGridViewTextBoxColumn();
			PlaceLatCol.DataPropertyName = "Latitude";
			PlaceLatCol.HeaderText = "Latitude";
			PlaceLatCol.Name = "PlaceLat";
			dgvPlaceTable.Columns.Add(PlaceLatCol);

			DataGridViewTextBoxColumn PlaceLonCol = new DataGridViewTextBoxColumn();
			PlaceLonCol.DataPropertyName = "Longitude";
			PlaceLonCol.HeaderText = "Longitude";
			PlaceLonCol.Name = "PlaceLon";
			dgvPlaceTable.Columns.Add(PlaceLonCol);

			dgvPlaceTable.DataSource = viewPlaces;
		}

		private void CreateCategoryGrid()
		{
			dgvCategoryTable.AutoGenerateColumns = false;

			DataGridViewTextBoxColumn CatIdCol = new DataGridViewTextBoxColumn();
			CatIdCol.DataPropertyName = "Id";
			CatIdCol.HeaderText = "Category ID";
			CatIdCol.Name = "CatId";
			dgvCategoryTable.Columns.Add(CatIdCol);

			DataGridViewTextBoxColumn CatNameCol = new DataGridViewTextBoxColumn();
			CatNameCol.DataPropertyName = "Name";
			CatNameCol.HeaderText = "Category Name";
			CatNameCol.Name = "CatName";
			dgvCategoryTable.Columns.Add(CatNameCol);

			dgvCategoryTable.DataSource = AllCategories;
		}

		private void CreateCommentGrid()
		{
			dgvCommentTable.AutoGenerateColumns = false;

			DataGridViewTextBoxColumn CommentIdCol = new DataGridViewTextBoxColumn();
			CommentIdCol.DataPropertyName = "Id";
			CommentIdCol.HeaderText = "Comment ID";
			CommentIdCol.Name = "CommentId";
			dgvCommentTable.Columns.Add(CommentIdCol);

			DataGridViewTextBoxColumn CommentTimeCol = new DataGridViewTextBoxColumn();
			CommentTimeCol.DataPropertyName = "EndTime";
			CommentTimeCol.HeaderText = "Time";
			CommentTimeCol.Name = "CommentTime";
			dgvCommentTable.Columns.Add(CommentTimeCol);

			DataGridViewTextBoxColumn CommentContentCol = new DataGridViewTextBoxColumn();
			CommentContentCol.DataPropertyName = "Content";
			CommentContentCol.HeaderText = "Content";
			CommentContentCol.Name = "CommentContent";
			CommentContentCol.Width = 200;
			dgvCommentTable.Columns.Add(CommentContentCol);

			DataGridViewTextBoxColumn CommentUserIdCol = new DataGridViewTextBoxColumn();
			CommentUserIdCol.DataPropertyName = "UserId";
			CommentUserIdCol.HeaderText = "User ID";
			CommentUserIdCol.Name = "CommentUserId";
			dgvCommentTable.Columns.Add(CommentUserIdCol);

			DataGridViewTextBoxColumn CommentInfoIdCol = new DataGridViewTextBoxColumn();
			CommentInfoIdCol.DataPropertyName = "ContentInfoId";
			CommentInfoIdCol.HeaderText = "Info ID";
			CommentInfoIdCol.Name = "CommentInfoId";
			dgvCommentTable.Columns.Add(CommentInfoIdCol);

			dgvCommentTable.DataSource = AllComments;
		}

		private void CreateUserTypeGrid()
		{
			dgvUTTable.AutoGenerateColumns = false;

			DataGridViewTextBoxColumn UserTypeIdCol = new DataGridViewTextBoxColumn();
			UserTypeIdCol.DataPropertyName = "Id";
			UserTypeIdCol.HeaderText = "UserType ID";
			UserTypeIdCol.Name = "UserTypeId";
			dgvUTTable.Columns.Add(UserTypeIdCol);

			DataGridViewTextBoxColumn UserTypeTypeCol = new DataGridViewTextBoxColumn();
			UserTypeTypeCol.DataPropertyName = "Type";
			UserTypeTypeCol.HeaderText = "User Type";
			UserTypeTypeCol.Name = "UserTypeType";
			dgvUTTable.Columns.Add(UserTypeTypeCol);

			dgvUTTable.DataSource = AllUserTypes;
		}

		private void LoadUserData()
		{
			TracktorDb context = new TracktorDb();
			UserRepository userRepo = new UserRepository(context);
			List<UserEntity> users = userRepo.GetAll().ToList();
			AllUsers = new BindingList<UserEntity>(users);
			
		}

		private void LoadInfoData()
		{
			TracktorDb context = new TracktorDb();
			InfoRepository infoRepo = new InfoRepository(context);
			List<InfoEntity> infos = infoRepo.GetAll().ToList();
			AllInfos = new BindingList<InfoEntity>(infos);
		}

		private void LoadPlaceData()
		{
			TracktorDb context = new TracktorDb();
			PlaceRepository placeRepo = new PlaceRepository(context);
			List<PlaceEntity> places = placeRepo.GetAll().ToList();
			AllPlaces = new BindingList<PlaceEntity>(places);
		}

		private void LoadCategoryData()
		{
			TracktorDb context = new TracktorDb();
			CategoryRepository catRepo = new CategoryRepository(context);
			List<CategoryEntity> cats = catRepo.GetAll().ToList();
			AllCategories = new BindingList<CategoryEntity>(cats);
		}

		private void LoadCommentData()
		{
			TracktorDb context = new TracktorDb();
			CommentRepository commentRepo = new CommentRepository(context);
			List<CommentEntity> comments = commentRepo.GetAll().ToList();
			AllComments = new BindingList<CommentEntity>(comments);
		}

		private void LoadUserTypeData()
		{
			TracktorDb context = new TracktorDb();
			UserTypeRepository UserTypeRepo = new UserTypeRepository(context);
			List<UserTypeEntity> UserTypes = UserTypeRepo.GetAll().ToList();
			AllUserTypes = new BindingList<UserTypeEntity>(UserTypes);
		}
		#endregion

		#region User-related buttons

		private void btnUserAdd_Click(object sender, EventArgs e)
		{
			UserEntity user = new UserEntity();
			CRUD_User crudUser = new CRUD_User(user);
			crudUser.ShowDialog();
			if (crudUser.DialogResult == DialogResult.OK)
			{
				AllUsers.Add(user); 
				dgvUserTable.Invalidate();
			}
		}

		private void btnUserEdit_Click(object sender, EventArgs e)
		{
			int userIndex = dgvUserTable.CurrentCell.RowIndex;
			UserEntity user = AllUsers.ElementAt(userIndex);

			CRUD_User crudUser = new CRUD_User(user);
			crudUser.editing = true;
			crudUser.ShowDialog();

			if (crudUser.DialogResult == DialogResult.OK)
			{
				dgvUserTable.InvalidateRow(userIndex);
			}
			
		}

		private void btnUserDetails_Click(object sender, EventArgs e)
		{
			int userIndex = dgvUserTable.CurrentCell.RowIndex;
			UserEntity user = AllUsers.ElementAt(userIndex);
			CRUD_User crudUser = new CRUD_User(user);
			crudUser.makeReadOnly();
			crudUser.Show();
		}

		private void btnUserDelete_Click(object sender, EventArgs e)
		{
			int userIndex = dgvUserTable.CurrentCell.RowIndex;
			UserEntity user = AllUsers.ElementAt(userIndex);
			PestForm areYouSure = new PestForm(user);

			areYouSure.ShowDialog();

			if (areYouSure.DialogResult == DialogResult.Yes)
			{
				dgvUserTable.Rows.RemoveAt(userIndex);
				dgvUserTable.Invalidate();
			}
		}

		#endregion
		#region Info-related buttons

		private void btnInfoAdd_Click(object sender, EventArgs e)
		{
			InfoEntity info = new InfoEntity();
			CRUD_Information crudInfo = new CRUD_Information(info, login.Id);
			crudInfo.ShowDialog();
			if (crudInfo.DialogResult == DialogResult.OK)
			{
				AllInfos.Add(info);
				dgvInfoTable.Invalidate();
			}
		}

		private void btnInfoEdit_Click(object sender, EventArgs e)
		{
			int infoIndex = dgvInfoTable.CurrentCell.RowIndex;
			InfoEntity info = AllInfos.ElementAt(infoIndex);

			CRUD_Information crudInfo = new CRUD_Information(info, login.Id);
			crudInfo.editing = true;
			crudInfo.ShowDialog();

			if (crudInfo.DialogResult == DialogResult.OK)
			{
				dgvInfoTable.InvalidateRow(infoIndex);
			}
		}

		private void btnInfoDetails_Click(object sender, EventArgs e)
		{
			int infoIndex = dgvInfoTable.CurrentCell.RowIndex;
			InfoEntity info = AllInfos.ElementAt(infoIndex);
			CRUD_Information crudInfo = new CRUD_Information(info, login.Id);
			crudInfo.makeReadOnly();
			crudInfo.Show();
		}

		private void btnInfoDelete_Click(object sender, EventArgs e)
		{
			int infoIndex = dgvInfoTable.CurrentCell.RowIndex;
			InfoEntity info = AllInfos.ElementAt(infoIndex);
			PestForm areYouSure = new PestForm(info);

			areYouSure.ShowDialog();

			if (areYouSure.DialogResult == DialogResult.Yes)
			{
				dgvInfoTable.Rows.RemoveAt(infoIndex);
				dgvInfoTable.Invalidate();
			}
		}

		#endregion
		#region Place-related buttons

		private void btnPlaceAdd_Click(object sender, EventArgs e)
		{
			PlaceEntity place = new PlaceEntity();
			CRUD_Place crudPlace = new CRUD_Place(place);
			crudPlace.ShowDialog();

			if (crudPlace.DialogResult == DialogResult.OK)
			{
				AllPlaces.Add(place);
				dgvPlaceTable.Invalidate();
			}
		}

		private void btnPlaceEdit_Click(object sender, EventArgs e)
		{
			int placeIndex = dgvPlaceTable.CurrentCell.RowIndex;
			PlaceEntity place = AllPlaces.ElementAt(placeIndex);
			CRUD_Place crudPlace = new CRUD_Place(place);

			crudPlace.editing = true;
			crudPlace.ShowDialog();

			if (crudPlace.DialogResult == DialogResult.OK)
			{
				dgvPlaceTable.InvalidateRow(placeIndex);
			}
		}

		private void btnPlaceDetails_Click(object sender, EventArgs e)
		{
			int placeIndex = dgvPlaceTable.CurrentCell.RowIndex;
			PlaceEntity place = AllPlaces.ElementAt(placeIndex);
			CRUD_Place crudPlace = new CRUD_Place(place);
			crudPlace.makeReadOnly();
			crudPlace.Show();
		}

		private void btnPlaceDelete_Click(object sender, EventArgs e)
		{
			int placeIndex = dgvPlaceTable.CurrentCell.RowIndex;
			PlaceEntity place = AllPlaces.ElementAt(placeIndex);
			PestForm areYouSure = new PestForm(place);

			areYouSure.ShowDialog();

			if (areYouSure.DialogResult == DialogResult.Yes)
			{
				dgvPlaceTable.Rows.RemoveAt(placeIndex);
				dgvPlaceTable.Invalidate();
			}
		}
		#endregion
		#region Category-related buttons
		private void btnCategoryAdd_Click(object sender, EventArgs e)
		{
			CategoryEntity cat = new CategoryEntity();
			CRUD_Category crudCat = new CRUD_Category(cat);
			crudCat.ShowDialog();
			if (crudCat.DialogResult == DialogResult.OK)
			{
				AllCategories.Add(cat);
				dgvCategoryTable.Invalidate();
			}
		}

		private void btnCategoryEdit_Click(object sender, EventArgs e)
		{
			int catIndex = dgvCategoryTable.CurrentCell.RowIndex;
			CategoryEntity cat = AllCategories.ElementAt(catIndex);

			CRUD_Category crudCat = new CRUD_Category(cat);
			crudCat.editing = true;
			crudCat.ShowDialog();

			if (crudCat.DialogResult == DialogResult.OK)
			{
				dgvCategoryTable.InvalidateRow(catIndex);
			}
		}

		private void btnCategoryDetails_Click(object sender, EventArgs e)
		{
			int catIndex = dgvCategoryTable.CurrentCell.RowIndex;
			CategoryEntity cat = AllCategories.ElementAt(catIndex);
			CRUD_Category crudCat = new CRUD_Category(cat);
			crudCat.makeReadOnly();
			crudCat.Show();
		}

		private void btnCategoryDelete_Click(object sender, EventArgs e)
		{
			int catIndex = dgvCategoryTable.CurrentCell.RowIndex;
			CategoryEntity cat = AllCategories.ElementAt(catIndex);
			PestForm areYouSure = new PestForm(cat);

			areYouSure.ShowDialog();

			if (areYouSure.DialogResult == DialogResult.Yes)
			{
				dgvCategoryTable.Rows.RemoveAt(catIndex);
				dgvCategoryTable.Invalidate();
			}
		}
		#endregion
		#region Comment-related buttons

		private void btnCommentCrudAdd_Click(object sender, EventArgs e)
		{
			CommentEntity comment = new CommentEntity();
			CRUD_Comment crudComment = new CRUD_Comment(comment, login.Id);
			crudComment.ShowDialog();
			if (crudComment.DialogResult == DialogResult.OK)
			{
				AllComments.Add(comment);
				dgvCommentTable.Invalidate();
			}

		}

		private void btnCommentCrudEdit_Click(object sender, EventArgs e)
		{
			int commentIndex = dgvCommentTable.CurrentCell.RowIndex;
			CommentEntity comment = AllComments.ElementAt(commentIndex);
			CRUD_Comment crudComment = new CRUD_Comment(comment);

			crudComment.ShowDialog();

			if (crudComment.DialogResult == DialogResult.OK)
			{
				dgvCommentTable.InvalidateRow(commentIndex);
			}
		}

		private void btnCommentCrudDetails_Click(object sender, EventArgs e)
		{
			int commentIndex = dgvCommentTable.CurrentCell.RowIndex;
			CommentEntity comment = AllComments.ElementAt(commentIndex);
			CRUD_Comment crudComment = new CRUD_Comment(comment);
			crudComment.makeReadOnly();
			crudComment.Show();
		}

		private void btnCommentCrudDelete_Click(object sender, EventArgs e)
		{
			int commentIndex = dgvCommentTable.CurrentCell.RowIndex;
			CommentEntity comment = AllComments.ElementAt(commentIndex);
			PestForm areYouSure = new PestForm(comment);

			areYouSure.ShowDialog();

			if (areYouSure.DialogResult == DialogResult.Yes)
			{
				dgvCommentTable.Rows.RemoveAt(commentIndex);
				dgvCommentTable.Invalidate();
			}
		}
		#endregion




		private void btnUTCrudAdd_Click(object sender, EventArgs e)
		{
			UserTypeEntity ut = new UserTypeEntity();
			CRUD_UserType crudUT = new CRUD_UserType(ut);
			crudUT.ShowDialog();
			if (crudUT.DialogResult == DialogResult.OK)
			{
				AllUserTypes.Add(ut);
				dgvUTTable.Invalidate();
			}
		}

		private void btnUTCrudEdit_Click(object sender, EventArgs e)
		{
			int userTypeIndex = dgvUTTable.CurrentCell.RowIndex;
			UserTypeEntity userType = AllUserTypes.ElementAt(userTypeIndex);

			CRUD_UserType crudUserType = new CRUD_UserType(userType);
			crudUserType.editing = true;
			crudUserType.ShowDialog();

			if (crudUserType.DialogResult == DialogResult.OK)
			{
				dgvUTTable.InvalidateRow(userTypeIndex);
			}
		}

		private void btnUTCrudDetails_Click(object sender, EventArgs e)
		{
			int userTypeIndex = dgvUTTable.CurrentCell.RowIndex;
			UserTypeEntity userType = AllUserTypes.ElementAt(userTypeIndex);
			CRUD_UserType crudUserType = new CRUD_UserType(userType);
			crudUserType.makeReadOnly();
			crudUserType.Show();
		}

		private void btnUTCrudDelete_Click(object sender, EventArgs e)
		{
			int userTypeIndex = dgvUTTable.CurrentCell.RowIndex;
			UserTypeEntity userType = AllUserTypes.ElementAt(userTypeIndex);
			PestForm areYouSure = new PestForm(userType);

			areYouSure.ShowDialog();

			if (areYouSure.DialogResult == DialogResult.Yes)
			{
				dgvUTTable.Rows.RemoveAt(userTypeIndex);
				dgvUTTable.Invalidate();
			}
		}


		private void btnLogOut_Click(object sender, EventArgs e)
		{
			PestForm areYouSure = new PestForm();
			areYouSure.ShowDialog();
			if(areYouSure.DialogResult == DialogResult.Yes)
			{
				this.Close();
			}
		}

	}
}
