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

        public void FindUser(string login, string password)
        {
            Expanses db = new Expanses();
            var userQuery = db.Userr.Where(u => u.login == login && u.password == password).ToList();
            if(userQuery.Count != 0)
            {
                Userr user = (Userr)userQuery[0];
                accounts = db.Account.Where(a => a.user_id == user.user_id).ToList();
            }
            else
            {
                throw new EntryPointNotFoundException();
            }
            
            

        }


        public static bool IsUserVacant(string login, string email)
        {
            Expanses db = new Expanses();
            var user = db.Userr.Where(u => u.login == login && u.email == email).ToList();
            if (user.Count == 0) return true;
            else return false;
            //Userr us = (User)user[0];
            

        }

        public static void AddUser(Userr user)
        {
            Expanses db = new Expanses();
            db.Userr.Add(user);
            db.SaveChangesAsync();
        }


    }
}
