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
using System.Collections;


namespace hwoexClient
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


        

        private void Login()
        {
            user = new User();
            string login = loginUC1.TxtSigninLogin.Text;
            string password = loginUC1.TxtSigninPassword.Text;

            try
            {
                user.FindUser(login, password);
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
        }

        private void loginUC1_btnRegisterClick(object sender, EventArgs e)
        {
            Signup();
        }

        
    }
}
