using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tracktor.Desktop
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
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

			if (tbUsername.Text != "admin" || tbPassword.Text != "pass")
			{
				lblError.Text = "Wrong username/password combination!";
				lblError.Visible = true;
				return;
			}

			else
			{
				lblError.Text = "Login successful! Loading main screen...";
				lblError.Visible = true;
				this.Hide();
				MainForm mainForm = new MainForm();
				mainForm.Show();
			}
		}
	}
}
