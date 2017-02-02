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
	public partial class CRUD_Category : Form
	{
		private CategoryEntity cat;
		private bool readOnly;
		public bool editing { get; set; }

		public CRUD_Category(CategoryEntity newCat)
		{
			InitializeComponent();
			this.cat = newCat;
			btnCategoryCrudOK.DialogResult = DialogResult.None;
			btnCategoryCrudCancel.DialogResult = DialogResult.Cancel;

			#region Initialization
			if (cat.Id != 0) { tbCategoryCrudID.Text = cat.Id.ToString(); }
			else { tbCategoryCrudID.Text = ""; }
			tbCategoryCrudName.Text = cat.Name;
			#endregion

		}

		private void btnCategoryCrudOK_Click(object sender, EventArgs e)
		{
			#region Try to make changes
			if (readOnly) {	this.Close(); }

			if (!isEmpty())
			{
				#region Reading data from form

				cat.Name = tbCategoryCrudName.Text;

				#endregion

				#region Database stuff
				TracktorDb context = new TracktorDb();
				UnitOfWork _unitOfWork;

				if (context != null) { _unitOfWork = new UnitOfWork(context); }
				else { _unitOfWork = new UnitOfWork(); }

				if (editing) {
					_unitOfWork.CategoryRepository.Update(cat, _unitOfWork.Save);
				}
				else {
					cat.Id = _unitOfWork.CategoryRepository.Insert(cat, _unitOfWork.Save);
				}
				#endregion
			}
			#endregion
		}

		private void btnCategoryCrudCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public void makeReadOnly()
		{
			tbCategoryCrudName.Enabled = false;
			readOnly = true;
		}

		private bool isEmpty()
		{
			if (tbCategoryCrudName.TextLength == 0) // tbUserCrudName.TextLength == 0)
			{
				lblCategoryCrudError.Visible = true;
				lblCategoryCrudError.Text = "You must enter a category name!";
				tbCategoryCrudName.Focus();
				return true;
			}

			this.DialogResult = DialogResult.OK;
			return false;
		}
	}

}
