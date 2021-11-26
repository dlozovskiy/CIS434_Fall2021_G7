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

            
            
            Filter.DisplayMember = "Description";
            Filter.ValueMember = "ProductType";
            Filter.DataSource = pos.TbProductTypes.ToList();

            dataGridView1.DataSource = returnFilter().ToList();


            dataGridView1.Columns["MenuType"].Visible = false;
            dataGridView1.Columns["TbProductType"].Visible = false;
            dataGridView1.Columns["TBLorderItems"].Visible = false;


            //Delete Button

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            this.dataGridView1.Columns.Add(deleteButton);
          

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == dataGridView1.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == dataGridView1.Columns["dataGridViewDeleteButton"].Index)
            {
                //Put some logic here, for example to remove row from your binding list.

                var toDelete = (TBLmenuItem)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                

                pos.TBLmenuItems.Remove(toDelete);
                pos.SaveChanges();
                dataGridView1.DataSource = returnFilter().ToList();
                // Or
                // var data = (Product)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                // do something 
            }
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

        private IQueryable<TBLmenuItem> returnFilter()
        {
            var ToShow = from b in pos.TBLmenuItems
                         where b.MenuType == (int)Filter.SelectedValue
                         select b;
            return ToShow;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            pos.SaveChanges();
            
        }

    }
}
