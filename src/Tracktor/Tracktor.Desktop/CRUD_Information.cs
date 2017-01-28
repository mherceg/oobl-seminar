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
	public partial class CRUD_Information : Form
	{
		private InfoEntity info;

		public CRUD_Information(InfoEntity newInfo)
		{
			InitializeComponent();
			info = newInfo;
		}

		public CRUD_Information makeReadOnly()
		{
			this.tbInfoCrudContent.Enabled = false;
			this.tbInfoCrudTime.Enabled = false;
			this.tbInfoCrudUID.Enabled = false;
			this.tbInfoCrudEndTime.Enabled = false;
			this.tbInfoCrudPID.Enabled = false; 
	
			return this;

		}

		private void btnInfoCrudOK_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnInfoCrudCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}

}
