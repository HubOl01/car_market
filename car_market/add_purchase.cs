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
    public partial class add_purchase : Form
    {
        public static bool isSuccessed = false;
        public static string idCar;
        //private readonly carsForm _carsForm;
        //public string idcar, idbrand, name_model, price, availability, category, height, width, length, type, engine, idcolor;
        public add_purchase()
        {
            InitializeComponent();
            ForCombobox();
        }
        private void ForCombobox()
        {
            MySqlDataReader reader;
            MySqlConnection con = dbcar_market.GetConnection();
            string sqlstatus = "SELECT name_status FROM status order by idstatus asc";
            MySqlCommand cmdstatus = new MySqlCommand(sqlstatus, con);
            cmdstatus.CommandType = CommandType.Text;
            reader = cmdstatus.ExecuteReader();
            reader.Read();
            while (reader.Read())
            {
                comboBox_status.Items.Add(reader.GetString(0));
            }
            reader.Close();
            // для 
            string sqlclient = "SELECT Surname, Name, Patronymic FROM client order by idclient asc";
            MySqlCommand cmdclient = new MySqlCommand(sqlclient, con);
            cmdclient.CommandType = CommandType.Text;
            reader = cmdclient.ExecuteReader();
            reader.Read();
            while (reader.Read())
            {
                comboBox_client.Items.Add(reader.GetString(0)+" "+ reader.GetString(1) + " " + reader.GetString(2));
            }
            reader.Close();

            string sqlmanager = "SELECT full_name FROM manager order by idmanager asc";
            MySqlCommand cmdmanager = new MySqlCommand(sqlmanager, con);
            cmdmanager.CommandType = CommandType.Text;
            reader = cmdmanager.ExecuteReader();
            reader.Read();
            while (reader.Read())
            {
                comboBox_manager.Items.Add(reader.GetString(0));
            }
            reader.Close();
        }
        public void Clear()
        {
            textBox_car.Text = string.Empty;
            comboBox_client.SelectedIndex = -1;
            comboBox_delivery.SelectedIndex = -1;
            comboBox_manager.SelectedIndex = -1;
            comboBox_payment.SelectedIndex = -1;
            comboBox_status.SelectedIndex = -1;
        }
        //public void UpdateInfo()
        //{
        //    label.Text = "Изменение данных автомобиля";
        //    btn_Save.Text = "Изменить";
        //    comboBox_client.Text = availability;
        //    comboBox_delivery.Text = category;
        //    comboBox_manager.Text = engine;
        //    comboBox_payment.Text = height;
        //    comboBox_status.Text = length;
        //}
        public void SaveInfo()
        {
            label.Text = "Покупка данного автомобиля";
            btn_Save.Text = "Добавить";
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            //if (comboBox_client.SelectedIndex + 1 == 0)
            //{
            //    MessageBox.Show("Вы не выбрали клиента");
            //    return;
            //}
            //if (comboBox_delivery.SelectedIndex + 1 == 0)
            //{
            //    MessageBox.Show("Вы не выбрали тип доставки");
            //    return;
            //}
            //if (comboBox_manager.SelectedIndex + 1 == 0)
            //{
            //    MessageBox.Show("Вы не выбрали менеджера");
            //    return;

            //}
            //if (comboBox_payment.SelectedIndex + 1 == 0)
            //{
            //    MessageBox.Show("Вы не выбрали способ оплаты");
            //    return;
            //}
            //if (comboBox_status.SelectedIndex + 1 == 0)
            //{
            //    MessageBox.Show("Вы не выбрали статус покупки");
            //    return;
            //}
            //if (textBox_car.Text.Trim().Length < 1)
            //{
            //    MessageBox.Show("Нужно ввести больше 3 символов");
            //    return;
            //}
            if (btn_Save.Text == "Добавить")
            {
                //Model model = new Model(textBox_model.Text.Trim(), (comboBox_brand.SelectedIndex + 1).ToString(), textBox_width.Text.Trim(), textBox_height.Text.Trim(), textBox_length.Text.Trim(), textBox_engine.Text.Trim() + " л.с.", textBox_type.Text.Trim(), textBox_category.Text.Trim());
                //Car car = new Car(textBox_price.Text.Trim(), textBox_availability.Text.Trim(), (comboBox_color.SelectedIndex + 1).ToString());

                //dbcar_market.Add_car(model, car);
                Purchase purchase = new Purchase((comboBox_delivery.SelectedItem).ToString(), (comboBox_payment.SelectedItem).ToString(), (comboBox_status.SelectedIndex + 1).ToString(), (comboBox_client.SelectedIndex + 1).ToString(), (comboBox_manager.SelectedIndex + 1).ToString());
                //MessageBox.Show(comboBox_delivery.SelectedText +" "+ comboBox_payment.SelectedText + 1 +" "+ (comboBox_status.SelectedIndex + 1).ToString() +" "+ (comboBox_client.SelectedIndex + 1).ToString() +" "+ (comboBox_manager.SelectedIndex + 1).ToString());
                dbcar_market.Add_purchase(idCar, textBox_car.Text, purchase);
                //_carsForm.Display();
                if (isSuccessed)
                {
                    Clear();
                }
            }
            //if (btn_Save.Text == "Изменить")
            //{
            //    //Model model = new Model(textBox_model.Text.Trim(), (comboBox_brand.SelectedIndex + 1).ToString(), textBox_width.Text.Trim(), textBox_height.Text.Trim(), textBox_length.Text.Trim(), textBox_engine.Text.Trim() + " л.с.", textBox_type.Text.Trim(), textBox_category.Text.Trim());
            //    //Car car = new Car(textBox_price.Text.Trim(), textBox_availability.Text.Trim(), (comboBox_color.SelectedIndex + 1).ToString());
            //    //dbcar_market.Update_car(model, car, idcar);
            //    //_carsForm.Display();
            //    if (isSuccessed)
            //    {
            //        Close();
            //    }
            //}
            //_clients.Display();
        }
    }
}
