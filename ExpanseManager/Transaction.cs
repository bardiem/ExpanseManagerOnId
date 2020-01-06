using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpanseManager
{
    public class Transaction
    {
        private string name;
        private string description;
        private string type;
        private double summ;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Summ { get => summ; set => summ = value; }
        public string Type { get => type; set => type = value; }

        public Transaction(string name, string description, double summ)
        {
            Name = name;
            Description = description;
            Summ = summ;
        }

        public void PrintInfo()
        {
            Console.Write("Вам прийшло надходження {0} на суму {1} грн, {2}", Summ, Name, Description);
        }
    }
}
