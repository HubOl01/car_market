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
    class Manager
    {
        public string full_name { get; set; }
        public string phone { get; set; }

        public Manager(string full_name, string phone)
        {
            this.full_name = full_name;
            this.phone = phone;
        }
    }
}
