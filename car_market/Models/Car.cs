using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_market.Models
{
    internal class Car
    {
        public string price { get; set; }
        public string availability { get; set; }
        public string idcolor { get; set; }

        public Car(string price, string availability, string idcolor)
        {
            this.price = price;
            this.availability = availability;
            this.idcolor = idcolor;
        }
    }
}
