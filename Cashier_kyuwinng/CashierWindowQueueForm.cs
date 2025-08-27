using System;
using System.Collections;
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

    public partial class CashierWindowQueueForm: Form
    {
        Customer_View view = null;
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();
        }

        public void timer1_tick(object sender, EventArgs args)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach(Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                if (view == null)
                {
                    view = new Customer_View();
                    view.Show();
                }
                view.SetIan(CashierClass.CashierQueue.Dequeue());
            } else
            {
                MessageBox.Show("Empty!");
            }


        }
    }

}
