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
           
            /*string clientPassword = textBox1.Text;
            if (clientPassword == servPassword)
            {
                panel1.Visible = true;
                panel3.Visible = true;
                workerReview1.Visible = true;
            }
            else
            {
                MessageBox.Show(
                  "Ви ввели невірний пароль, повторіть спробу",
                  "Повідомлення",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }*/
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
            HidePanels();
            transactionsUC1.Show();
        }

        private void btnChangeAcc_Click(object sender, EventArgs e)
        {
            HidePanels();
            loginUC1.Show();
        }
    }
}
