using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AuctionManagementSystem
{
    public partial class Signup : Form
    {
        string orcl = "Data Source=orcl; User Id=scott; Password=tiger;";
        OracleConnection conn;

        public SingupLoginHolder parentForm;
        public Signup()
        {
            InitializeComponent();
        }

    
        private int insertUser()
        {

            // Creating Command Object
            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = "insert into users (Email, Password, First_Name, Last_name, Account_Type, Date_of_birth) values (:email, :password, :first, :last, :type, :dob)";
            
            // Parameters
            command.Parameters.Add("email", textBox3.Text);
            command.Parameters.Add("password", textBox4.Text);
            command.Parameters.Add("first", textBox1.Text);
            command.Parameters.Add("last", textBox2.Text);
            command.Parameters.Add("type", comboBox1.SelectedItem.ToString());
            command.Parameters.Add("dob", dateTimePicker1.Value.Date);

            // Execution of command & returning the result
            int r = command.ExecuteNonQuery();
            return r;
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

            bool canSignUp = true;

            if (textBox5.Text != textBox4.Text)
            {
                MessageBox.Show("Please Enter Matching Password");
                canSignUp = false;
            } else if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.SelectedIndex.ToString() == "") {
                MessageBox.Show("Please make sure to enter all details correctly");
                canSignUp = false;
            } else
            {
                canSignUp = true;
            }

            if (canSignUp)
            {
                try
                {
                    int r = insertUser();

                    if (comboBox1.SelectedIndex.ToString() == "Buyer")
                    {
                        parentForm.Hide();
                        BuyerDashboard sd = new BuyerDashboard();
                        sd.ShowDialog();
                        parentForm.Close();
                    }
                    else
                    {
                        parentForm.Hide();
                        SellerDashboard sd = new SellerDashboard();
                        sd.ShowDialog();
                        parentForm.Close();
                    }
                } catch (Exception ex) {
                    MessageBox.Show("Error, this email is already registered");
                }
            }

        }

        private void Signup_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(orcl);
            conn.Open();
        }

        private void Signup_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Dispose();
        }
    }
}
