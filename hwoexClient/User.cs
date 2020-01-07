using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwoexClient
{
    public class User
    {

        private Expanses db = new Expanses();

        private List<Account> accounts;






        public void AddAccount(Account acc)
        {
            db.Account.Add(acc);
            db.SaveChangesAsync();

        }

        public void DeleteAccount(string name)
        {

        }

        public static void FindUser(string login, string password)
        {
            Expanses db = new Expanses();
            var user = db.Userr.Where(u => u.login == login && u.password == password).ToList();
            //Userr us = (Userr)user;
            

        }


        public static void AddUser(Userr user)
        {
            Expanses db = new Expanses();
            db.Userr.Add(user);
            db.SaveChangesAsync();
        }


    }
}
