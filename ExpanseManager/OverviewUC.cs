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
    public partial class OverviewUC : UserControl
    {
        public OverviewUC()
        {
            InitializeComponent();
        }

        private void OverviewUC_Load(object sender, EventArgs e)
        {
            cbDate.SelectedIndex = 0;
        }
    }
}
