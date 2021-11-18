using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class Payment : Form
    {
        public delegate void PaymentEventMade(object sender, PaymentEventMadeArg e);

        public event PaymentEventMade GivenPayment;

        private decimal PayAmount;
        public decimal PayAmount1
        {
            get { return PayAmount; }
            set {
                PayAmount = value;
                txtPay.Text = String.Format("{0:c}", PayAmount);
            }
        }

        public Payment()
        {
            InitializeComponent();
        }

        private void PaymentMade(object sender, EventArgs e)
        {
            GivenPayment(this, new PaymentEventMadeArg() { PaySuccess1 = true });
        }
    }
    public class PaymentEventMadeArg: EventArgs{
        private bool PaySuccess;

        public bool PaySuccess1
        {
            get { return PaySuccess; }
            set { PaySuccess = value; }
        }
    }

}
