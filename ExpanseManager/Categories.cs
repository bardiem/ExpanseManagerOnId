using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpanseManager
{
    

    public class Categori
    {

        int id;


        public int Id { get => id; set => id = value; }
        public List<Transaction> Transactions { get => transactions; set => transactions = value; }

        List<Transaction> transactions;
   

        public Categori()
        {
            LoadTransactions();
            Transactions = new List<Transaction>();
        }

        public Categori(int cat_id)
        {
            LoadTransactions();
            Transactions = new List<Transaction>();
            this.id = cat_id;
        }


        private void LoadTransactions()
        {

            foreach (moneyTransaction item in GetTransactionsByType("Прибуток"))
            {
                Transactions.Add(new Transaction(item.tran_id));
            }

            foreach (moneyTransaction item in GetTransactionsByType("Витрата"))
            {
                Transactions.Add(new Transaction(item.tran_id));
            }
        }



        public void AddTransaction(moneyTransaction transaction)
        {

            Expanses db = new Expanses();
            Transactions.Add(new Transaction(transaction.tran_id));
            db.moneyTransaction.Add(transaction);
            db.SaveChanges();

        }


        public List<moneyTransaction> GetTransactionsByType(string type)
        {
            Expanses db = new Expanses();
            List<moneyTransaction> ts = new List<moneyTransaction>();

            var query = db.Transactions.Where(t => t.Category.type == type && t.cat_id == Id).ToList();

            return ts;
        }

        public double GetBalance()
        {
            Expanses db = new Expanses();
            double summ = 0;
            int quantity = 0;

            var query = db.Transactions.Where(t => t.Category.cat_id == Id).ToList();

            foreach (Transactions item in query)
            {
                summ += item.moneyTransaction.amount;
                quantity++;
            }

            return summ / quantity;
        }

    }
}
