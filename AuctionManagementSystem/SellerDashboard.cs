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
    public partial class SellerDashboard : Form
    {
        Profile userProfile;
        Market marketplace;
        Form activeForm;
        History his;
        public SellerDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.panel1.Controls)
            {
                if (ctr.GetType() == typeof(Button))
                {
                    if (ctr.Name != "button1" )
                    {
                        ctr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
                        ctr.Enabled = true;
                    } else
                    {
                        ctr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
                        ctr.Enabled = false;
                    }
                }
            }
            this.panel1.Controls.Remove(activeForm);
            activeForm.Close();
            activeForm.Dispose();

            userProfile = new Profile();
         
            userProfile.TopLevel = false;
            userProfile.AutoScroll = true;
            this.panel3.Controls.Add(userProfile);
            userProfile.Show();
            activeForm = userProfile;
        }

        private void market_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.panel1.Controls)
            {
                if (ctr.GetType() == typeof(Button))
                {
                    if (ctr.Name != "market")
                    {
                        ctr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
                        ctr.Enabled = true;
                    }
                    else
                    {
                        ctr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
                        ctr.Enabled = false;
                    }
                }

            }
            this.panel1.Controls.Remove(activeForm);
            activeForm.Close();
            activeForm.Dispose();

            marketplace = new Market();

            marketplace.TopLevel = false;
            marketplace.AutoScroll = true;
            this.panel3.Controls.Add(marketplace);
            marketplace.Show();
            activeForm = marketplace;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.panel1.Controls)
            {
                if (ctr.GetType() == typeof(Button))
                {
                    if (ctr.Name != "button2")
                    {
                        ctr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
                        ctr.Enabled = true;
                    }
                    else
                    {
                        ctr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
                        ctr.Enabled = false;
                    }
                }
            }

            this.panel1.Controls.Remove(activeForm);
            activeForm.Close();
            activeForm.Dispose();

            his = new History();

            his.TopLevel = false;
            his.AutoScroll = true;
            this.panel3.Controls.Add(his);
            his.Show();
            activeForm = his;


        }

        private void SellerDashboard_Load(object sender, EventArgs e)
        {
            marketplace = new Market();

            marketplace.TopLevel = false;
            marketplace.AutoScroll = true;
            this.panel3.Controls.Add(marketplace);
            marketplace.Show();
            activeForm = marketplace;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
