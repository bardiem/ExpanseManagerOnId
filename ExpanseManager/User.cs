
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExpanseManager
{
    public class User
    {

        private int id;
        private List<Accounts> accounts;

        public int Id { get => id; set => id = value; }
        public List<Accounts> Accounts { get => accounts; set => accounts = value; }

        private Expanses db = new Expanses();

        

        public void AddAccount(Account acc)
        {
            accounts.Add(new Accounts(acc.acc_id));

            db.Account.Add(acc);
            db.SaveChanges();
        }

        public void DeleteAccount(int accId)
        {
            Account acc = db.Account.Where(a => a.user_id == id && a.acc_id == accId).FirstOrDefault();
            accounts.Remove(new Accounts(accId));
            db.Account.Remove(acc);
            db.SaveChanges();
        }


        public void EditAccount(Account acc)
        {
            Account newAcc = db.Account.Where(a => a.user_id == id && a.acc_id == acc.acc_id).FirstOrDefault();

            newAcc.curr_id = acc.curr_id;
            newAcc.name = acc.name;
            newAcc.curr_id = acc.curr_id;

            db.SaveChanges();

        }


        public Account[] GetAccounts()
        {
            List<Account> list = new List<Account>();

            foreach (Account it in db.Account.Where(a => a.user_id == id).ToList())
            {
                Account a = new Account();

                a.acc_id = it.acc_id;
                a.curr_id = it.curr_id;
                a.name = it.name;
                a.user_id = it.user_id;
                
                list.Add(a);
            }
            return list.ToArray();
        }



        public void SetUser(string login, string password)
        {

            var userQuery = db.Userr.Where(u => u.login == login && u.password == password).ToList();
            if(userQuery.Count != 0)
            {
                Userr user = (Userr)userQuery[0];
                id = user.user_id;

                //SetupAccounts();
            }
            else
            {
                throw new EntryPointNotFoundException();
            }
            
            

        }

        private void SetupAccounts()
        {
            foreach (Account it in db.Account.Where(a => a.user_id == id).ToList())
            {
                Accounts a = new Accounts();

                a.Id = it.acc_id;
                accounts.Add(a);

            }
        }




        public static bool IsUserVacant(string login, string email)
        {
            Expanses db = new Expanses();
            var user = db.Userr.Where(u => u.login == login && u.email == email).ToList();
            if (user.Count == 0) 
                return true;
            else 
                return false;
        }


        public static void AddUser(Userr user)
        {
            Expanses db = new Expanses();
            db.Userr.Add(user);
            db.SaveChanges();
        }



        public static Currency[] GetCurrencys()
        {
            Expanses db = new Expanses();
            List<Currency> cl = new List<Currency>();
            foreach (Currency it in db.Currency.ToList())
            {
                Currency c = new Currency();
                c.curr_id = it.curr_id;
                c.name = it.name;
                c.sign = it.sign;
                c.country = it.country;
                cl.Add(c);
            }
            return cl.ToArray();
        }


    }

    public class Item
    {
        int key;
        string value;

        public int Key { get => key; set => key = value; }
        public string Value { get => value; set => this.value = value; }
    }
}
