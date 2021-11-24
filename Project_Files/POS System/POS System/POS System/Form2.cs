using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace POS_System
{
    public partial class DisplaySales : Form
    {
        public DisplaySales()
        {
            InitializeComponent();
            makeGraph();
        }

        private void makeGraph()
        {
            using(DataPOSEntities pos = new DataPOSEntities())
            {
                var query = from item in pos.TBLorderItems
                            group item by item.TBLmenuItem.Description into g
                            select new { ItemID = g.Key, TotalUnitsSold = g.Count() };

                chart1.DataSource = query.ToList();
                
                chart1.Series[0].XValueMember = "ItemID";
                chart1.Series[0].YValueMembers = "TotalUnitsSold";
                chart1.Series[0].Name = "Products";

                chart1.DataBind();
                chart1.Show();
            }
        }
    }
}
