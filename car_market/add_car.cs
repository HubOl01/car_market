using car_market.Models;
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
    public partial class add_car : Form
    {
        public static bool isSuccessed = false;
        private readonly carsForm _carsForm;
        public string idcar, idbrand, name_model, price, availability, category, height, width, length, type, engine, idcolor;
        public add_car(carsForm carsForm)
        {
            InitializeComponent();
            _carsForm = carsForm;
        }
        public void Clear()
        {
            textBox_availability.Text = textBox_category.Text = textBox_engine.Text = textBox_height.Text = textBox_length.Text = textBox_model.Text = textBox_price.Text = textBox_type.Text = textBox_width.Text = string.Empty;
            comboBox_brand.SelectedIndex = -1;
            comboBox_color.SelectedIndex = -1;
        }
        public void UpdateInfo()
        {
            label.Text = "Изменение данных автомобиля";
            btn_Save.Text = "Изменить";
            textBox_availability.Text = availability;
            textBox_category.Text = category;
            textBox_engine.Text = engine;
            textBox_height.Text = height;
            textBox_length.Text = length;
            textBox_model.Text = name_model;
            textBox_price.Text = price;
            textBox_type.Text = type;
            textBox_width.Text = width;
            comboBox_brand.SelectedIndex = int.Parse(idbrand)-1;
            comboBox_color.SelectedIndex = int.Parse(idcolor)-1;
        }
        public void SaveInfo()
        {
            label.Text = "Добавление нового автомобиля";
            btn_Save.Text = "Добавить";
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (comboBox_brand.SelectedIndex + 1 == 0)
            {
                MessageBox.Show("Вы не выбрали марку автомобиля");
                return;
            }
            if (textBox_model.Text.Trim().Length < 1)
            {
                MessageBox.Show("Нужно ввести больше 3 символов");
                return;
            }
            if (textBox_width.Text.Trim().Length < 1)
            {
                MessageBox.Show("Нужно ввести больше 3 символов");
                return;
            }
            if (textBox_length.Text.Trim().Length < 1)
            {
                MessageBox.Show("Нужно ввести больше 3 символов");
                return;
            }
            if (textBox_height.Text.Trim().Length < 1)
            {
                MessageBox.Show("Нужно ввести больше 3 символов");
                return;
            }
            if (textBox_engine.Text.Trim().Length < 1)
            {
                MessageBox.Show("Нужно ввести больше 3 символов");
                return;
            }
            if (textBox_price.Text.Trim().Length < 1)
            {
                MessageBox.Show("Нужно ввести больше 3 символов");
                return;
            }
            if (textBox_type.Text.Trim().Length < 1)
            {
                MessageBox.Show("Нужно ввести больше 3 символов");
                return;
            }
            if (textBox_availability.Text.Trim().Length < 0)
            {
                MessageBox.Show("Нужно ввести больше 3 символов");
                return;
            }
            if (textBox_category.Text.Trim().Length < 1)
            {
                MessageBox.Show("Нужно ввести больше 3 символов");
                return;
            }
            if (comboBox_color.SelectedIndex + 1 == 0)
            {
                MessageBox.Show("Вы не выбрали цвет автомобиля");
                return;
            }
            if (btn_Save.Text == "Добавить")
            {
                    Model model = new Model(textBox_model.Text.Trim(), (comboBox_brand.SelectedIndex + 1).ToString(), textBox_width.Text.Trim(), textBox_height.Text.Trim(), textBox_length.Text.Trim(), textBox_engine.Text.Trim() + " л.с.", textBox_type.Text.Trim(), textBox_category.Text.Trim());
                    Car car = new Car(textBox_price.Text.Trim(), textBox_availability.Text.Trim(), (comboBox_color.SelectedIndex + 1).ToString());
                    dbcar_market.Add_car(model, car);
                    _carsForm.Display();
                if (isSuccessed)
                {
                    Clear();
                }
            }
            if (btn_Save.Text == "Изменить")
            {
                Model model = new Model(textBox_model.Text.Trim(), (comboBox_brand.SelectedIndex + 1).ToString(), textBox_width.Text.Trim(), textBox_height.Text.Trim(), textBox_length.Text.Trim(), textBox_engine.Text.Trim() + " л.с.", textBox_type.Text.Trim(), textBox_category.Text.Trim());
                Car car = new Car(textBox_price.Text.Trim(), textBox_availability.Text.Trim(), (comboBox_color.SelectedIndex + 1).ToString());
                dbcar_market.Update_car(model, car, idcar);
                _carsForm.Display();
                if (isSuccessed)
                {
                    Close();
                }
            }
            //_clients.Display();
        }
    }
}
