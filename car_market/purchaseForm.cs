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
    public partial class purchaseForm : Form
    {
        public purchaseForm()
        {
            InitializeComponent();
        }
        public void Display()
        {
            dbcar_market.DisplayAndSearch("select cc.idcar, cc.name_brand, cc.name_model, cc.price, cc.availability from (select c.idcar, mm.name_brand, mm.name_model, mm.width, mm.height, mm.length, mm.engine_capacity, mm.body_type, mm.category, c.price, c.availability, c.color_idcolor from (select m.idmodel, b.name_brand, m.name_model, width, height, length, engine_capacity, body_type, category from brand b inner join model m on b.idbrand = m.brand_idbrand) mm inner join car c on mm.idmodel = c.model_idmodel) cc inner join color co on co.idcolor = cc.color_idcolor order by cc.idcar asc;", dataGridView1);
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
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

                
                Display();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                add_purchase purchase = new add_purchase();
                add_purchase.idCar = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                purchase.ShowDialog();
                //add_Car.idbrand = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                //add_Car.name_model = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                //add_Car.price = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                //add_Car.avaibility = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                //add_Car.phone = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                //add_Car.address = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                Display();
                return;
            }
            //if (e.ColumnIndex == 2)
            //{
            //    if (MessageBox.Show("Вы хотите удалить данные этого элемента", "Информация", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            //    {
                    
            //        Display();
            //    }
            //    return;
            //}
        }


        private void purchaseForm_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
}
