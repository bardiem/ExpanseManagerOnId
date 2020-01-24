using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpanseManager
{
    public partial class AccountsUC : UserControl
    {
        public AccountsUC()
        {
            InitializeComponent();
        }



        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (this.btnAddAccountClick != null)
            {
                this.btnAddAccountClick(this, e);
            }
        }

        private void btnDetailsEdit_Click(object sender, EventArgs e)
        {
            if (this.btnDetailsEditClick != null)
            {
                this.btnDetailsEditClick(this, e);
            }
        }

        private void btnDetailsDelete_Click(object sender, EventArgs e)
        {
            if (this.btnDetailsDeleteClick != null)
            {
                this.btnDetailsDeleteClick(this, e);
            }
        }



        public event EventHandler btnAddAccountClick;
        public event EventHandler btnDetailsEditClick;
        public event EventHandler btnDetailsDeleteClick;
    }
}
