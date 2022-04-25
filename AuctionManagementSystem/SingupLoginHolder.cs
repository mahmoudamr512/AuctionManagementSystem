using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuctionManagementSystem
{
    
    public partial class SingupLoginHolder : Form
    {
        Signup signupForm;
        Login loginForm;

        public SingupLoginHolder()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Remove(loginForm);
            loginForm.Close();
            loginForm.Dispose();
            signupForm = new Signup();
            signupForm.TopLevel = false;
            signupForm.AutoScroll = true;
            this.panel1.Controls.Add(signupForm);
            signupForm.Show();
            button1.Enabled = true;
            button2.Enabled = false;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));

        }

        private void SingupLoginHolder_Load(object sender, EventArgs e)
        {
            signupForm = new Signup();
            signupForm.parentForm = this;
            signupForm.TopLevel = false;
            signupForm.AutoScroll = true;
            this.panel1.Controls.Add(signupForm);
            signupForm.Show();
            button2.Enabled = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Remove(signupForm);
            signupForm.Close();
            signupForm.Dispose();
            loginForm = new Login();
            loginForm.parentForm = this;
            loginForm.TopLevel = false;
            loginForm.AutoScroll = true;
            this.panel1.Controls.Add(loginForm);
            loginForm.Show();
            button1.Enabled = false;
            button2.Enabled = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));

        }
    }
}
