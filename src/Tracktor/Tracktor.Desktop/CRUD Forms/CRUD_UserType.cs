using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tracktor.DAL.Database;
using Tracktor.DAL.UnitOfWork;
using Tracktor.Domain;

namespace Tracktor.Desktop.CRUD_Forms
{
	public partial class CRUD_UserType : Form
	{
		private UserTypeEntity ut;
		private bool readOnly;
		public bool editing { get; set; }

		public CRUD_UserType(UserTypeEntity newUt)
		{
			InitializeComponent();
			ut = newUt;

			btnUTCrudOK.DialogResult = DialogResult.None;
			btnUTCrudCancel.DialogResult = DialogResult.Cancel;

			#region Initialization
			if (ut.Id != 0) { tbUTCrudID.Text = ut.Id.ToString(); }
			else { tbUTCrudID.Text = ""; }
			tbUTCrudType.Text = ut.Type;
			#endregion
		}

		private void btnUTCrudOK_Click(object sender, EventArgs e)
		{
			#region Try to make changes
			if (readOnly) { this.Close(); }

			if (!isEmpty())
			{
				#region Reading data from form

				ut.Type = tbUTCrudType.Text;

				#endregion

				#region Database stuff
				TracktorDb context = new TracktorDb();
				UnitOfWork _unitOfWork;

				if (context != null) { _unitOfWork = new UnitOfWork(context); }
				else { _unitOfWork = new UnitOfWork(); }

				if (editing)
				{
					_unitOfWork.UserTypeRepository.Update(ut, _unitOfWork.Save);
				}
				else
				{
					ut.Id = _unitOfWork.UserTypeRepository.Insert(ut, _unitOfWork.Save);
				}
				#endregion
			}
			#endregion

		}

		private void btnUTCrudCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public void makeReadOnly()
		{
			tbUTCrudType.Enabled = false;
			readOnly = true;
		}

		private bool isEmpty()
		{
			if (tbUTCrudType.TextLength == 0)
			{
				lblUTCrudError.Visible = true;
				lblUTCrudError.Text = "You must enter user type name!";
				return true;
			}

			this.DialogResult = DialogResult.OK;
			return false;
		}
	}
}
