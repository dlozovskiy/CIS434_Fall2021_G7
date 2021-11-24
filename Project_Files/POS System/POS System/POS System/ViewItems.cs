using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.Objects;

namespace POS_System
{
    public partial class ViewItems : Form
    {
        private DataPOSEntities pos = new DataPOSEntities();
        public ViewItems()
        {
            InitializeComponent();

            dataGridView1.DataSource = pos.TBLmenuItems.ToList();

            dataGridView1.Columns["MenuType"].Visible = false;
            dataGridView1.Columns["TbProductType"].Visible = false;
            dataGridView1.Columns["TBLorderItems"].Visible = false;

            Filter.DataSource = pos.TbProductTypes.ToList();
            Filter.DisplayMember = "Description";
            Filter.ValueMember = "ProductType";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Filter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FilterList(object sender, EventArgs e)
        {

            //ObjectQuery<TBLmenuItem> filteredMenuItem = new ObjectQuery<TBLmenuItem>(
            //    "SELECT VALUE C FROM TBLmenuItems AS C WHERE C.ProductType = " + Filter.SelectedValue, pos);
            var ToShow = from b in pos.TBLmenuItems
                         where b.MenuType == (int)Filter.SelectedValue
                         select b;

            dataGridView1.DataSource = ToShow.ToList();

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            pos.SaveChanges();
        }

    }
}
