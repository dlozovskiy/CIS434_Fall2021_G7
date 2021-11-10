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
    public partial class ViewItems : Form
    {
        private DataPOSEntities pos = new DataPOSEntities();
        public ViewItems()
        {
            InitializeComponent();

            dataGridView1.DataSource = pos.TBLmenuItems.ToList();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
