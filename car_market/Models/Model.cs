using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_market.Models
{
    internal class Model
    {
        public string name_model { get; set; }
        public string idbrand { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string length { get; set; }
        public string engine_capacity { get; set; }
        public string body_type { get; set; }
        public string category { get; set; }

        public Model(string name_model, string idbrand, string width, string height, string length, string engine_capacity, string body_type, string category)
        {
            this.name_model = name_model;
            this.idbrand = idbrand;
            this.width = width;
            this.height = height;
            this.length = length;
            this.engine_capacity = engine_capacity;
            this.body_type = body_type;
            this.category = category;
        }
    }
}
