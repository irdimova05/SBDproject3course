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
    public partial class My_properties : Form
    {
        string connectionString = "server = localhost; userid = root; database = properties";
        public My_properties()
        {
            InitializeComponent();
        }

        public void loadMyProperties()
        {
            var user_id = User.getInstance().getId();
            var query = "SELECT properties.id as ID, " +
                "brokers.name AS Broker, " +
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
                "WHERE properties.broker_id = " + "'" + user_id + "'";


            MySqlConnection mySQLconn = new MySqlConnection(connectionString);
            mySQLconn.Open();
            MySqlCommand command = new MySqlCommand(query, mySQLconn);
            MySqlDataReader propertiesRes = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(propertiesRes);
            myPropertiesView.DataSource = dt;
            mySQLconn.Close();
        }

        private void My_properties_Load(object sender, EventArgs e)
        {
            loadMyProperties();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addProperty = new Add_Property(this);
            addProperty.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            //get selected row from myPropertiesView
            var selectedRow = myPropertiesView.SelectedRows[0];
            var propertyId = selectedRow.Cells["ID"].Value.ToString();
            var editProperty = new Edit_Property(this, propertyId);
            editProperty.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var selectedRow = myPropertiesView.SelectedRows[0];
            var propertyId = selectedRow.Cells["ID"].Value.ToString();
            if (propertyId != null)
            {

                var query = "DELETE FROM properties WHERE id = " + "'" + propertyId + "'";

                MySqlConnection mySQLconn = new MySqlConnection(connectionString);
                mySQLconn.Open();
                MySqlCommand command = new MySqlCommand(query, mySQLconn);
                command.ExecuteNonQuery();
                this.loadMyProperties();
            }
        }
    }
}
