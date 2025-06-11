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
    public partial class managersForm : Form
    {
        add_managerForm add_Manager;
        public managersForm()
        {
            InitializeComponent();
            add_Manager = new add_managerForm(this);
        }
        public void Display()
        {
            dbcar_market.DisplayAndSearch("select idManager, full_name, phone from manager order by idManager asc", dataGridView1);
        }
        private void label1_Click(object sender, EventArgs e)
        {

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

        private void select_button_Click(object sender, EventArgs e)
        {
            add_Manager.SaveInfo();
            add_Manager.Clear();
            add_Manager.ShowDialog();
        }

        private void managersForm_Shown(object sender, EventArgs e)
        {
            Display();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                add_Manager.Clear();
                add_Manager.idManager = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                add_Manager.full_name = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                add_Manager.phone = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                add_Manager.UpdateInfo();
                add_Manager.ShowDialog();
                return;
            }if (e.ColumnIndex == 1) {
                if (MessageBox.Show("Вы хотите удалить данные этого элемента", "Информация", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    dbcar_market.Delete_Manager(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

    }
}
