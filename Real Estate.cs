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
    public partial class Real_Estate : Form
    {
        string connectionString = "server = localhost; userid = root; database = properties";
        public Real_Estate()
        {
            InitializeComponent();
        }
        private void OnSelectionChanged(object sender, EventArgs e)  
        {  
            if (cityBox.SelectedItem != null)
            {
                MySqlConnection mySQLconn = new MySqlConnection(connectionString);  
                mySQLconn.Open();
                try
                {
                    MySqlCommand command = new MySqlCommand("SELECT id, name FROM neighborhoods where city_id = " + "'" + ((ComboBoxItem) cityBox.SelectedItem).value + "'", mySQLconn);
                    MySqlDataReader neighborhoodRes = command.ExecuteReader();
                    var neighborhoodList = new List<ComboBoxItem>();
                    while (neighborhoodRes.Read())
                    {
                        neighborhoodList.Add(new ComboBoxItem() { name = neighborhoodRes.GetString(1), value = neighborhoodRes.GetInt32(0) });
                    }

                    var bindingSource1 = new BindingSource();
                    bindingSource1.DataSource = neighborhoodList;
                    NeighborhoodBox.DataSource = bindingSource1.DataSource;
                    NeighborhoodBox.DisplayMember = "name";
                    NeighborhoodBox.ValueMember = "value";
                    neighborhoodRes.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                }
                mySQLconn.Close();
            }
        }

        private void Real_Estate_Load(object sender, EventArgs e)
        {
            var priceList = new List<ComboBoxItem>();
            priceList.Add(new ComboBoxItem() { name = "0 - 10,000", value = 10000 });
            priceList.Add(new ComboBoxItem() { name = "10,001 - 20,000", value = 20000 });
            priceList.Add(new ComboBoxItem() { name = "20,001 - 30,000", value = 30000 });
            priceList.Add(new ComboBoxItem() { name = "30,001 - 40,000", value = 40000 });
            priceList.Add(new ComboBoxItem() { name = "40,001 - 50,000", value = 50000 });
            priceList.Add(new ComboBoxItem() { name = "50,001 - 60,000", value = 60000 });
            priceList.Add(new ComboBoxItem() { name = "60,001 - 70,000", value = 70000 });
            priceList.Add(new ComboBoxItem() { name = "70,001 - 80,000", value = 80000 });
            priceList.Add(new ComboBoxItem() { name = "80,001 - 90,000", value = 90000 });
            priceList.Add(new ComboBoxItem() { name = "90,001 - 100,000", value = 100000 });
            var bindingSource = new BindingSource();
            bindingSource.DataSource = priceList;
            PriceBox.DataSource = bindingSource.DataSource;
            PriceBox.DisplayMember = "name";
            PriceBox.ValueMember = "value";

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
                typeBox.DataSource = bindingSource1.DataSource;
                typeBox.DisplayMember = "name";
                typeBox.ValueMember = "value";
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
                cityBox.DataSource = bindingSource2.DataSource;
                cityBox.DisplayMember = "name";
                cityBox.ValueMember = "value";

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
                FacingBox.DataSource = bindingSource3.DataSource;
                FacingBox.DisplayMember = "name";
                FacingBox.ValueMember = "value";
                facingRes.Close();  
                /*-----CLOSE MYSQL CONNECTION-----*/
                mySQLconn.Close();

            }

            catch (Exception exception)
            {
                Console.WriteLine("Error: {0}", exception.ToString());
            }
        }

        private void myPropertiesButton_Click(object sender, EventArgs e)
        {
            var myProperties = new My_properties();
            myProperties.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var type_id = ((ComboBoxItem)typeBox.SelectedItem).value;
            var neighborhood_id = ((ComboBoxItem)NeighborhoodBox.SelectedItem).value;
            var facing_id = ((ComboBoxItem)FacingBox.SelectedItem).value;
            var price = ((ComboBoxItem)PriceBox.SelectedItem).value;
            var forSale = saleCheckbox.Checked;
            var forRent = rentCheckbox.Checked;
            var query = "SELECT brokers.name AS Broker, " +
                "cities.name AS City, " +
                "neighborhoods.name AS Neighborhood, " +
                "types.name AS Type, " +
                "facings.name AS Facing, " +
                "saletype.typename AS 'Sale type', " +
                "price AS Price " +
                "FROM properties " +
                "JOIN brokers ON brokers.id = properties.broker_id " +
                "JOIN neighborhoods ON neighborhoods.id = properties.neighborhood_id " +
                "JOIN cities ON cities.id = neighborhoods.city_id " +
                "JOIN types ON types.id = properties.type_id " +
                "JOIN facings ON facings.id = properties.facing_id " +
                "JOIN saletype ON saletype.id = properties.saletype_id " +
                "WHERE properties.type_id = " + "'" + type_id + "'" + " AND " +
                "properties.neighborhood_id = " + "'" + neighborhood_id + "'" + " AND " +
                "properties.facing_id = " + "'" + facing_id + "'" + " AND " +
                "properties.price BETWEEN " + (price - 9999) + " AND " + price;

            if (forSale || forRent)
            {
                if (forSale && forRent)
                {
                    query += " AND (properties.saletype_id = " + "'" + 2 + "'" + " OR " + " properties.saletype_id = " + "'" + 1 + "')";
                }
                else
                {
                    if (forSale)
                    {
                        query += " AND properties.saletype_id = " + "'" + 2 + "'";
                    }

                    else if (forRent)
                    {
                        query += " AND properties.saletype_id = " + "'" + 1 + "'";
                    }
                }
            }

            MySqlConnection mySQLconn = new MySqlConnection(connectionString);
            mySQLconn.Open();
            MySqlCommand command = new MySqlCommand(query, mySQLconn);
            MySqlDataReader propertiesRes = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(propertiesRes);
            propertiesView.DataSource = dt;
            mySQLconn.Close();
        }
    }
}
