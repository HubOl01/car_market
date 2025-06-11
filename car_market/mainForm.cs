using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_market
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void select_button_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = "server=localhost;uid=root;pwd=1234;database=car_market";
                MySqlConnection con = new MySqlConnection(); 
                con.ConnectionString = connStr;
                con.Open();
                string sql = "select * from manager";
                MySqlCommand cmd = new MySqlCommand(sql, con);  
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show(reader["full_name"].ToString());
                }
                con.Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_manager_Click(object sender, EventArgs e)
        {
            managersForm managersForm = new managersForm();
            managersForm.Show();
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            clientsForm clients = new clientsForm();
            clients.Show();
        }

        private void btn_car_Click(object sender, EventArgs e)
        {
            carsForm carsForm = new carsForm();
            carsForm.Show();
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            purchaseForm purchaseForm = new purchaseForm();
            purchaseForm.Show();
        }

        private void btn_carPurchase_Click(object sender, EventArgs e)
        {
            carPurchaseForm carPurchaseForm = new carPurchaseForm();
            carPurchaseForm.Show();
        }
    }
}
