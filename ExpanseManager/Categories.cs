using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpanseManager
{
    public abstract class Categories
    {
        string name;
        string description;
        double balance = 0;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Balance { get => balance; set => balance = value; }
    }

    public class ProfitCategory : Categories
    {
        private List<Transaction> profits = new List<Transaction>();

        public List<Transaction> Profits { get => profits; set => profits = value; }

        public ProfitCategory(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public ProfitCategory(string name, string description, Transaction[] profits)
        {
            Profits.AddRange(profits);
            Name = name;
            Description = description;
        }

        public void AddProfit(string proftitName, double profitSumm, string profitDescription)
        {
            Transaction profit = new Transaction(proftitName, profitDescription, profitSumm);
            Profits.Add(profit);
            Balance += profitSumm;
        }

        public void PrintInfo()
        {
            int i = 0;
            Console.WriteLine("\tПрибутки за категорiєю {0}, {1}", Name, Description);
            if (Profits != null)
                foreach (Transaction item in Profits)
                {
                    Console.WriteLine("Прибуток №{0} - {1} на суму {2}, {3}", ++i, item.Name, item.Summ, item.Description);
                }
        }

    }

    public class ExpanceCategory : Categories
    {
        private List<Transaction> expances = new List<Transaction>();

        public List<Transaction> Expances { get => expances; set => expances = value; }

        public ExpanceCategory(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public ExpanceCategory(string name, string description, Transaction[] expances)
        {
            Expances.AddRange(expances);
            Name = name;
            Description = description;
        }



        public void AddExpance(string expanceName, double expanceSumm, string expanceDescription)
        {
            Transaction expance = new Transaction(expanceName, expanceDescription, expanceSumm);
            expances.Add(expance);
            Balance -= expanceSumm;
        }

        public void PrintInfo()
        {
            int i = 0;
            Console.WriteLine("\tВитрати за категорiєю {0}, {1}", Name, Description);
            if (Expances != null)
                foreach (Transaction item in Expances)
                {
                    Console.WriteLine("Витрата №{0} - {1} на суму {2}, {3}", ++i, item.Name, item.Summ, item.Description);
                }
        }
    }
}
