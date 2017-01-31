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
using Tracktor.DAL.Repositories;
using Tracktor.DAL.Database;
using Tracktor.DAL.UnitOfWork;

namespace Tracktor.Desktop
{
	public partial class CRUD_User : Form
	{
		private UserEntity user;
		private List<RadioButton> userType;
		private bool readOnly;
		public bool editing { get; set; }

		public CRUD_User(UserEntity user)
		{
			InitializeComponent();
			readOnly = false;
			editing = false;

			this.user = user;
			btnUserCrudOK.DialogResult = DialogResult.None;
			btnUserCrudCancel.DialogResult = DialogResult.Cancel;

			userType = new List<RadioButton>();
			userType.Add(rbUserCrudTypeAdmin);
			userType.Add(rbUserCrudTypePrem);
			userType.Add(rbUserCrudTypeReg);

			#region Initialization
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

			if (user.IsActive) { cbUserCrudActive.Checked = true; }
			else { cbUserCrudActive.Checked = false; }

			#endregion
		}

		private void CRUDUser_Load(object sender, EventArgs e)
		{

		}


		private void btnUserCrudOK_Click(object sender, EventArgs e)
		{
			#region Try to make changes
			if (readOnly)
			{
				this.Close();
			}

			if(!isEmpty())
			{
				#region Reading data from form
				user.FullName = tbUserCrudFullName.Text;
				user.Username = tbUserCrudName.Text;
				user.IsActive = cbUserCrudActive.Checked;

				int i = 1;
				foreach (RadioButton radio in userType) { 
					if (radio.Checked == true) { 
						user.UserTypeId = i;
						break;
					}
					++i;
				}
				#endregion

				#region Database stuff
				TracktorDb context = new TracktorDb();
				UnitOfWork _unitOfWork;

				if (context != null) { _unitOfWork = new UnitOfWork(context); }
				else { _unitOfWork = new UnitOfWork(); }

				if (editing) { 
					_unitOfWork.UserRepository.Update(user, _unitOfWork.Save);
				}
				else { 
					user.Password = "pass";
					user.Id = _unitOfWork.UserRepository.Insert(user, _unitOfWork.Save);

				}
				#endregion
			}
			#endregion
		}

		private void btnUserCrudCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public void makeReadOnly()
		{
			this.tbUserCrudName.Enabled = false;
			this.tbUserCrudFullName.Enabled = false;
			this.cbUserCrudActive.Enabled = false;
			foreach (RadioButton radio in userType)
			{
				radio.Enabled = false;
			}
			readOnly = true;

		}

		private bool isEmpty()
		{
			bool empty = false;
			if (tbUserCrudFullName.TextLength == 0) // tbUserCrudName.TextLength == 0)
			{
				lblUserCrudError.Text = "You must enter a full name!";
				empty = true;
			}
			else if (tbUserCrudName.TextLength == 0)
			{
				lblUserCrudError.Text = "You must enter a username!";
				empty = true;
			}

			if (!empty)
			{
				this.DialogResult = DialogResult.OK;
			}
			return empty;
		}
	}
}
