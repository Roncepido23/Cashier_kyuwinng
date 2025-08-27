using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier_kyuwinng
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var kyuwingForm = new KyuwingForm();

            var cashierQueueForm = new CashierWindowQueueForm();
            cashierQueueForm.Show();

            Application.Run(kyuwingForm);
        }
    }
}
