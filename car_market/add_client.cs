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
    public partial class add_client : Form
    {
        private readonly clientsForm _clients;
        public static bool isSuccessed = false;
        public string idclient, Surname, Name, Patronymic, passport, phone, address;


        public add_client(clientsForm clients)
        {
            InitializeComponent(); 
            _clients = clients;
        }
        public void Clear()
        {
            textBox_Surname.Text = textBox_Name.Text = textBox_Patronymic.Text = textBox_passport.Text = textBox_phone.Text = textBox_address.Text = string.Empty;
        }

        public void UpdateInfo()
        {
            label.Text = "Изменение данных клиента";
            btn_Save.Text = "Изменить";
            textBox_Surname.Text = Surname;
            textBox_Name.Text = Name;
            textBox_Patronymic.Text = Patronymic;
            textBox_passport.Text = passport;
            textBox_phone.Text = phone;
            textBox_address.Text = address; 
        }
        public void SaveInfo()
        {
            label.Text = "Добавление нового клиента";
            btn_Save.Text = "Добавить";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (textBox_Surname.Text.Trim().Length < 3)
            {
                MessageBox.Show("Нужно ввести больше 3 символов");
                return;
            }
            if (textBox_Name.Text.Trim().Length < 3)
            {
                MessageBox.Show("Нужно ввести больше 3 символов");
                return;
            }
            if (textBox_Patronymic.Text.Trim().Length < 3)
            {
                MessageBox.Show("Нужно ввести больше 3 символов");
                return;
            }
            if (textBox_passport.Text.Trim().Length < 3)
            {
                MessageBox.Show("Нужно ввести больше 3 символов");
                return;
            }
            if (textBox_phone.Text.Trim().Length < 3)
            {
                MessageBox.Show("Нужно ввести больше 3 символов");
                return;
            }
            if (textBox_address.Text.Trim().Length < 3)
            {
                MessageBox.Show("Нужно ввести больше 3 символов");
                return;
            }
            if (btn_Save.Text == "Добавить")
            {
                Client client = new Client(textBox_Surname.Text.Trim(), textBox_Name.Text.Trim(), textBox_Patronymic.Text.Trim(), textBox_passport.Text.Trim(), textBox_phone.Text.Trim(), textBox_address.Text.Trim());
                dbcar_market.Add_Client(client);
                if (isSuccessed)
                {
                    Clear();
                }
            }
            if (btn_Save.Text == "Изменить")
            {
                Client client = new Client(textBox_Surname.Text.Trim(), textBox_Name.Text.Trim(), textBox_Patronymic.Text.Trim(), textBox_passport.Text.Trim(), textBox_phone.Text.Trim(), textBox_address.Text.Trim());
                dbcar_market.Update_Client(client, idclient);
            }
            _clients.Display();
            if (isSuccessed)
            {
                Close();
            }
        }
    }
}
