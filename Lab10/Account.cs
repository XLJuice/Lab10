using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class Account
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ID { get; set; }
        public double Telephone { get; set; }
        public string Onhand { get; set; }
        public string Toreturn { get; set; }
        public bool Allow { get; set; }

        public Account()
        {
        }
        public Account(string name, string surname, int id,
        double telephone, string onhand, string toreturn,
        bool allow)
        {
            Name = name;
            Surname = surname;
            ID = id;
            Telephone = telephone;
            Toreturn = toreturn;
            Onhand = onhand;
            Allow = allow;
        }
    }
}
