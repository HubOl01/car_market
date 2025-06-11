using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_market.Models
{
    internal class Purchase
    {
        public string delivery { get; set; }
        public string payment { get; set; }
        public string status { get; set; }
        public string client { get; set; }
        public string manager { get; set; }

        public Purchase(string delivery, string payment, string status, string client, string manager)
        {
            this.delivery = delivery;
            this.payment = payment;
            this.status = status;
            this.client = client;
            this.manager = manager;
        }
    }
}
