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
    public partial class carPurchaseForm : Form
    {
        public carPurchaseForm()
        {
            InitializeComponent();
        }
        public void Display()
        {
            dbcar_market.DisplayAndSearch("select p.idpurchase, (select name_brand from brand b inner join (select m.* from model m inner join(select * from car where idcar = chp.car_idcar) c on c.model_idmodel = m.idmodel)m on m.brand_idbrand = b.idbrand), (select m.name_model from model m inner join(select * from car where idcar = chp.car_idcar) c on c.model_idmodel = m.idmodel), chp.amount, chp.cost, p.datetime_p, p.delivery, p.payment, (select name_status from status where idstatus = p.status_idstatus), (select Surname from client where idclient = p.client_idclient), (select Name from client where idclient = p.client_idclient), (select Patronymic from client where idclient = p.client_idclient), (select full_name from manager where idmanager = p.manager_idmanager) from car_has_purchase chp inner join purchase p on chp.purchase_idpurchase = p.idpurchase order by p.idpurchase asc;", dataGridView1);
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
                dbcar_market.Delete_purchase(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                Display();
                return;
            }
        }

        private void carPurchaseForm_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            procedure procedure = new procedure();
            procedure.Show();
        }
    }
}
