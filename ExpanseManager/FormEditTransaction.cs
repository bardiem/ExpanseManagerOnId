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
    public partial class FormEditTransaction : Form
    {
        public FormEditTransaction()
        {
            InitializeComponent();
        }

        private void btnDetailsEdit_Click(object sender, EventArgs e)
        {
            if (this.btnDetailsEditClick != null)
            {
                this.btnDetailsEditClick(this, EventArgs.Empty);
            }
        }


        public event EventHandler btnDetailsEditClick;
    }
}
