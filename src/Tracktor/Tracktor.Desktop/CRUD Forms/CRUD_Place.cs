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
	public partial class CRUD_Place : Form
	{
		PlaceEntity place;
		private bool readOnly;
		public bool editing { get; set; }

		public CRUD_Place(PlaceEntity newPlace)
		{
			InitializeComponent();
			place = newPlace;

			btnPlaceCrudOK.DialogResult = DialogResult.None;
			btnPlaceCrudCancel.DialogResult = DialogResult.Cancel;

			#region Initialization
			if (place.Id != 0) { tbPlaceCrudID.Text = place.Id.ToString(); }
			else { tbPlaceCrudID.Text = ""; }

			tbPlaceCrudName.Text = place.Name;
			try
			{
				tbPlaceCrudLat.Text = place.Location.Latitude.ToString();
				tbPlaceCrudLon.Text = place.Location.Longitude.ToString();
			} catch(System.NullReferenceException e)
			{
				tbPlaceCrudLat.Text = "";
				tbPlaceCrudLon.Text = "";
			}
			#endregion
		}

		private void btnPlaceCrudOK_Click(object sender, EventArgs e)
		{
			#region Try to make changes
			if (readOnly) { this.Close(); }

			if (!isEmpty())
			{
				#region Reading data from form

				place.Name = tbPlaceCrudName.Text;
				place.Location = new GeoCoordinate(Convert.ToDouble(tbPlaceCrudLat.Text), Convert.ToDouble(tbPlaceCrudLon.Text));

				#endregion
				#region Database stuff
				TracktorDb context = new TracktorDb();
				UnitOfWork _unitOfWork;

				if (context != null) { _unitOfWork = new UnitOfWork(context); }
				else { _unitOfWork = new UnitOfWork(); }

				if (editing)
				{
					_unitOfWork.PlaceRepository.Update(place, _unitOfWork.Save);
				}
				else
				{
					place.Id = _unitOfWork.PlaceRepository.Insert(place, _unitOfWork.Save);
				}
				#endregion
			}
			#endregion
		}

		private void btnPlaceCrudCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		public CRUD_Place makeReadOnly()
		{
			this.tbPlaceCrudName.Enabled = false;
			this.tbPlaceCrudLat.Enabled = false;
			this.tbPlaceCrudLon.Enabled = false;
			readOnly = true;
			return this;
		}

		private bool isEmpty()
		{
			if (tbPlaceCrudName.TextLength == 0)
			{
				lblPlaceCrudError.Visible = true;
				lblPlaceCrudError.Text = "You must enter a place name!";
				return true;
			}
			if (tbPlaceCrudLat.TextLength == 0) 
			{
				lblPlaceCrudError.Visible = true;
				lblPlaceCrudError.Text = "You must enter a place latitude!";
				return true;
			}
			if (tbPlaceCrudLon.TextLength == 0) 
			{
				lblPlaceCrudError.Visible = true;
				lblPlaceCrudError.Text = "You must enter a place longitude!";
				return true;
			}

			this.DialogResult = DialogResult.OK;
			return false;
		}

	}
}
