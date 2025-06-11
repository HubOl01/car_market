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
    class CarInfo
    {
        public string name_brand { get; set; }
        public string name_model { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string length { get; set; }
        public string engine_capacity { get; set; }
        public string body_type { get; set; }
        public string category { get; set; }
        public string price { get; set; }
        public string name_color { get; set; }

        public CarInfo(string name_brand, string name_model, string width, string height, string length, string engine_capacity, string body_type, string category, string price, string name_color)
        {
            this.name_brand = name_brand;
            this.name_model = name_model;
            this.width = width;
            this.height = height;
            this.length = length;
            this.engine_capacity = engine_capacity;
            this.body_type = body_type;
            this.category = category;
            this.price = price;
            this.name_color = name_color;
        }
    }
}
