using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwoexClient
{
    public class Accounts
    {
        double balance = 0;

        List<ProfitCategory> profitCategories;
        List<ExpanceCategory> expanceCategories;

        public List<ProfitCategory> ProfitCategories { get => profitCategories; set => profitCategories = value; }
        public List<ExpanceCategory> ExpanceCategories { get => expanceCategories; set => expanceCategories = value; }

        public Accounts()
        {
            profitCategories = new List<ProfitCategory>();
            expanceCategories = new List<ExpanceCategory>();
            //GetCategories();
        }

        /*private void GetCategories()
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\bardi\Desktop\IT academy\lab4\lab4\data");
            FileInfo[] Files = d.GetFiles("*.txt");
            List<string> names = new List<string>();
            foreach (FileInfo file in Files)
            {
                names.Add(file.Name);
            }
        }


        private void WriteExpances(ExpanceCategory category)
        {
            string writePath = @"C:\Users\bardi\Desktop\IT academy\lab4\lab4\data\Expances" + category.Name + ".txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    foreach (Expance item in category.Expances)
                    {
                        sw.WriteLine(item.Name);
                        sw.WriteLine(item.Summ);
                        sw.WriteLine(item.Description);
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void WriteProfits(ProfitCategory category)
        {
            string writePath = @"C:\Users\bardi\Desktop\IT academy\lab4\lab4\data\Profits" + category.Name + ".txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    foreach (Profit item in category.Profits)
                    {
                        sw.WriteLine(item.Name);
                        sw.WriteLine(item.Summ);
                        sw.WriteLine(item.Description);
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }




        private void ReadExpances(ExpanceCategory category)
        {

            string readPath = @"C:\Users\bardi\Desktop\IT academy\lab4\lab4\data\Expances" + category.Name + ".txt";
            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;

                    foreach (Expance item in category.Expances)
                    {
                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }

                        sw.WriteLine(item.Name);
                        sw.WriteLine(item.Summ);
                        sw.WriteLine(item.Description);
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void ReadProfits(ProfitCategory category)
        {
            string writePath = @"C:\Users\bardi\Desktop\IT academy\lab4\lab4\data\Profits" + category.Name + ".txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    foreach (Profit item in category.Profits)
                    {
                        sw.WriteLine(item.Name);
                        sw.WriteLine(item.Summ);
                        sw.WriteLine(item.Description);
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }*/

        public void CreateCategory(bool isProfitable, string categoryName, string categoryDescription)
        {
            if (isProfitable)
            {
                ProfitCategory pc = new ProfitCategory(categoryName, categoryDescription);
                ProfitCategories.Add(pc);
            }
            else
            {
                ExpanceCategory ec = new ExpanceCategory(categoryName, categoryDescription);
                ExpanceCategories.Add(ec);
            }
        }

        public void PrintExpancesInfo()
        {
            Console.WriteLine("Витрати по катергоріям: ");
            foreach (ExpanceCategory item in ExpanceCategories)
            {
                item.PrintInfo();
            }
        }

        public void PrintProfitsInfo()
        {

            Console.WriteLine("Прибутки по катергоріям: ");
            foreach (ProfitCategory item in ProfitCategories)
            {
                item.PrintInfo();
            }

        }

        /*
        public void ReadCategories()
        {
            foreach (ExpanceCategory ecs in ExpanceCategories)
            {
                //ReadExpances(ecs);
            }
            foreach (ProfitCategory pcs in ProfitCategories)
            {
                //ReadProfits(pcs);
            }
        }



        public void WriteCategories()
        {
            foreach(ExpanceCategory ecs in ExpanceCategories)
            {
                WriteExpances(ecs);
            }
            foreach (ProfitCategory pcs in ProfitCategories)
            {
                WriteProfits(pcs);
            }
        }*/
    }
}
