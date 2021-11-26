using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Drawing.Printing;
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
            Payment pay = new Payment
            {
                PayAmount1 = OrderTotal
            };
            
            pay.GivenPayment += new Payment.PaymentEventMade(paymentSucess);
            pay.ShowDialog();

        }

        public void Pay_GivenPayment(object sender, PaymentEventMadeArg e)
        {
            MessageBox.Show(e.PaySuccess1.ToString());
        }

        private void PrintReceipt()
        {
            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDoc = new PrintDocument();

            printDialog.Document = printDoc;
            printDoc.PrintPage += PrintDoc_PrintPage;

            DialogResult result = printDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 12);
            SolidBrush brush = new SolidBrush(Color.Black);

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("Thank you for coming ", new Font("Courier new", 18), brush, startX, startY);
            foreach(TBLmenuItem item in menuItems)
            {
                string itemDescription = item.Description.PadRight(30);
                string itemTotal = string.Format("{0:c}", item.Price);
                String itemLine = itemDescription + itemTotal;

                graphic.DrawString(itemLine, font, brush, startX, startY + offset);

                offset = offset + (int)fontHeight + 5;
            }

            offset = offset + 20;
            graphic.DrawString("Total to Pay".PadRight(30) + string.Format("{0:c}", OrderTotal), font, brush, startX, startY + offset);

        }

        void paymentSucess(object sender, PaymentEventMadeArg e)
        {
            TBLorder order = new TBLorder();
            order.OrderDate = DateTime.Now;
            if(e.PaySuccess1 == true)
            {
                foreach(TBLmenuItem item in menuItems)
                {
                    order.OrderStatus = 1;
                    item.Quantity -= 1;
                    order.TBLorderItems.Add(new TBLorderItem() { MenuID = item.MenuID, Custom = txtCustom.ToString()});
                }

                pos.TBLorders.Add(order);
                pos.SaveChanges();
                PrintReceipt();
                menuItems.Clear();
                OrderTotal = 0;
                
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
