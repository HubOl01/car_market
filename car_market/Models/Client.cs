using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_market.Models
{
    internal class Client
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string passport { get; set; }
        public string phone { get; set; }
        public string address { get; set; }

        public Client(string surname, string name, string patronymic, string passport, string phone, string address)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            this.passport = passport;
            this.phone = phone;
            this.address = address;
        }
    }
}
