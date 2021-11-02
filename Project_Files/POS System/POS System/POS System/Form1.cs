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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Coffee_Click(object sender, EventArgs e)
        {
            DataPOSEntities1 dp = new DataPOSEntities1();
            TBLmenuItem item1 = new TBLmenuItem() { Description = "Coffee", Price = 2 };

            dp.TBLmenuItems.Add(item1);

            dp.SaveChanges();

        }
    }
}
