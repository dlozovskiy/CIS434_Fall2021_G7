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
    public partial class DisplaySales : Form
    {
        public DisplaySales()
        {
            InitializeComponent();
        }

        private void makeGraph()
        {
            using(DataPOSEntities pos = new DataPOSEntities())
            {
                var query = from item in pos.TBLmenuItems
                            group item by item.TbProductType.Description into g
                            select new { ItemID = g.Key, TotalUnitsSold = g.Count() };

                chart1.DataSource = query;

                chart1.Series["Series 1"].XValueMember = "ItemID";
                chart1.Series["Series 1"].YValueMembers = "TotalUnitsSold";
                chart1.Series["Series 1"].Name = "Products";

                chart1.DataBind();
                chart1.Show();
            }
        }
    }
}
