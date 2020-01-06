using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExpanseManager
{
    class User
    {

        private Expanses db = new Expanses();

        private List<Account> accounts;



        void FindUser(string login, string password)
        {
            
        }


        void AddAccount(Account acc)
        {
            db.Account.Add(acc);
            db.SaveChangesAsync();
        }

        void DeleteAccount(string name)
        {
            
        }
    }
}
