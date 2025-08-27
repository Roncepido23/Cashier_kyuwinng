using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier_kyuwinng
{
    public partial class Customer_View : Form
    {
        public Customer_View()
        {
            InitializeComponent();
        }

        private void Customer_View_Load(object sender, EventArgs e)
        {

        }

        public void SetIan(string msg)
        {
           label2_Cashier_Numbering.Text = msg;
        }

    }
}
