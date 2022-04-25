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
    public partial class Login : Form
    {
         string orcl = "Data Source=orcl; User Id=scott; Password=tiger;";
        OracleConnection conn;
        public SingupLoginHolder parentForm;

        private string loginCheck(string email, string password) {

            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "PasswordChecker";
            
            command.Parameters.Add("UserEmail", OracleDbType.Varchar2, 200,email, ParameterDirection.Input);

            command.Parameters.Add("uPassword", OracleDbType.Varchar2, 255).Direction = ParameterDirection.Output;
            command.Parameters.Add("uAccountType", OracleDbType.Varchar2, 255).Direction = ParameterDirection.Output;

            MessageBox.Show(email);
            try
            {
                command.ExecuteNonQuery();
                string pass = command.Parameters["uPassword"].Value.ToString();

                if (pass.Trim() != password)
                {
                    MessageBox.Show("Incorrect Password!");
                    return null;
                }
                else
                {
                    return command.Parameters["uAccountType"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            return null;
        }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            conn = new OracleConnection(orcl);
            conn.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Please Enter your email and password");
            }
            else
            {
                
                string type = loginCheck(textBox3.Text, textBox4.Text);

                type = type.Trim();

                if (type != null) { 
                    if (type == "Seller")
                    {
                        parentForm.Hide();
                        SellerDashboard sd = new SellerDashboard();
                        sd.ShowDialog();
                        parentForm.Close();
                    } else if (type == "Buyer") {
                        parentForm.Hide();
                        BuyerDashboard sd = new BuyerDashboard();
                        sd.ShowDialog();
                        parentForm.Close();
                    } else
                    {
                        
                    }
                }
            }
        }
    }
}
