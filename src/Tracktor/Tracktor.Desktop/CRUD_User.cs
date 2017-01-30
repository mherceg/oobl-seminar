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
using Tracktor.Business;
using Tracktor.Business.Interface;
using Tracktor.Business.Implementation;
using Tracktor.WebService.Models;

namespace Tracktor.Desktop
{
	public partial class CRUD_User : Form
	{
		private UserEntity user;
		private List<RadioButton> userType;

		public CRUD_User(UserEntity newUser)
		{
			InitializeComponent();
			user = newUser;

			userType = new List<RadioButton>();
			userType.Add(rbUserCrudTypeReg);
			userType.Add(rbUserCrudTypePrem);
			userType.Add(rbUserCrudTypeAdmin);
		}

		private void CRUDUser_Load(object sender, EventArgs e)
		{

		}


		private void btnUserCrudOK_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnUserCrudCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public CRUD_User makeReadOnly()
		{
			this.tbUserCrudName.Enabled = false;
			this.tbUserCrudFullName.Enabled = false;
			foreach (RadioButton radio in userType)
			{
				radio.Enabled = false;
			}

			return this;

		}
	}
}
