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
using Tracktor.DAL.GenericRepository;
using Tracktor.DAL.Repositories;
using Tracktor.DAL.UnitOfWork;
using Tracktor.Domain;

namespace Tracktor.Desktop
{
	public partial class CRUD_Information : Form
	{
		private InfoEntity info;
		private bool readOnly;
		public bool editing { get; set; }

		public CRUD_Information(InfoEntity newInfo)
		{
			InitializeComponent();
			readOnly = false;
			editing = false;

			this.info = newInfo;

			#region DateTimePicker formatting
			dtpInfoCrudStartDate.CustomFormat = "DD.MM.YYYY.";
			dtpInfoCrudEndDate.CustomFormat = "DD.MM.YYYY.";
			dtpInfoCrudStartDate.MinDate = Convert.ToDateTime("1.1.2000.").Date;
			dtpInfoCrudStartDate.MaxDate = Convert.ToDateTime("31.12.9998.").Date;
			#endregion

			btnInfoCrudOK.DialogResult = DialogResult.None;
			//btnInfoCrudCancel.DialogResult = DialogResult.Cancel;
			btnInfoCrudCancel.DialogResult = DialogResult.None;

			#region Initialization

			if (info.Id != 0) {	tbInfoCrudID.Text = info.Id.ToString();	}
			else {
				tbInfoCrudID.Text = "";
			}

			SetTimeWithinRange();

			tbInfoCrudContent.Text = info.content;
			dtpInfoCrudStartDate.Value = info.time.Date;
			dtpInfoCrudStartTime.Value = info.time; // ha mozda bu dobro
			dtpInfoCrudEndDate.Value = info.endTime.Date;
			dtpInfoCrudEndTime.Value = info.endTime;
			tbInfoCrudUID.Text = info.userId.ToString();
			tbInfoCrudPID.Text = info.placeId.ToString();
			tbInfoCrudCatID.Text = info.categoryId.ToString();

			#endregion
		}



		private void btnInfoCrudOK_Click(object sender, EventArgs e)
		{
			#region Try to make changes
			if (readOnly)
			{
				this.Close();
			}

			if (!isEmpty())
			{
				#region Reading data from form

				info.content = tbInfoCrudContent.Text;
				info.time = dtpInfoCrudStartDate.Value.Date + dtpInfoCrudStartTime.Value.TimeOfDay;
				info.endTime = dtpInfoCrudEndDate.Value.Date + dtpInfoCrudEndTime.Value.TimeOfDay;
				info.userId = Convert.ToInt32(tbInfoCrudUID.Text);
				info.placeId = Convert.ToInt32(tbInfoCrudPID.Text);
				info.categoryId = Convert.ToInt32(tbInfoCrudCatID.Text);

				#endregion

				#region Database stuff
				TracktorDb context = new TracktorDb();
				UnitOfWork _unitOfWork;

				if (context != null) { _unitOfWork = new UnitOfWork(context); }
				else { _unitOfWork = new UnitOfWork(); }

				if (editing)
				{
					_unitOfWork.InfoRepository.Update(info, _unitOfWork.Save);
				}
				else
				{
					info.Id = _unitOfWork.InfoRepository.Insert(info, _unitOfWork.Save);

				}
				#endregion
			}
			#endregion
		}

		private void btnInfoCrudCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		public CRUD_Information makeReadOnly()
		{
			this.tbInfoCrudContent.Enabled = false;
			this.dtpInfoCrudStartDate.Enabled = false;
			this.tbInfoCrudUID.Enabled = false;
			this.dtpInfoCrudEndDate.Enabled = false;
			this.tbInfoCrudPID.Enabled = false;
			this.tbInfoCrudCatID.Enabled = false;
	
			return this;
		}

		private bool isEmpty()
		{
			if (tbInfoCrudContent.TextLength == 0)	{
				lblInfoCrudError.Visible = true;
				lblInfoCrudError.Text = "You must enter information content!";
				return true;
			}

			if (tbInfoCrudCatID.TextLength == 0)
			{
				lblInfoCrudError.Visible = true;
				lblInfoCrudError.Text = "You must enter the category ID!";
				return true;
			}

			if (tbInfoCrudUID.TextLength == 0)
			{
				lblInfoCrudError.Visible = true;
				lblInfoCrudError.Text = "You must enter the user ID!";
				return true;
			}

			if (tbInfoCrudPID.TextLength == 0)
			{
				lblInfoCrudError.Visible = true;
				lblInfoCrudError.Text = "You must enter the place ID!";
				return true;
			}

			this.DialogResult = DialogResult.OK;
			return false;
		}

		private void SetTimeWithinRange()
		{
			if(info.time < dtpInfoCrudStartDate.MinDate || info.time > dtpInfoCrudStartDate.MaxDate)
			{
				info.time = Convert.ToDateTime("01.02.2017."); // set dates within MinMax range
			}
			if (info.endTime < dtpInfoCrudEndDate.MinDate || info.endTime > dtpInfoCrudEndDate.MaxDate)
			{
				info.endTime = Convert.ToDateTime("01.02.2017."); // set dates within MinMax range
			}
		}

	}

}
