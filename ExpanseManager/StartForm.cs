using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace ExpanseManager
{
    public partial class StartForm : Form
    {
        User user;


        public StartForm()
        {

            InitializeComponent();
            
        }

        

        private void StartForm_Load(object sender, EventArgs e)
        {
            HidePanels();
            loginUC1.Show();
        }


        private void FillFormFields()
        {
            FillCmCurrentAcc();
            FillCurrencyInCombobox(accountsUC1.CmCurrency);
            Accounts a = GetCurrentAccount();

            SetupBalanceLabel(a);
            SetupTransactionPanel(a);

        }

        private Accounts GetCurrentAccount()
        {
            Account acc = (Account)cmCurrentAcc.SelectedItem;
            Accounts a = new Accounts(acc.acc_id);
            return a;
        }

        private void FillCmCurrentAcc()
        {
            cmCurrentAcc.Items.AddRange(user.GetAccounts());
            cmCurrentAcc.DisplayMember = "name";

            if(cmCurrentAcc.Items.Count > 0)
            {
                cmCurrentAcc.SelectedIndex = 0;
            }
        }

        private void FillCurrencyInCombobox(ComboBox comboBox)
        {
            comboBox.Items.AddRange(User.GetCurrencys());
            comboBox.DisplayMember = "sign";

            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }


        private void SetupBalanceLabel(Accounts a)
        {

            lblBalance.Text = a.GetBalance().ToString() + " " + a.GetCurrencySign();

        }



        private void SetupTransactionPanel(Accounts a)
        {

            transactionsUC1.LblInflow.Text = a.GetInflow().ToString();
            transactionsUC1.LblOutflow.Text = a.GetOutflow().ToString();
            transactionsUC1.LblSummary.Text = a.GetBalance().ToString();

            transactionsUC1.DataGridView1.DataSource = a.GetTransactionDateTable();
        }

        private void Login()
        {
            user = new User();
            string login = loginUC1.TxtSigninLogin.Text;
            string password = loginUC1.TxtSigninPassword.Text;
            int i = user.Id;
            try
            {
                user.SetUser(login, password);
               
            }
            catch (Exception) {
                throw new Exception();
                
            }

        }

        private void HidePanels()
        {
            loginUC1.Visible = false;
            transactionsUC1.Visible = false;
            accountsUC1.Visible = false;
            overviewUC1.Visible = false;
        }

  

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Signup()
        {
           
            if (loginUC1.TxtSignupPassword.Text == loginUC1.TxtSignupSecondPass.Text && !loginUC1.IsSignupTextboxesEmpty()) {

                Userr user = new Userr();
                user.login = loginUC1.TxtSignupLogin.Text;
                user.name = loginUC1.TxtSignupName.Text;
                user.password = loginUC1.TxtSignupPassword.Text;
                user.email = loginUC1.TxtSignupEmail.Text;

                if (User.IsUserVacant(user.login, user.email))
                {
                    User.AddUser(user);
                    loginUC1.ClearSignupTextboxes();
                    MessageBox.Show(
                     "Реєстрація пройшла успішно",
                     "Повідомлення",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                      "Такий користувач уже існує, введіть інші даеі",
                      "Повідомлення",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                }

                    

            } else MessageBox.Show(
                        "Ви ввели невірні дані, повторіть спробу",
                        "Повідомлення",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


        }


        private void btnNavOverview_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnNavOverview.Top;
            sidePanel.Height = btnNavOverview.Height;
            HidePanels();
            overviewUC1.Show();
            

        }

        private void btnNavAccounts_Click(object sender, EventArgs e)
        {

            sidePanel.Top = btnNavAccounts.Top;
            sidePanel.Height = btnNavAccounts.Height;
            HidePanels();
            accountsUC1.Show();

        }

        private void btnNavTransactions_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnNavTransactions.Top;
            sidePanel.Height = btnNavTransactions.Height;
            HidePanels();
            transactionsUC1.Show();
            


        }

        private void loginUC1_btnLoginClick(object sender, EventArgs e)
        {
            try
            {
                Login();
                FillFormFields();
                loginUC1.ClearSigninTextboxes();
                HidePanels();
                transactionsUC1.Show();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Ви ввели невірний логін чи пароль, повторіть спробу",
                    "Повідомлення",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
}

        private void btnChangeAcc_Click(object sender, EventArgs e)
        {
            HidePanels();
            loginUC1.Show();
            cmCurrentAcc.Items.Clear();
        }

        private void loginUC1_btnRegisterClick(object sender, EventArgs e)
        {
            Signup();
        }

        private void transactionsUC1_btnAddTransactionClick(object sender, EventArgs e)
        {
            fat = new FormAddTransaction();
            fat.btnAddTransactionClick += new System.EventHandler(this.form_btnAddTransactionClick);
            fat.Show();

        }

       private Transactions GetTransactionFromForm()
        {
            Transactions t = new Transactions();
            try
            {
                Category c = new Category();
                
                //user.Accounts   t.moneyTransaction.name = fat.TxtName.Text;
                t.moneyTransaction.amount = float.Parse(fat.TxtAmount.Text);
                t.moneyTransaction.description = fat.RtbDescription.Text;
                //c.name = "some"
                

            } catch (Exception)
            {
                MessageBox.Show(
                    "Введіть коректні дані",
                    "Повідомлення",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            return t;
        }

        private void form_btnAddTransactionClick(object sender, EventArgs e)
        {
            Accounts a = GetCurrentAccount();
            Categori c = new Categori(int.Parse(fat.CbCategory.SelectedItem.ToString()));

            //c.AddTransaction();
            //a.ExpanceCategories
                
        }

        private void accountsUC1_btnAddAccountClick(object sender, EventArgs e)
        {
           /* try {
                Account acc = new Account();
                acc.name = accountsUC1.TxtName.Text;
                acc.user_id = user.Id;
                acc.curr_id = accountsUC1.CmCurrency.SelectedItem.curr_id;
                acc.*/
        }

        private void cmCurrentAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetupBalanceLabel(GetCurrentAccount());
            SetupTransactionPanel(GetCurrentAccount());
        }
    }
}
