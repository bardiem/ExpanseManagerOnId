using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hwoexClient
{
    public partial class TransactionsUC : UserControl
    {
        public TransactionsUC()
        {
            InitializeComponent();
        }


        private string GetDateMonthBefore()
        {
            string month, year;
            DateTime date = DateTime.Now;

            month = date.Month.ToString();
            year = date.Year.ToString();

            return month + "/" + year;
        }

        

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            if (this.btnAddTransactionClick != null)
            {
                this.btnAddTransactionClick(this, e);
            }

            FormAdd form = new FormAdd();
            form.Show();

        }

        private void btnDetailsEdit_Click(object sender, EventArgs e)
        {
            if (this.btnDetailsEditClick != null)
            {
                this.btnDetailsEditClick(this, e);
            }
            
            FormEdit form = new FormEdit();
            form.Show();
        }

        private void btnDetailsDelete_Click(object sender, EventArgs e)
        {
            if (this.btnDetailsDeleteClick != null)
            {
                this.btnDetailsDeleteClick(this, e);
            }
        }



        public event EventHandler btnAddTransactionClick;
        public event EventHandler btnDetailsEditClick;
        public event EventHandler btnDetailsDeleteClick;
        public event EventHandler btnMonthBeforeClick;
        public event EventHandler btnThisMonthClick;
        public event EventHandler btnLastMonthClick;



        private void btnMonthBefore_Click(object sender, EventArgs e)
        {
            pnlBorder.Left = btnMonthBefore.Left;
            pnlBorder.Width = btnMonthBefore.Width;

            if (this.btnMonthBeforeClick != null)
            {
                this.btnMonthBeforeClick(this, e);
            }
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            pnlBorder.Left = btnThisMonth.Left;
            pnlBorder.Width = btnThisMonth.Width;

            if (this.btnThisMonthClick != null)
            {
                this.btnThisMonthClick(this, e);
            }
        }

        private void btnLastMonth_Click(object sender, EventArgs e)
        {
            pnlBorder.Left = btnLastMonth.Left;
            pnlBorder.Width = btnLastMonth.Width;

            if (this.btnLastMonthClick != null)
            {
                this.btnLastMonthClick(this, e);
            }
        }

  

        private void TransactionsUC_Load(object sender, EventArgs e)
        {
            btnMonthBefore.Text = GetDateMonthBefore();
        }


    }
}
