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
		private bool readOnly;

		public CRUD_User(UserEntity user)
		{
			InitializeComponent();
			readOnly = false;

			this.user = user;
			{
				if (user.Id != 0)
				{
					tbUserCrudUID.Text = user.Id.ToString();
				}
				else
				{
					tbUserCrudUID.Text = "";
				}

				tbUserCrudFullName.Text = user.FullName;
				tbUserCrudName.Text = user.Username;
			}

			switch (user.UserTypeId)
			{
				case 1: rbUserCrudTypeAdmin.Checked = true;
					break;
				case 2: rbUserCrudTypePrem.Checked = true;
					break;
				case 3: rbUserCrudTypeReg.Checked = true;
					break;
				default: rbUserCrudTypeReg.Checked = true; //select regular by default
					break;
			}
			userType = new List<RadioButton>();
			userType.Add(rbUserCrudTypeAdmin);
			userType.Add(rbUserCrudTypePrem);
			userType.Add(rbUserCrudTypeReg);

		}

		private void CRUDUser_Load(object sender, EventArgs e)
		{

		}


		private void btnUserCrudOK_Click(object sender, EventArgs e)
		{
			if (!readOnly)
			{
				//UserEntity userr = ServiceFactory.getUserServices().Get(5);
				user.FullName = tbUserCrudFullName.Text;
				user.Username = tbUserCrudName.Text;

				int i = 1;
				foreach (RadioButton radio in userType)
				{
					if (radio.Checked == true)
					{
						user.UserTypeId = i;
						break;
					}
					++i;
				}
			}

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
			readOnly = true;
			return this;

		}
	}
}
