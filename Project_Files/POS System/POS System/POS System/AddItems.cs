using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class AddItems : Form
    {
        private DataPOSEntities pos = new DataPOSEntities();

        private Byte[] byteData;
        public AddItems()
        {
            InitializeComponent();

            cbCategory.DataSource = pos.TbProductTypes.ToList();
            cbCategory.DisplayMember = "Description";
            cbCategory.ValueMember = "ProductType";
          
        }

        private void AddItems_Load(object sender, EventArgs e)
        {

        }

        private void btUpload_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                FileStream fsFile = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);

                byteData = new byte[fsFile.Length];

                fsFile.Read(byteData, 0, byteData.Length);

                fsFile.Close();

                MemoryStream stmData = new MemoryStream(byteData);

                pbImage.Image = Image.FromStream(stmData);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            TBLmenuItem item = new TBLmenuItem();

            item.Description = txtName.Text;
            item.Price = decimal.Parse(txtPrice.Text);
            item.Image = byteData;
            item.MenuType = (int)cbCategory.SelectedValue;

            pos.TBLmenuItems.Add(item);
            pos.SaveChanges();
            MessageBox.Show("New Item Saved");
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
