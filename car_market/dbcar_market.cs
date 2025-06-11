using car_market.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_market
{
    class dbcar_market
    {

        // Подключение к mysql
        public static MySqlConnection GetConnection()
        {
            string connStr = "server=localhost;uid=root;pwd=1234;database=car_market";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connStr;
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        // Добавление нового менеджера
        public static void Add_Manager(Manager manager)
        {
            string sql = "insert into manager(full_name, phone) values (@full_name, @phone)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@full_name", MySqlDbType.VarChar).Value = manager.full_name;
            cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = manager.phone;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные успешно добавлены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_managerForm.isSuccessed = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Данные менеджера не добавлены\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                add_managerForm.isSuccessed = false;
            }
            con.Close();
        }

        // Изменение данных менеджера
        public static void Update_Manager(Manager manager, string id)
        {
            string sql = "update manager set full_name = @full_name, phone = @phone where idmanager = @idmanager";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idmanager", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@full_name", MySqlDbType.VarChar).Value = manager.full_name;
            cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = manager.phone;
            try
            {
                cmd.ExecuteNonQuery();
                add_managerForm.isSuccessed = true;
                MessageBox.Show("Данные успешно обновлены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                add_managerForm.isSuccessed = false;
                MessageBox.Show("Данные менеджера не обновлены\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        // Удаление данных менеджера
        public static void Delete_Manager(string id)
        {
            string sql = "delete from manager where idmanager = @idmanager";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idmanager", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные успешно удалены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Данные менеджера не удалось удалить\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        // Добавление нового клиента
        public static void Add_Client(Client client)
        {
            string sql = "INSERT INTO client (Surname, Name, Patronymic, passport, phone, address) values (@Surname, @Name, @Patronymic, @passport, @phone, @address)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = client.Surname;
            cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = client.Name;
            cmd.Parameters.Add("@Patronymic", MySqlDbType.VarChar).Value = client.Patronymic;
            cmd.Parameters.Add("@passport", MySqlDbType.VarChar).Value = client.passport;
            cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = client.phone;
            cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = client.address;

            try
            {
                cmd.ExecuteNonQuery();
                add_client.isSuccessed = true;
                MessageBox.Show("Данные успешно добавлены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Данные клиента не добавлены\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                add_client.isSuccessed = false;
            }
            con.Close();
        }

        // Изменение данных клиента
        public static void Update_Client(Client client, string id)
        {
            string sql = "update client set Surname = @Surname, Name = @Name, Patronymic = @Patronymic, passport = @passport, phone = @phone, address = @address where idclient = @idclient";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idclient", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = client.Surname;
            cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = client.Name;
            cmd.Parameters.Add("@Patronymic", MySqlDbType.VarChar).Value = client.Patronymic;
            cmd.Parameters.Add("@passport", MySqlDbType.VarChar).Value = client.passport;
            cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = client.phone;
            cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = client.address;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные успешно обновлены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_client.isSuccessed = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Данные клиента не обновлены\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                add_client.isSuccessed = false;
            }
            con.Close();
        }

        // Удаление данных клиента
        public static void Delete_Client(string id)
        {
            string sql = "delete from client where idclient = @idclient";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idclient", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные успешно удалены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Данные клиента не удалось удалить\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        // Отображение списка любого запроса
        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
        public static CarInfo _carInfo;

        // Отображение информации автомобиля
        public static void DisplayCarInfo(string id)
        {
            string sql = "select cc.name_brand, cc.name_model, cc.width, cc.height, cc.length, cc.engine_capacity, cc.body_type, cc.category, cc.price, co.name_color from (select c.idcar, mm.name_brand, mm.name_model, mm.width, mm.height, mm.length, mm.engine_capacity, mm.body_type, mm.category, c.price, c.availability, c.color_idcolor from (select m.idmodel, b.name_brand, m.name_model, width, height, length, engine_capacity, body_type, category from brand b inner join model m on b.idbrand = m.brand_idbrand) mm inner join car c on mm.idmodel = c.model_idmodel) cc inner join color co on co.idcolor = cc.color_idcolor where cc.idcar = @idcar;";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idcar", MySqlDbType.VarChar).Value = id;
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            //carInfoForm carInfo = new carInfoForm();
            //carInfo.name_branddb = reader["name_brand"].ToString();
            //carInfo.name_modeldb = reader["name_model"].ToString();
            //carInfo.widthdb = reader["width"].ToString();
            //carInfo.heightdb = reader["height"].ToString();
            //carInfo.lengthdb = reader["length"].ToString();
            //carInfo.engine_capacitydb = reader["engine_capacity"].ToString();
            //carInfo.body_typedb = reader["body_type"].ToString();
            //carInfo.categorydb = reader["category"].ToString();
            //carInfo.pricedb = reader["price"].ToString();
            //carInfo.name_colordb = reader["name_color"].ToString();
            //MessageBox.Show(reader["name_brand"].ToString());
            reader.Close();

            con.Close();
        }

        // Добавление данных нового автомобиля
        public static void Add_car(Model model, Car car)
        {
                MySqlConnection con = GetConnection();
            try
            {
                string sql = "INSERT INTO model (name_model, brand_idbrand, width, height, length, engine_capacity, body_type, category) values (@name_model, @brand_idbrand, @width, @height, @length, @engine_capacity, @body_type, @category)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@name_model", MySqlDbType.VarChar).Value = model.name_model;
                cmd.Parameters.Add("@brand_idbrand", MySqlDbType.VarChar).Value = model.idbrand;
                cmd.Parameters.Add("@width", MySqlDbType.VarChar).Value = model.width;
                cmd.Parameters.Add("@height", MySqlDbType.VarChar).Value = model.height;
                cmd.Parameters.Add("@length", MySqlDbType.VarChar).Value = model.length;
                cmd.Parameters.Add("@engine_capacity", MySqlDbType.VarChar).Value = model.engine_capacity;
                cmd.Parameters.Add("@body_type", MySqlDbType.VarChar).Value = model.body_type;
                cmd.Parameters.Add("@category", MySqlDbType.VarChar).Value = model.category;
                cmd.ExecuteNonQuery();
                //==================================================================
                string sqlselect = "select idmodel from model where name_model = @name_model";
                MySqlCommand cmdselect = new MySqlCommand(sqlselect, con);
                cmdselect.CommandType = CommandType.Text;
                cmdselect.Parameters.Add("@name_model", MySqlDbType.VarChar).Value = model.name_model;
                MySqlDataReader reader = cmdselect.ExecuteReader();
                reader.Read();
                string idmodelcar = reader["idmodel"].ToString();
                reader.Close();
                //==================================================================
                string sql2 = "INSERT INTO car (price, availability, model_idmodel, color_idcolor) values (@price, @availability, @model_idmodel, @color_idcolor)";
                MySqlCommand cmd2 = new MySqlCommand(sql2, con);
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.Add("@price", MySqlDbType.VarChar).Value = car.price;
                cmd2.Parameters.Add("@availability", MySqlDbType.VarChar).Value = car.availability;
                cmd2.Parameters.Add("@model_idmodel", MySqlDbType.VarChar).Value = idmodelcar;
                cmd2.Parameters.Add("@color_idcolor", MySqlDbType.VarChar).Value = car.idcolor;

                cmd2.ExecuteNonQuery();
                MessageBox.Show("Данные успешно добавлены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_car.isSuccessed = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Данные автомобиля не добавлены\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                add_car.isSuccessed = false;
            }
            con.Close();
        }

        // Изменение данных конкретного автомобиля
        public static void Update_car(Model model, Car car, string id)
        {
            MySqlConnection con = GetConnection();
            try
            {
                string sql = "update model set name_model = @name_model, brand_idbrand = @brand_idbrand, width = @width, height = @height, length = @length, engine_capacity = @engine_capacity, body_type = @body_type, category = @category where idmodel = @idmodel";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@name_model", MySqlDbType.VarChar).Value = model.name_model;
                cmd.Parameters.Add("@brand_idbrand", MySqlDbType.VarChar).Value = model.idbrand;
                cmd.Parameters.Add("@width", MySqlDbType.VarChar).Value = model.width;
                cmd.Parameters.Add("@height", MySqlDbType.VarChar).Value = model.height;
                cmd.Parameters.Add("@length", MySqlDbType.VarChar).Value = model.length;
                cmd.Parameters.Add("@engine_capacity", MySqlDbType.VarChar).Value = model.engine_capacity;
                cmd.Parameters.Add("@body_type", MySqlDbType.VarChar).Value = model.body_type;
                cmd.Parameters.Add("@category", MySqlDbType.VarChar).Value = model.category;
                cmd.Parameters.Add("@idmodel", MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
                string sql2 = "update car set price=@price, availability = @availability, model_idmodel = @model_idmodel, color_idcolor = @color_idcolor where idcar = @idcar";
                MySqlCommand cmd2 = new MySqlCommand(sql2, con);
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.Add("@price", MySqlDbType.VarChar).Value = car.price;
                cmd2.Parameters.Add("@availability", MySqlDbType.VarChar).Value = car.availability;
                cmd2.Parameters.Add("@model_idmodel", MySqlDbType.VarChar).Value = id;
                cmd2.Parameters.Add("@color_idcolor", MySqlDbType.VarChar).Value = car.idcolor;
                cmd2.Parameters.Add("@idcar", MySqlDbType.VarChar).Value = id;

                cmd2.ExecuteNonQuery();
                
                MessageBox.Show("Данные успешно обновлены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_car.isSuccessed = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Данные автомобиля не обновлены\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                add_car.isSuccessed = false;
            }
            con.Close();
        }

        // Удаление данных с автомобиля
        public static void Delete_car(string id)
        {
            string sql = "delete from model where idmodel = @idmodel";
            string sql2 = "delete from car where idcar = @idmodel";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlCommand cmd2 = new MySqlCommand(sql2, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idmodel", MySqlDbType.VarChar).Value = id;
            cmd2.Parameters.Add("@idmodel", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Данные успешно удалены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Данные автомобиля не удалось удалить\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        // Покупка автомобиля
        public static void Add_purchase(string idCar, string amount, Purchase purchase)
        {
            MySqlConnection con = GetConnection();
            try
            {
                string sql2 = "INSERT INTO purchase (delivery, payment, status_idstatus, client_idclient, manager_idmanager) values (@delivery, @payment, @status, @client, @manager)";
                MySqlCommand cmd2 = new MySqlCommand(sql2, con);
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.Add("@delivery", MySqlDbType.VarChar).Value = purchase.delivery;
                cmd2.Parameters.Add("@payment", MySqlDbType.VarChar).Value = purchase.payment;
                cmd2.Parameters.Add("@status", MySqlDbType.VarChar).Value = purchase.status;
                cmd2.Parameters.Add("@client", MySqlDbType.VarChar).Value = purchase.client;
                cmd2.Parameters.Add("@manager", MySqlDbType.VarChar).Value = purchase.manager;
                cmd2.ExecuteNonQuery();
               
                //==================================================================
                string sqlselect = "SELECT * FROM purchase ORDER BY idpurchase DESC LIMIT 1";
                MySqlCommand cmdselect = new MySqlCommand(sqlselect, con);
                cmdselect.CommandType = CommandType.Text;
                MySqlDataReader reader = cmdselect.ExecuteReader();
                reader.Read();
                string idpurchase = reader["idpurchase"].ToString();
                reader.Close();
                //==================================================================
                string sql = "INSERT INTO car_has_purchase(car_idcar,purchase_idpurchase,amount,cost) VALUES(@car_idcar, @purchase_idpurchase, @amount, (select (car_has_purchase.amount*price) from car where idcar = car_has_purchase.car_idcar));";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@car_idcar", MySqlDbType.VarChar).Value = idCar;
                cmd.Parameters.Add("@purchase_idpurchase", MySqlDbType.VarChar).Value = idpurchase;
                cmd.Parameters.Add("@amount", MySqlDbType.VarChar).Value = amount;


                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные успешно добавлены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_purchase.isSuccessed = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Данные покупки не удалось добавить\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                add_purchase.isSuccessed = false;
            }
            con.Close();
        }

        // Удаление данных с покупки
        public static void Delete_purchase(string idpurchase)
        {
            MySqlConnection con = GetConnection();
            string sql = "delete from car_has_purchase where purchase_idpurchase = @idpurchase";
            string sql2 = "delete from purchase where idpurchase = @idpurchase";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlCommand cmd2 = new MySqlCommand(sql2, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idpurchase", MySqlDbType.VarChar).Value = idpurchase;
            cmd2.Parameters.Add("@idpurchase", MySqlDbType.VarChar).Value = idpurchase;
            try
            {
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Данные успешно удалены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Данные покупки не удалось удалить\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
