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
    public partial class add_managerForm : Form
    {
        private readonly managersForm _managers;
        public static bool isSuccessed = false;
        public string idManager, full_name, phone;
        public add_managerForm(managersForm managers)
        {
            InitializeComponent();
            _managers = managers;
        }
        public void Clear()
        {
            textBox_full_name.Text = textBox_phone.Text = string.Empty;
        }

        public void UpdateInfo()
        {
            ManagerLabel.Text = "Изменение данных менеджера";
            btnManager_Save.Text = "Изменить";
            textBox_full_name.Text = full_name;
            textBox_phone.Text = phone;
        }
        public void SaveInfo()
        {
            ManagerLabel.Text = "Добавление нового менеджера";
            btnManager_Save.Text = "Добавить";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_full_name.Text.Trim().Length < 3 ) {
                MessageBox.Show("Нужно ввести больше 3 символов");
                return;
            }
            if (textBox_phone.Text.Trim().Length < 3)
            {
                MessageBox.Show("Нужно ввести больше 3 символов");
                return;
            }
            if (btnManager_Save.Text == "Добавить")
            {
                Manager manager = new Manager(textBox_full_name.Text.Trim(), textBox_phone.Text.Trim());
                dbcar_market.Add_Manager(manager);
                
                if (isSuccessed)
                {
                    Clear();
                }
            }
            if (btnManager_Save.Text == "Изменить")
            {
                Manager manager = new Manager(textBox_full_name.Text.Trim(), textBox_phone.Text.Trim());
                dbcar_market.Update_Manager(manager, idManager);
                if (isSuccessed)
                {
                    Close();
                }
            }
            _managers.Display();
        }

    }
}
