using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class POS_form : Form
    {

        private BindingList<TBLmenuItem> menuItems = new BindingList<TBLmenuItem>();
        private DataPOSEntities pos = new DataPOSEntities();
        private decimal orderTotal;

        public decimal OrderTotal
        {
            get { return orderTotal; }
            set
            {
                orderTotal = value;
                txtOrderTotal.Text = String.Format("{0:c}",orderTotal);
            }
        }

        public POS_form()
        {
            InitializeComponent();

            lstItemsChosen.DataSource = menuItems;
            lstItemsChosen.DisplayMember = "Description";

            CreateTabbedPanel();

            AddProductToPanel();
        }

        private void AddProductToPanel()
        {
            int i = 1;

            foreach(TabPage tp in MenuTabs.TabPages)
            {
                //ObjectQuery<TBLmenuItem> filteredItem = new ObjectQuery<TBLmenuItem>("SELECT VALUE P FOM TBLmenuItems AS P", pos);
                var ToShow = from b in pos.TBLmenuItems
                             where b.MenuType == i
                             select b;

                FlowLayoutPanel flp = new FlowLayoutPanel();
                flp.Dock = DockStyle.Fill;
                
                foreach(TBLmenuItem tb in ToShow)
                {
                    Button b = new Button();
                    b.Size = new Size(100, 100); 
                    b.Text = tb.Description;

                    b.Tag = tb;
                    b.Click += UpdateItemList;

                    flp.Controls.Add(b);
                }

                tp.Controls.Add(flp);
                i++;
            }
        }

        private void UpdateItemList(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            TBLmenuItem m = (TBLmenuItem)b.Tag;

            menuItems.Add(m);
            UpdateCustomerInformationPanel(m);

            OrderTotal = OrderTotal+(decimal)m.Price;

            lstItemsChosen.SelectedIndex = lstItemsChosen.Items.Count - 1;
        }

        private void UpdateCustomerInformationPanel(TBLmenuItem item)
        {
            string currentDescription = item.Description;
            string currentPrice = String.Format("{0:c}", item.Price);
            string currentDescriptionPadded = currentDescription.PadRight(30);

            txtInfoPanel.Text = currentDescriptionPadded + currentPrice;
        }

        private void CreateTabbedPanel()
        {
            foreach(TbProductType pt in pos.TbProductTypes)
            {
                MenuTabs.TabPages.Add(pt.ProductType.ToString(), pt.Description);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBLmenuItem p = new TBLmenuItem() { Description = "Product A", Price = 1.99m };
            menuItems.Add(p);
        }

        private void FormatListItem(object sender, ListControlConvertEventArgs e)
        {
            string currentDescription = ((TBLmenuItem)e.ListItem).Description;
            string currentPrice = String.Format("{0:c}",((TBLmenuItem)e.ListItem).Price);
            string currentDescriptionPadded = currentDescription.PadRight(30);

            e.Value = currentDescriptionPadded + currentPrice;
        }

        private void DeleteItem(object sender, EventArgs e)
        {
            TBLmenuItem selectedItem = (TBLmenuItem)lstItemsChosen.SelectedItem;
            menuItems.Remove(selectedItem);
            OrderTotal = OrderTotal - (decimal)selectedItem.Price;
        }

        private void OpenPaymentEvent(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Show();
            pay.GivenPayment += new Payment.PaymentEventMade(paymentSucess);
            pay.PayAmount1 = OrderTotal;
        }
        void paymentSucess(object sender, PaymentEventMadeArg e)
        {
            TBLorder order = new TBLorder();
            order.OrderDate = DateTime.Now;
            if(e.PaySuccess1 == true)
            {
                foreach(TBLmenuItem item in menuItems)
                {
                    order.TBLorderItems.Add(new TBLorderItem() { MenuID = item.MenuID });
                }

                pos.TBLorders.Add(order);
                pos.SaveChanges();
            }
        }

        private void lstItemsChosen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MenuTabs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
