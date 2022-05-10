using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBDproject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = label1;

            this.username.Enter += RemoveText;
            this.username.Leave += AddText;
            this.password.Enter += RemoveText;
            this.password.Leave += AddText;

        }

        User user = User.getInstance();
        public void RemoveText(object sender, EventArgs e)
        {
            if (sender == this.username && this.username.Text == "Username")
            {
                this.username.Text = "";
            }
            else if (sender == this.password && this.password.Text == "Password")
            {
                this.password.Text = "";
                this.password.PasswordChar = '*';
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (sender == this.username && string.IsNullOrEmpty(this.username.Text))
            {
                this.username.Text = "Username";
            }
            else if (sender == this.password && string.IsNullOrEmpty(this.password.Text))
            {
                this.password.Text = "Password";
                this.password.PasswordChar = '\0';
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "server = localhost; userid = root; database = properties";
            MySqlConnection mySQLconn = new MySqlConnection(connectionString);

            try
            {
                mySQLconn.Open();
                
                MySqlCommand cmd = new MySqlCommand("SELECT id FROM brokers WHERE username='" + username.Text + "' AND password= '" + password.Text + "'", mySQLconn);
                

                MySqlDataReader res = cmd.ExecuteReader();
            

                if (!res.HasRows) { MessageBox.Show("Грешни потребителски данни! Моля, опитайте отново! "); res.Close(); return; }
                else
                {
                    while (res.Read())
                    {
                        user.setId(res.GetInt32("id"));
                    }
                    this.Hide();
                    var realEstate = new Real_Estate();
                    realEstate.Closed += (s, args) => this.Close();
                    realEstate.Show();

                }
                res.Close();            
            }

            catch (Exception exception)
            {
                Console.WriteLine("Error: {0}", exception.ToString());
            }
            finally
            {
                if (mySQLconn != null)
                {
                    mySQLconn.Close();
                }
            }            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var register = new Register();
            register.Closed += (s, args) => this.Close();
            register.Show();

        }

    }
}
