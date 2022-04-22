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
    public partial class Signup : Form
    {
        public SingupLoginHolder parentForm;
        public Signup()
        {
            InitializeComponent();
        }

    

        public void RemoveText(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        public void AddText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
                textBox1.Text = "Enter text here...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.Hide();
            BuyerDashboard sd = new BuyerDashboard();
            sd.ShowDialog();
            parentForm.Close();
        }
    }
}
