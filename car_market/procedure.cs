using car_market.Models;
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
    public partial class procedure : Form
    {
        public procedure()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (textBox_1.Text.Trim().Length < 0)
            {
                MessageBox.Show("Вы не ввели номер покупки");
                return;
            }
            if (textBox_2.Text.Trim().Length < 0)
            {
                MessageBox.Show("Вы не ввели сумму");
                return;
            }
            MySqlConnection con = dbcar_market.GetConnection();
            string sql = "drop procedure if exists My_cost;\r\nCREATE PROCEDURE My_cost(IN idpurch VARCHAR(255), IN n_cost DECIMAL(10,2))\r\n    UPDATE car_has_purchase\r\n    SET cost = cost + n_cost\r\n    WHERE purchase_idpurchase = idpurch;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            string sql2 = "call My_cost(@idpurchase, @cost);";
            MySqlCommand cmd2 = new MySqlCommand(sql2, con);
            cmd2.Parameters.Add("@idpurchase", MySqlDbType.VarChar).Value = textBox_1.Text.Trim();
            cmd2.Parameters.Add("@cost", MySqlDbType.VarChar).Value = textBox_2.Text.Trim();
            try
            {
                cmd2.ExecuteNonQuery();
                carPurchaseForm carPurchaseForm = new carPurchaseForm();
                carPurchaseForm.Display();
                MessageBox.Show("Вызов успешно создан.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Вызов не был создан\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
