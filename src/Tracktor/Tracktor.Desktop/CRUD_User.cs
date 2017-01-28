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
	public partial class CRUDUser : Form
	{
		private UserEntity user;
		private List<RadioButton> userType;

		public CRUDUser()
		{
			InitializeComponent();
			userType = new List<RadioButton>();
			userType.Add(rbUserCrudTypeReg);
			userType.Add(rbUserCrudTypePrem);
			userType.Add(rbUserCrudTypeAdmin);
		}

		public CRUDUser(UserEntity newUser)
		{
			InitializeComponent();
			user = newUser;
		}

		private void CRUDUser_Load(object sender, EventArgs e)
		{

		}

		//RadioButton GetCheckedRadio(Control container) {
		void GetCheckedRadio(List<RadioButton> buttons) {
			foreach (RadioButton radio in buttons)	{
				if (radio != null && radio.Checked)	{
					//return radio;
					Console.WriteLine("Crno vapno s Keftera");
					Console.WriteLine(radio);
					Console.WriteLine("sada je DOSTA pisanja.");
					return;
				}
			}
			Console.WriteLine("Dragi gosti lomimo vam kosti");
		}

		private void btnUserCrudOK_Click(object sender, EventArgs e)
		{
			user.Username = this.tbUserCrudName.Text;
			user.FullName = this.tbUserCrudFullName.Text;
			user.UserTypeId = 0;
			this.GetCheckedRadio(userType);
			this.Close();
		}

		private void btnUserCrudCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
