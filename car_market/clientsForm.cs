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
    public partial class clientsForm : Form
    {
        add_client add_Client;
        public clientsForm()
        {
            InitializeComponent();
            add_Client = new add_client(this);
        }
        public void Display()
        {
            dbcar_market.DisplayAndSearch("select * from client order by idclient asc", dataGridView1);
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
                add_Client.Clear();
                add_Client.idclient = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                add_Client.Surname = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                add_Client.Name = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                add_Client.Patronymic = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                add_Client.passport = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                add_Client.phone = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                add_Client.address = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                add_Client.UpdateInfo();
                add_Client.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Вы хотите удалить данные этого элемента", "Информация", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    dbcar_market.Delete_Client(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void clientsForm_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void select_button_Click(object sender, EventArgs e)
        {
            add_Client.SaveInfo();
            add_Client.Clear();
            add_Client.ShowDialog();
        }
    }
}
