using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
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

		public CRUD_Information(InfoEntity newInfo, int userId = 0)
		{
			InitializeComponent();
			readOnly = false;
			editing = false;

			this.info = newInfo;

			TracktorDb context = new TracktorDb();
			CategoryRepository catRepo = new CategoryRepository(context);
			List<CategoryEntity> cats = catRepo.GetAll().ToList();
			Dictionary<int, CategoryEntity> allCats = new Dictionary<int, CategoryEntity>();
			foreach (CategoryEntity categ in cats)
			{
				allCats.Add(categ.Id, categ);
				cbInfoCrudCategory.Items.Add(categ);
			}

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

			if (info.Id != 0) { tbInfoCrudID.Text = info.Id.ToString(); }
			else { tbInfoCrudID.Text = ""; }

			if (info.userId != 0) { tbInfoCrudID.Text = info.Id.ToString(); }
			else { tbInfoCrudUID.Text = userId.ToString(); }

			SetTimeWithinRange();

			tbInfoCrudContent.Text = info.content;
			dtpInfoCrudStartDate.Value = info.time.Date;
			dtpInfoCrudStartTime.Value = info.time; 
			dtpInfoCrudEndDate.Value = info.endTime.Date;
			dtpInfoCrudEndTime.Value = info.endTime;
			tbInfoCrudUID.Text = info.userId.ToString();
			tbInfoCrudPID.Text = info.placeId.ToString();

			CategoryEntity cat;
			allCats.TryGetValue(info.categoryId, out cat);
			cbInfoCrudCategory.SelectedItem = cat;

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
				info.categoryId = ((CategoryEntity)cbInfoCrudCategory.SelectedItem).Id;

				#endregion

				#region Database stuff
				TracktorDb context = new TracktorDb();
				UnitOfWork _unitOfWork;

				if (context != null) { _unitOfWork = new UnitOfWork(context); }
				else { _unitOfWork = new UnitOfWork(); }

				try
				{
					if (editing) {
						_unitOfWork.InfoRepository.Update(info, _unitOfWork.Save);
					}
					else {
						info.Id = _unitOfWork.InfoRepository.Insert(info, _unitOfWork.Save);
					}

				} catch (Exception xce)
				{
					this.lblInfoCrudError.Text = "No such category!";
					this.lblInfoCrudError.Visible = true;
					return;
				}
				this.DialogResult = DialogResult.OK;
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
			this.cbInfoCrudCategory.Enabled = false;
	
			return this;
		}

		private bool isEmpty()
		{

			if (tbInfoCrudPID.TextLength == 0)
			{
				lblInfoCrudError.Visible = true;
				lblInfoCrudError.Text = "You must enter the place ID!";
				tbInfoCrudPID.Focus();
				return true;
			}
			if (cbInfoCrudCategory.SelectedItem == null)
			{
				lblInfoCrudError.Visible = true;
				lblInfoCrudError.Text = "You must enter the category!";
				cbInfoCrudCategory.Focus();
				return true;
			}


			if (tbInfoCrudContent.TextLength == 0)	{
				lblInfoCrudError.Visible = true;
				lblInfoCrudError.Text = "You must enter information content!";
				tbInfoCrudContent.Focus();
				return true;
			}
			if ( !timeMakesSense() )
			{	 
				lblInfoCrudError.Visible = true;
				lblInfoCrudError.Text = "Start time must be before end time!";
				dtpInfoCrudStartDate.Focus();
				return true;
			}
			this.DialogResult = DialogResult.OK;
			return false;
		}

		private bool timeMakesSense()
		{
			DateTime startTime = dtpInfoCrudStartDate.Value.Date + dtpInfoCrudStartTime.Value.TimeOfDay;
			DateTime endTime = dtpInfoCrudEndDate.Value.Date + dtpInfoCrudEndTime.Value.TimeOfDay;
			return startTime < endTime;
		}

		private void SetTimeWithinRange()
		{
			if(info.time < dtpInfoCrudStartDate.MinDate || info.time > dtpInfoCrudStartDate.MaxDate)
			{
				info.time = Convert.ToDateTime("01.02.2017. 08:00:00"); // set dates within MinMax range
			}
			if (info.endTime < dtpInfoCrudEndDate.MinDate || info.endTime > dtpInfoCrudEndDate.MaxDate)
			{
				info.endTime = Convert.ToDateTime("01.02.2017. 08:00:00"); // set dates within MinMax range
			}
		}
	}

}
