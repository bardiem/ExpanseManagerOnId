using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpanseManager
{
    public class Transaction
    {
        private int id;

        public Transaction(int id)
        {
            this.id = id;
        }

        public int Id { get => id; set => id = value; }

        public moneyTransaction GetInfoFromDB()
        {
            Expanses db = new Expanses();
            var transaction = db.moneyTransaction.Where(t => t.tran_id == Id).FirstOrDefault();
            moneyTransaction mt = transaction;
            return mt;
        }
    }
}
