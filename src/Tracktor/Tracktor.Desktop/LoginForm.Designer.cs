namespace Tracktor.Desktop
{
	partial class LoginForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnLogin = new System.Windows.Forms.Button();
			this.tbUsername = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblError = new System.Windows.Forms.Label();
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(276, 130);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(114, 33);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Log in";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.button1_Click);
			// 
			// tbUsername
			// 
			this.tbUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Username", true));
			this.tbUsername.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tbUsername.Location = new System.Drawing.Point(165, 47);
			this.tbUsername.Name = "tbUsername";
			this.tbUsername.Size = new System.Drawing.Size(225, 22);
			this.tbUsername.TabIndex = 1;
			this.tbUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(165, 89);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.Size = new System.Drawing.Size(225, 22);
			this.tbPassword.TabIndex = 2;
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(65, 47);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(81, 17);
			this.lblUsername.TabIndex = 3;
			this.lblUsername.Text = "Username: ";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(65, 89);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(77, 17);
			this.lblPassword.TabIndex = 4;
			this.lblPassword.Text = "Password: ";
			this.lblPassword.Click += new System.EventHandler(this.label2_Click);
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.BackColor = System.Drawing.SystemColors.Info;
			this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblError.Location = new System.Drawing.Point(146, 191);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(0, 20);
			this.lblError.TabIndex = 5;
			this.lblError.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// userBindingSource
			// 
			this.userBindingSource.DataSource = typeof(Tracktor.DAL.Database.User);
			// 
			// LoginForm
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 308);
			this.Controls.Add(this.lblError);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbUsername);
			this.Controls.Add(this.btnLogin);
			this.Name = "LoginForm";
			this.Text = "Tracktor Login";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox tbUsername;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.BindingSource userBindingSource;
	}
}

