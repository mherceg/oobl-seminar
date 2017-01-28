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
		public MainForm()
		{
			InitializeComponent();
			this.mockUsers = new List<UserEntity>();
			this.newUser = new UserEntity();

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
	}
}
