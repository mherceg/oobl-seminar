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
		BindingList<UserEntity> users;
		BindingList<InfoEntity> infos;
		BindingList<PlaceEntity> places;

		public MainForm()
		{
			InitializeComponent();
			this.users = new BindingList<UserEntity>();
			this.infos = new BindingList<InfoEntity>();
			this.places = new BindingList<PlaceEntity>();

			//users = ServiceFactory.getUserServices
			//infos = ServiceFactory.getInfoServices().GetByPlace
			//places = ServiceFactory.getPlaceServices().GetAll();

			//foreach (PlaceEntity place in places)
			//{
			//	this.dgvPlaceTable.
			//}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			LoadInfoData();
		}

		private void LoadInfoData()
		{
			TracktorDb context = new TracktorDb();
			InfoRepository infoRepo = new InfoRepository(context);
			List<InfoEntity> tmp = infoRepo.GetAll().ToList();
			infos = new BindingList<InfoEntity>(tmp);
			cRUDInformationBindingSource.DataSource = infos;
			dgvInfoTable.DataSource = infos;



		}

		private void btnUserAdd_Click(object sender, EventArgs e)
		{
			UserEntity user = new UserEntity();
			users.Add(user);
			CRUD_User crudUser = new CRUD_User(user);
			crudUser.Show();
		}

		private void btnUserEdit_Click(object sender, EventArgs e)
		{
			// Dodat da prikaže za trenutno odabranog usera
			//CRUD_User crudUser = new CRUD_User(newUser);
			//crudUser.Show();
		}

		private void btnUserDetails_Click(object sender, EventArgs e)
		{
			// Dodat da prikaže za trenutno odabranog usera
			//CRUD_User crudUser = (new CRUD_User(newUser)).makeReadOnly();
			//crudUser.Show();
		}

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

		private void dgvInfoTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//BindingSource
		}
	}
}
