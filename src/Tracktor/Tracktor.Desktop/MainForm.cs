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

namespace Tracktor.Desktop
{
	public partial class MainForm : Form
	{
		private BindingList<UserEntity> AllUsers;
		private BindingList<InfoEntity> AllInfos;
		private BindingList<PlaceEntity> AllPlaces;
		BindingList<CustomPlace> viewPlaces;

		public MainForm()
		{
			InitializeComponent();

		}


		private void MainForm_Load(object sender, EventArgs e)
		{
			LoadUserData();
			LoadInfoData();
			LoadPlaceData();
			CreateUserGrid();
			CreateInfoGrid();
			CreatePlaceGrid();
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

		#endregion

		#region User-related buttons

		private void btnUserAdd_Click(object sender, EventArgs e)
		{
			//rowindex?
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
			UserEntity tmpUser = AllUsers.ElementAt(userIndex);

			CRUD_User crudUser = new CRUD_User(tmpUser);
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
			CRUD_Information crudInfo = new CRUD_Information(info);
			crudInfo.Show();
		}

		private void btnInfoEdit_Click(object sender, EventArgs e)
		{
			// Dodat da prikaže za trenutno odabranu informaciju
			//CRUD_Information crudInfo = new CRUD_Information(infos);
			//crudInfo.Show();
		}

		private void btnInfoDetails_Click(object sender, EventArgs e)
		{

			// Dodat da prikaže za trenutno odabranu informaciju
			//CRUD_Information crudInfo = (new CRUD_Information(infos)).makeReadOnly();
			//crudInfo.Show();
		}

		#endregion
		#region Place-related buttons

		private void btnLocationAdd_Click(object sender, EventArgs e)
		{
			PlaceEntity place = new PlaceEntity();
			CRUD_Place crudPlace = new CRUD_Place(place);
			crudPlace.Show();
		}

		private void btnLocationEdit_Click(object sender, EventArgs e)
		{
			// Dodat da prikaže za trenutno odabrano mjesto
			//CRUD_Place crudPlace = new CRUD_Place(places);
			//crudPlace.Show();
		}

		private void btnLocationDetails_Click(object sender, EventArgs e)
		{
			//CRUD_Place crudPlace = (new CRUD_Place(places)).makeReadOnly();
			//crudPlace.Show();
		}

		#endregion

		private void dgvInfoTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//BindingSource
			//Kakav je ovo relikt
		}

		
	}
}
