using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace SBDproject
{
    public partial class Delete_Property : Form
    {
        string connectionString = "server = localhost; userid = root; database = properties";
        User user = User.getInstance();
        My_properties pr;
        public Delete_Property(My_properties pr)
        {
            InitializeComponent();
            this.pr = pr;
        }

        private void Delete_Property_Load(object sender, EventArgs e)
        {
            MySqlConnection mySQLconn = new MySqlConnection(connectionString);

            try
            {
                /*-----OPEN MYSQL CONNECTION-----*/
                mySQLconn.Open();

                /*-----IDS-----*/
                MySqlCommand command = new MySqlCommand("SELECT id FROM properties WHERE broker_id = " + "'" + user.getId() + "'", mySQLconn);
                MySqlDataReader propertiesRes = command.ExecuteReader();
                var propertiesList = new List<ComboBoxItem>();
                while (propertiesRes.Read())
                {
                    propertiesList.Add(new ComboBoxItem() { name = propertiesRes.GetInt32(0).ToString(), value = propertiesRes.GetInt32(0) });
                }

                var bindingSource = new BindingSource();
                bindingSource.DataSource = propertiesList;
                id.DataSource = bindingSource.DataSource;
                id.DisplayMember = "name";
                id.ValueMember = "value";
                propertiesRes.Close();

                /*-----CLOSE MYSQL CONNECTION-----*/
                mySQLconn.Close();

            }

            catch (Exception exception)
            {
                Console.WriteLine("Error: {0}", exception.ToString());
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var property_id = ((ComboBoxItem)id.SelectedItem).value;
            if (property_id != null)
            {

                var query = "DELETE FROM properties WHERE id = " + "'" + property_id + "'";

                MySqlConnection mySQLconn = new MySqlConnection(connectionString);
                mySQLconn.Open();
                MySqlCommand command = new MySqlCommand(query, mySQLconn);
                command.ExecuteNonQuery();
                pr.loadMyProperties();
                this.Close();
            }
            else
            {
                MessageBox.Show("Fill all fields!");
            }
        }
    }
}
