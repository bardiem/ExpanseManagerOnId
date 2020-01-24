using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpanseManager
{
    public partial class FormAddCategory : Form
    {
        public FormAddCategory()
        {
            InitializeComponent();
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            if (this.btnAddTransactionClick != null)
            {
                this.btnAddTransactionClick(this, e);
            }
        }


        public event EventHandler btnAddTransactionClick;
    }
}
