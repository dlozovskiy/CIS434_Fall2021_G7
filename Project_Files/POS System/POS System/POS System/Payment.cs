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
                txtTotal.Text = String.Format("{0:c}", PayAmount);
            }
        }

        public Payment()
        {
            InitializeComponent();
        }

        private void PaymentMade(object sender, EventArgs e)
        {
            decimal Total = 0;

            try
            {
                Total = decimal.Parse(txtTotal.Text.TrimStart('$')) - decimal.Parse(txtPay.Text.TrimStart('$'));
            }
            catch
            {
                MessageBox.Show("Please enter a valid amount");
                return;
            }
            if (Total > 0)
            {
                txtTotal.Text = Total.ToString();
            }
            else
            {
                MessageBox.Show("Change: " + String.Format("{0:c}", -Total));
                GivenPayment(this, new PaymentEventMadeArg() { PaySuccess1 = false });
            }
            
        }

        private void Payment_Load(object sender, EventArgs e)
        {

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
