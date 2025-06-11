using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_market
{
    public partial class carsForm : Form
    {
        add_car add_Car;
        public carsForm()
        {
            InitializeComponent();
            add_Car = new add_car(this);
        }
        public void Display()
        {
            dbcar_market.DisplayAndSearch("select cc.idcar, cc.name_brand, cc.name_model, cc.price, cc.availability from (select c.idcar, mm.name_brand, mm.name_model, mm.width, mm.height, mm.length, mm.engine_capacity, mm.body_type, mm.category, c.price, c.availability, c.color_idcolor from (select m.idmodel, b.name_brand, m.name_model, width, height, length, engine_capacity, body_type, category from brand b inner join model m on b.idbrand = m.brand_idbrand) mm inner join car c on mm.idmodel = c.model_idmodel) cc inner join color co on co.idcolor = cc.color_idcolor order by cc.idcar asc;", dataGridView1);
        }

        private void select_button_Click(object sender, EventArgs e)
        {
            add_car add = new add_car(this);
            add.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Display();
                MessageBox.Show("Все работает успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

                carInfoForm carInfo = new carInfoForm(this);
                dbcar_market.DisplayCarInfo(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                
                string sql = "select cc.name_brand, cc.name_model, cc.width, cc.height, cc.length, cc.engine_capacity, cc.body_type, cc.category, cc.price, co.name_color from (select c.idcar, mm.name_brand, mm.name_model, mm.width, mm.height, mm.length, mm.engine_capacity, mm.body_type, mm.category, c.price, c.availability, c.color_idcolor from (select m.idmodel, b.name_brand, m.name_model, width, height, length, engine_capacity, body_type, category from brand b inner join model m on b.idbrand = m.brand_idbrand) mm inner join car c on mm.idmodel = c.model_idmodel) cc inner join color co on co.idcolor = cc.color_idcolor where cc.idcar = @idcar;";
                MySqlConnection con = dbcar_market.GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@idcar", MySqlDbType.VarChar).Value = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                carInfo.name_branddb = reader["name_brand"].ToString();
                carInfo.name_modeldb = reader["name_model"].ToString();
                carInfo.widthdb = reader["width"].ToString();
                carInfo.heightdb = reader["height"].ToString();
                carInfo.lengthdb = reader["length"].ToString();
                carInfo.engine_capacitydb = reader["engine_capacity"].ToString();
                carInfo.body_typedb = reader["body_type"].ToString();
                carInfo.categorydb = reader["category"].ToString();
                carInfo.pricedb = reader["price"].ToString();
                carInfo.name_colordb = reader["name_color"].ToString();
                //MessageBox.Show(reader["name_brand"].ToString());
                reader.Close();
                carInfo.Show();
                con.Close();
                Display();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                add_Car.Clear();
                string sql = "select m.*, c.* from model m inner join car c on m.idmodel = c.model_idmodel where idcar = @idcar";
                MySqlConnection con = dbcar_market.GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@idcar", MySqlDbType.VarChar).Value = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                //carInfo.Show();
                add_Car.idcar = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                add_Car.idbrand = reader["brand_idbrand"].ToString();
                add_Car.name_model = reader["name_model"].ToString();
                add_Car.width = reader["width"].ToString();
                add_Car.height = reader["height"].ToString();
                add_Car.length = reader["length"].ToString();
                add_Car.engine = reader["engine_capacity"].ToString();
                add_Car.type = reader["body_type"].ToString();
                add_Car.category = reader["category"].ToString();
                add_Car.price = reader["price"].ToString();
                add_Car.idcolor = reader["color_idcolor"].ToString();
                add_Car.availability = reader["availability"].ToString();
                add_Car.UpdateInfo();
                add_Car.ShowDialog();
                reader.Close();
                con.Close();
                Display();
                //add_Car.idbrand = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                //add_Car.name_model = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                //add_Car.price = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                //add_Car.avaibility = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                //add_Car.phone = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                //add_Car.address = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                return;
            }
            if (e.ColumnIndex == 2)
            {
                if (MessageBox.Show("Вы хотите удалить данные этого элемента", "Информация", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    dbcar_market.Delete_car(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void carsForm_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Реализация вывода данных представления для расчета суммы всех автомобилей
            MySqlConnection con1 = dbcar_market.GetConnection();
            string sqldrop = "DROP VIEW IF EXISTS SumAllCars;";
            MySqlCommand cmddrop = new MySqlCommand(sqldrop, con1);
            cmddrop.CommandType = CommandType.Text;
            cmddrop.ExecuteNonQuery();
            MySqlConnection con = dbcar_market.GetConnection();
            string sql = "CREATE VIEW SumAllCars AS select sum(cost) from car_has_purchase;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            string sql2 = "select * from SumAllCars;";
            MySqlCommand cmd2 = new MySqlCommand(sql2, con);
            cmd2.CommandType = CommandType.Text;
            MySqlDataReader reader = cmd2.ExecuteReader();
            reader.Read();
            MessageBox.Show("Общая сумма всех автомобилей равна " + reader["sum(cost)"].ToString(), "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reader.Close();

        }
    }
}
