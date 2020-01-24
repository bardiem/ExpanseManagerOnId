using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExpanseManager
{
    public class Accounts
    {

        int id;

        List<Categori> profitCategories;
        List<Categori> expanceCategories;



        public List<Categori> ProfitCategories { get => profitCategories; set => profitCategories = value; }
        public List<Categori> ExpanceCategories { get => expanceCategories; set => expanceCategories = value; }


        public int Id { get => id; set => id = value; }


        public Accounts()
        {
            profitCategories = new List<Categori>();
            expanceCategories = new List<Categori>();
            LoadCategoories();
        }

        public Accounts(int id)
        {
            this.id = id;
            profitCategories = new List<Categori>();
            expanceCategories = new List<Categori>();
            LoadCategoories();
            

        }



        private void LoadCategoories()
        {

            foreach (Category item in GetCategoriesByType("Прибуток"))
            {
                profitCategories.Add(new Categori(item.cat_id));
            }

            foreach (Category item in GetCategoriesByType("Витрата"))
            {
                expanceCategories.Add(new Categori(item.cat_id));
            }


        }


        public void AddCategory(Category category)
        {

            Expanses db = new Expanses();

            if (category.type == "Витрата")
            {

                expanceCategories.Add(new Categori(category.cat_id));

            }
            else
            {

                profitCategories.Add(new Categori(category.cat_id));
            }

            db.Category.Add(category);
            db.SaveChanges();

        }


        public List<Category> GetCategoriesByType(string type)
        {
            Expanses db = new Expanses();
            List<Category> categories = new List<Category>();

            var query = db.Transactions.Where(t => t.Category.type == type && t.Account.acc_id == Id).Distinct().ToList();

            foreach (Transactions item in query)
            {
                Category c = new Category();

                c.cat_id = item.Category.cat_id;
                c.name = item.Category.name;
                c.description = item.Category.description;
                c.type = item.Category.type;

                categories.Add(c);
            }

            return categories;
        }



        public DataTable GetTransactionDateTable()
        {
            DataTable dt = new DataTable();

            dt.Clear();
            dt.Columns.Add("Назва транзакції");
            dt.Columns.Add("Опис транзакції");
            dt.Columns.Add("Назва категорії");
            dt.Columns.Add("Тип категорії");
            dt.Columns.Add("Опис категорії");
            dt.Columns.Add("Дата транзації");
            dt.Columns.Add("Сума транзакції");

            

            foreach (Transactions item in GetTransactionsByDate())
            {
                DataRow row = dt.NewRow();

                row["Назва транзакції"] = item.moneyTransaction.name;
                row["Опис транзакції"] = item.moneyTransaction.description;
                row["Назва категорії"] = item.Category.name;
                row["Тип категорії"] = item.Category.type;
                row["Опис категорії"] = item.Category.description;
                row["Дата транзації"] = item.date;
                row["Сума транзакції"] = item.moneyTransaction.amount;

                dt.Rows.Add(row);
            }

            return dt;
        }

        public List<Transactions> GetTransactionsByDate()
        {
            Expanses db = new Expanses();

            var query = db.Transactions.Where(t => t.Account.acc_id == Id).Distinct().ToList();

            return query;
        }


        public double GetInflow()
        {
            double profitAmount = 0;

            foreach (Categori item in ProfitCategories)
            {
                profitAmount += item.GetBalance();
            }

            return profitAmount;
        }

        public double GetOutflow()
        {

            double expansesAmount = 0;


            foreach (Categori item in ExpanceCategories)
            {
                expansesAmount += item.GetBalance();
            }

            return expansesAmount;
        }


        public double GetBalance()
        {

            return GetInflow() - GetOutflow();

        }

        public string GetCurrencySign()
        {
            Expanses db = new Expanses();
            string currency = "";

            var query = db.Transactions.Where(t => t.Account.acc_id == Id).Distinct().ToList();
            foreach (Transactions item in query)
            {
                currency = item.Account.Currency.sign;
            }
            return currency;
        }

    }
}