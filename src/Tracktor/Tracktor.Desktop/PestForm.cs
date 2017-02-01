using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tracktor.Business;
using Tracktor.DAL.Database;
using Tracktor.DAL.Repositories;
using Tracktor.DAL.UnitOfWork;
using Tracktor.Domain;

namespace Tracktor.Desktop
{
	public partial class PestForm : Form
	{
		private UserEntity user;
		private InfoEntity info;
		private PlaceEntity place;
		private CategoryEntity cat;
		private CommentEntity comment;
		private UserTypeEntity ut;
		private bool logout = false;

		public PestForm()
		{
			InitializeComponent();
			logout = true;
			lblPestDialog.Text = "Are you sure you want to log out?";
			btnPestYes.DialogResult = DialogResult.Yes;
			btnPestNo.DialogResult = DialogResult.No;
		}

		public PestForm(UserEntity user)
		{
			InitializeComponent();
			this.user = user;
			this.info = null;
			this.place = null;
			lblPestDialog.Text = "Are you sure you want to delete user " + user.Username + "?\n This cannot be undone.";

			btnPestYes.DialogResult = DialogResult.Yes;
			btnPestNo.DialogResult = DialogResult.No;
		}

		public PestForm(UserTypeEntity ut)
		{
			InitializeComponent();
			this.ut = ut;
			lblPestDialog.Text = "Are you sure you want to delete usertype " + ut.Type + "?\n This cannot be undone.";

			btnPestYes.DialogResult = DialogResult.Yes;
			btnPestNo.DialogResult = DialogResult.No;
		}

		public PestForm(InfoEntity info)
		{
			InitializeComponent();
			this.info = info;
			const int MAXLEN = 20;

			if (info.content.Length <= MAXLEN)
			{
				lblPestDialog.Text = "Are you sure you want to delete info \"" + info.content.Substring(0, info.content.Length) + "\"?\n This cannot be undone.";
			}
			else
			{
				lblPestDialog.Text = "Are you sure you want to delete info \"" + info.content.Substring(0, MAXLEN) + "...\"?\n This cannot be undone.";
			}

			btnPestYes.DialogResult = DialogResult.Yes;
			btnPestNo.DialogResult = DialogResult.No;
		}

		public PestForm(PlaceEntity place)
		{
			InitializeComponent();
			this.place = place;
			lblPestDialog.Text = "Are you sure you want to delete place " + place.Name + "?\n This cannot be undone.";

			btnPestYes.DialogResult = DialogResult.Yes;
			btnPestNo.DialogResult = DialogResult.No;
		}


		public PestForm(CategoryEntity cat)
		{
			InitializeComponent();
			this.cat = cat;
			lblPestDialog.Text = "Are you sure you want to delete category " + cat.Name + "?\n This cannot be undone.";

			btnPestYes.DialogResult = DialogResult.Yes;
			btnPestNo.DialogResult = DialogResult.No;
		}

		public PestForm(CommentEntity comment)
		{
			InitializeComponent();
			this.comment = comment;
			const int MAXLEN = 20;

			if (comment.Content.Length <= MAXLEN)
			{
				lblPestDialog.Text = "Are you sure you want to delete comment \"" + comment.Content.Substring(0, comment.Content.Length) + "\"?\n This cannot be done.";
			}
			else
			{
				lblPestDialog.Text = "Are you sure you want to delete comment \"" + comment.Content.Substring(0, MAXLEN) + "...\"?\n This cannot be done.";
			}

			btnPestYes.DialogResult = DialogResult.Yes;
			btnPestNo.DialogResult = DialogResult.No;
		}



		private void btnPestYes_Click(object sender, EventArgs e)
		{
			TracktorDb context = new TracktorDb();
			UnitOfWork _unitOfWork;

			if (logout)
			{
				this.Close();
			}

			if (context != null) { _unitOfWork = new UnitOfWork(context); }
			else { _unitOfWork = new UnitOfWork(); }

			if(user != null)
			{
				_unitOfWork.UserRepository.Remove(user.Id, _unitOfWork.Save);
				return;
			}

			if (ut != null)
			{
				_unitOfWork.UserTypeRepository.Delete(ut.Id, _unitOfWork.Save);
				return;
			}

			if (info != null)
			{
				_unitOfWork.InfoRepository.Remove(info, _unitOfWork.Save);
				return;
			}

			if (place != null)
			{
				_unitOfWork.PlaceRepository.Delete(place.Id, _unitOfWork.Save);
				return;
			}

			if (cat != null)
			{
				_unitOfWork.CategoryRepository.Delete(cat.Id, _unitOfWork.Save);
				return;
			}

			if (comment != null)
			{
				// Treba prvo nekak RepComove izbrisat
				//var comServices = ServiceFactory.getCommentServices();
				//comServices.Delete(comment.Id);
				return;
			}


		}
	}
}
