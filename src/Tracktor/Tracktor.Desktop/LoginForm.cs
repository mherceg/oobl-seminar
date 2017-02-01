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
using Tracktor.Business.Implementation;
using Tracktor.DAL.Database;
using Tracktor.DAL.UnitOfWork;
using Tracktor.Domain;

namespace Tracktor.Desktop
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
			this.ActiveControl = tbUsername;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (tbUsername.Text == "")
			{
				lblError.Text = "Please enter a username!";
				lblError.Visible = true;
				return;
			}

			LoginEntity le = new LoginEntity();
			le.Username = tbUsername.Text;
			le.Password = tbPassword.Text;

			var userService = ServiceFactory.getUserServices();
			int userId;
			try
			{
				userId = userService.Login(le);
			}
			catch (Exception exc)
			{
				lblError.Text = exc.Message;
				lblError.Visible = true;
				return;
			}
			var user = userService.Get(userId);
			if (user.UserTypeId != 1)
			{
				lblError.Text = "You are not an admin!";
				lblError.Visible = true;
				return;
			}

			else
			{
				lblError.Text = "Login successful! Loading main screen...";
				lblError.Visible = true;
				this.Hide();
				MainForm mainForm = new MainForm(user);
				mainForm.ShowDialog();
				lblError.Text = "Logged out!";
				this.Show();
			}

			//if (tbUsername.Text != "admin" || tbPassword.Text != "pass")
			//{
			//	lblError.Text = "Wrong username/password combination!";
			//	lblError.Visible = true;
			//	return;
			//}

			//else
		}
	}
}
