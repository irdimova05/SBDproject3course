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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.ActiveControl = label1;

            this.username.Enter += RemoveText;
            this.username.Leave += AddText;
            this.password.Enter += RemoveText;
            this.password.Leave += AddText;
            this.name.Enter += RemoveText;
            this.name.Leave += AddText;
            this.phoneNumber.Enter += RemoveText;
            this.phoneNumber.Leave += AddText;

        }


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
            else if (sender == this.name && this.name.Text == "Name")
            {
                this.name.Text = "";
            }
            else if (sender == this.phoneNumber && this.phoneNumber.Text == "Phone number")
            {
                this.phoneNumber.Text = "";
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
            else if (sender == this.name && string.IsNullOrEmpty(this.name.Text))
            {
                this.name.Text = "Name";
            }
            else if (sender == this.phoneNumber && string.IsNullOrEmpty(this.phoneNumber.Text))
            {
                this.phoneNumber.Text = "Phone number";
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            string connectionString = "server = localhost; userid = root; database = properties";
            MySqlConnection mySQLconn = new MySqlConnection(connectionString);

            try
            {
                mySQLconn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT id FROM brokers WHERE username='" + username.Text + "'", mySQLconn);


                MySqlDataReader res = cmd.ExecuteReader();
                

                if (res.HasRows) { MessageBox.Show("Потребителското име е заето! Моля опитайте отново."); res.Close(); return; }
                else
                {
                    mySQLconn.Close();
                    MySqlConnection mySQLconn1 = new MySqlConnection(connectionString);
                    mySQLconn1.Open();
                    MySqlCommand cmd1 = new MySqlCommand("INSERT INTO brokers (name, phoneNumber, username, password) VALUES ('" + name.Text + "' ,'" + phoneNumber.Text + "' ,'" + username.Text + "' ,'" + password.Text + "')", mySQLconn1);
                    cmd1.ExecuteNonQuery(); 
                    mySQLconn1.Close();

                    if (MessageBox.Show("Регистрацията е успешна!") == DialogResult.OK)
                    {
                        this.Hide();
                        var login = new Login();
                        login.Closed += (s, args) => this.Close();
                        login.Show();
                    }

                }
                res.Close();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Error: {0}", exception.ToString());
            }
        }
    }
}
