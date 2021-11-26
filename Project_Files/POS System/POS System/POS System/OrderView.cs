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
    public partial class OrderView : Form
    {

        private BindingList<TBLorderItem> orderItems = new BindingList<TBLorderItem>();
        private BindingList<TBLmenuItem> orderMenu = new BindingList<TBLmenuItem>();
        private DataPOSEntities pos = new DataPOSEntities();

        public OrderView()
        {
            InitializeComponent();
            CreatePanel();
            selectOrder();
            orderDetail.DataSource = orderMenu;
            orderDetail.DisplayMember = "Description";
        }

        private void CreatePanel()
        {
            foreach(TblOrderStat ot in pos.TblOrderStats)
            {
                orderTabs.TabPages.Add(ot.OrderStat.ToString(), ot.Description);
            }
        }
        private void selectOrder()
        {
            int orderStatIndex = 0;
            foreach (TabPage ot in orderTabs.TabPages)
            {
                var ToShow = from b in pos.TBLorders
                             where b.OrderStatus == orderStatIndex
                             select b;

                FlowLayoutPanel flp = new FlowLayoutPanel();
                flp.Dock = DockStyle.Fill;

                foreach (TBLorder tb in ToShow)
                {
                    Button b = new Button();
                    b.Size = new Size(100, 100);
                    b.Text = tb.OrderDate.ToString();
                    b.Tag = tb;
                    b.Click += new EventHandler(OrderDetailList);
                    orderItems.Clear();
                    flp.Controls.Add(b);
                }
                orderStatIndex += 1;
                ot.Controls.Add(flp);

            }
        }

        private void OrderDetailList(object sender, EventArgs e)
        {
            orderItems.Clear();
            orderMenu.Clear();
            Button b = (Button)sender;

            TBLorder o = (TBLorder)b.Tag;
            int id = o.OrderID;

            var itemsInOrder = from item in pos.TBLorderItems
                               where item.OrderID == id
                               select item;

            foreach(TBLorderItem i in itemsInOrder )
            {
                orderItems.Add(i);

                var menuInOrder = from menu in pos.TBLmenuItems
                                  where menu.MenuID == i.MenuID
                                  select menu;
                foreach(TBLmenuItem mi in menuInOrder)
                {
                    orderMenu.Add(mi);
                }
            }
            

            
        }

        private void FormatOrderList(object sender, ListControlConvertEventArgs e)
        {
            string currentDescription = ((TBLmenuItem)e.ListItem).Description;
            //string currentPrice = String.Format("{0,c}",((TBLmenuItem)e.ListItem).Price);
            string currentDescriptionPadding = currentDescription.PadRight(30);

            e.Value = currentDescriptionPadding;
        }
    }
}
