using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tracktor.Domain;

namespace Tracktor.Desktop
{
	public partial class MainForm : Form
	{
		List<UserEntity> mockUsers;
		UserEntity newUser;
		InfoEntity newInfo;
		PlaceEntity newPlace;

		public MainForm()
		{
			InitializeComponent();
			this.mockUsers = new List<UserEntity>();
			this.newUser = new UserEntity();
			this.newInfo = new InfoEntity();
			this.newPlace = new PlaceEntity();

		}

		private void MainForm_Load(object sender, EventArgs e)
		{
		}


		private void tabMap_Click(object sender, EventArgs e)
		{

		}

		private void TabUsers_Click(object sender, EventArgs e)
		{

		}

		private void tableInformations_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnUserAdd_Click(object sender, EventArgs e)
		{
			CRUDUser crudUser = new CRUDUser(newUser);
			crudUser.Show();
		}

		private void btnUserEdit_Click(object sender, EventArgs e)
		{
			// Dodat da prikaže za trenutno odabranog usera
			CRUDUser crudUser = new CRUDUser(newUser);
			crudUser.Show();
		}

		private void btnUserDetails_Click(object sender, EventArgs e)
		{
			// Dodat da prikaže za trenutno odabranog usera
			CRUDUser crudUser = (new CRUDUser(newUser)).makeReadOnly();
			crudUser.Show();
		}

		private void btnInfoAdd_Click(object sender, EventArgs e)
		{
			CRUD_Information crudInfo = new CRUD_Information(newInfo);
			crudInfo.Show();
		}

		private void btnInfoEdit_Click(object sender, EventArgs e)
		{
			// Dodat da prikaže za trenutno odabranu informaciju
			CRUD_Information crudInfo = new CRUD_Information(newInfo);
			crudInfo.Show();
		}

		private void btnInfoDetails_Click(object sender, EventArgs e)
		{
			// Dodat da prikaže za trenutno odabranu informaciju
			CRUD_Information crudInfo = (new CRUD_Information(newInfo)).makeReadOnly();
			crudInfo.Show();
		}

		private void btnLocationAdd_Click(object sender, EventArgs e)
		{
			CRUD_Place crudPlace = new CRUD_Place(newPlace);
			crudPlace.Show();
		}

		private void btnLocationEdit_Click(object sender, EventArgs e)
		{
			// Dodat da prikaže za trenutno odabrano mjesto
			CRUD_Place crudPlace = new CRUD_Place(newPlace);
			crudPlace.Show();
		}

		private void btnLocationDetails_Click(object sender, EventArgs e)
		{
			CRUD_Place crudPlace = (new CRUD_Place(newPlace)).makeReadOnly();
			crudPlace.Show();
		}
	}
}
