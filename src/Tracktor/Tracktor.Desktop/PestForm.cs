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

namespace Tracktor.Desktop
{
	public partial class PestForm : Form
	{
		private UserEntity user;

		public PestForm(UserEntity user)
		{
			InitializeComponent();
			this.user = user;
			lblPestDialog.Text = "Are you sure you want to delete user " + user.Username + "?\n This cannot be undone.";


			btnPestYes.DialogResult = DialogResult.Yes;
			btnPestNo.DialogResult = DialogResult.No;
		}

		private void btnPestYes_Click(object sender, EventArgs e)
		{
			TracktorDb context = new TracktorDb();
			UnitOfWork _unitOfWork;

			if (context != null)
			{
				_unitOfWork = new UnitOfWork(context);
			}
			else { _unitOfWork = new UnitOfWork(); }

			int new_id = _unitOfWork.UserRepository.Remove(user, _unitOfWork.Save);
		}
	}
}
