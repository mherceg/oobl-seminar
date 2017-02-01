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
	public partial class CRUD_Comment : Form
	{
		private CommentEntity comment;
		private bool readOnly;
		//public bool editing { get; set; }

		public CRUD_Comment(CommentEntity newComment)
		{
			InitializeComponent();
			this.comment = newComment;

			btnCommentCrudOK.DialogResult = DialogResult.None;
			btnCommentCrudCancel.DialogResult = DialogResult.Cancel;

			#region Initialization
			//if (comment.Id != 0) { tbCommentCrudID.Text = comment.Id.ToString(); }
			//else { tbCommentCrudID.Text = ""; }
			tbCommentCrudID.Text = comment.Id.ToString();
			tbCommentCrudUID.Text = comment.UserId.ToString();
			tbCommentCrudIID.Text = comment.ContentInfoId.ToString();
			tbCommentCrudTime.Text = comment.EndTime.ToString();
			tbCommentCrudContent.Text = comment.Content;
			#endregion
		}

		private void btnCommentCrudOK_Click(object sender, EventArgs e)
		{
			#region Try to make changes
			if (readOnly) { this.Close(); }

			if (!isEmpty())
			{
				#region Reading data from form

				comment.Content = tbCommentCrudContent.Text;

				#endregion

				#region Database stuff
				TracktorDb context = new TracktorDb();
				UnitOfWork _unitOfWork;

				if (context != null) { _unitOfWork = new UnitOfWork(context); }
				else { _unitOfWork = new UnitOfWork(); }

				_unitOfWork.CommentRepository.Update(comment, _unitOfWork.Save);
				#endregion
			}
			#endregion
		}

		private void btnCommentCrudCancel_Click(object sender, EventArgs e)
		{
			this.Close();

		}

		public void makeReadOnly()
		{
			tbCommentCrudContent.Enabled = false;
			readOnly = true;
		}

		private bool isEmpty()
		{
			if (tbCommentCrudContent.TextLength == 0)
			{
				lblCommentCrudError.Visible = true;
				lblCommentCrudError.Text = "You must enter comment content!";
				return true;
			}

			this.DialogResult = DialogResult.OK;
			return false;
		}
	}
}
