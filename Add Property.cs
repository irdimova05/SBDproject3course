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
    public partial class Add_Property : Form
    {
        string connectionString = "server = localhost; userid = root; database = properties";
        User user = User.getInstance();
        My_properties pr;
        public Add_Property(My_properties pr)
        {
            InitializeComponent();
            this.pr = pr;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var user_id = user.getId();
            var type_id = ((ComboBoxItem)type.SelectedItem).value;
            var neighborhood_id = ((ComboBoxItem)neighborhood.SelectedItem).value;
            var facing_id = ((ComboBoxItem)facing.SelectedItem).value;
            var forSale = radioSale.Checked;
            var forRent = radioRent.Checked;
            if (user_id != null && type_id != null && neighborhood_id != null && facing_id != null && price.Text.Length > 0 && (forSale || forRent))
            {
                var priceVal = Double.Parse(price.Text);

                var query = "INSERT INTO properties (broker_id, neighborhood_id, type_id, facing_id, price, saletype_id)" +
                "VALUES" +
                "(" +
                "'" + user_id + "', " + "'" + neighborhood_id + "', " + "'" + type_id + "', " + "'" + facing_id + "', " + "'" + priceVal + "', ";
                if (forSale)
                {
                    query += "'" + 2 + "')";
                }

                if (forRent)
                {
                    query += "'" + 1 + "')";
                }

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

        private void Add_Property_Load(object sender, EventArgs e)
        {
            MySqlConnection mySQLconn = new MySqlConnection(connectionString);

            try
            {
                /*-----OPEN MYSQL CONNECTION-----*/
                mySQLconn.Open();

                /*-----SALETYPES-----*/
                MySqlCommand command = new MySqlCommand("SELECT * FROM types", mySQLconn);
                MySqlDataReader typesRes = command.ExecuteReader();
                var typesList = new List<ComboBoxItem>();
                while (typesRes.Read())
                {
                    typesList.Add(new ComboBoxItem() { name = typesRes.GetString(1), value = typesRes.GetInt32(0) });
                }

                var bindingSource1 = new BindingSource();
                bindingSource1.DataSource = typesList;
                type.DataSource = bindingSource1.DataSource;
                type.DisplayMember = "name";
                type.ValueMember = "value";
                typesRes.Close();

                /*-----CITIES-----*/
                command.CommandText = "SELECT * FROM cities";
                MySqlDataReader cityRes = command.ExecuteReader();
                var cityList = new List<ComboBoxItem>();
                while (cityRes.Read())
                {
                    cityList.Add(new ComboBoxItem() { name = cityRes.GetString(1), value = cityRes.GetInt32(0) });
                }

                var bindingSource2 = new BindingSource();
                bindingSource2.DataSource = cityList;
                city.DataSource = bindingSource2.DataSource;
                city.DisplayMember = "name";
                city.ValueMember = "value";

                cityRes.Close();

                /*-----FACINGS-----*/
                command.CommandText = "SELECT * FROM facings";
                MySqlDataReader facingRes = command.ExecuteReader();
                var facingList = new List<ComboBoxItem>();
                while (facingRes.Read())
                {
                    facingList.Add(new ComboBoxItem() { name = facingRes.GetString(1), value = facingRes.GetInt32(0) });
                }


                var bindingSource3 = new BindingSource();
                bindingSource3.DataSource = facingList;
                facing.DataSource = bindingSource3.DataSource;
                facing.DisplayMember = "name";
                facing.ValueMember = "value";
                facingRes.Close();
                /*-----CLOSE MYSQL CONNECTION-----*/
                mySQLconn.Close();

            }

            catch (Exception exception)
            {
                Console.WriteLine("Error: {0}", exception.ToString());
            }
        }

        private void OnSelectionChanged(object sender, EventArgs e)
        {
            if (city.SelectedItem != null)
            {
                MySqlConnection mySQLconn = new MySqlConnection(connectionString);
                mySQLconn.Open();
                try
                {
                    MySqlCommand command = new MySqlCommand("SELECT id, name FROM neighborhoods where city_id = " + "'" + ((ComboBoxItem)city.SelectedItem).value + "'", mySQLconn);
                    MySqlDataReader neighborhoodRes = command.ExecuteReader();
                    var neighborhoodList = new List<ComboBoxItem>();
                    while (neighborhoodRes.Read())
                    {
                        neighborhoodList.Add(new ComboBoxItem() { name = neighborhoodRes.GetString(1), value = neighborhoodRes.GetInt32(0) });
                    }

                    var bindingSource1 = new BindingSource();
                    bindingSource1.DataSource = neighborhoodList;
                    neighborhood.DataSource = bindingSource1.DataSource;
                    neighborhood.DisplayMember = "name";
                    neighborhood.ValueMember = "value";
                    neighborhoodRes.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                }
                mySQLconn.Close();
            }
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
