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

namespace Tracktor.Desktop
{
	public partial class CRUD_Place : Form
	{
		PlaceEntity entity;

		public CRUD_Place(PlaceEntity newPlace)
		{
			InitializeComponent();
			entity = newPlace;

		}

		public CRUD_Place makeReadOnly()
		{
			this.tbPlaceCrudName.Enabled = false;
			this.tbPlaceCrudLat.Enabled = false;
			this.tbPlaceCrudLon.Enabled = false;

			return this;

		}


		private void btnPlaceCrudOK_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnPlaceCrudCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
