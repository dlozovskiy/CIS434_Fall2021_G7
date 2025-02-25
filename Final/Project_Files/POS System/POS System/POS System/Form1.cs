﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace POS_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddItems addItems = new AddItems();
            addItems.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewItems viewItems = new ViewItems();
            viewItems.Show();
        }

        private void btnOpenPOS_Click(object sender, EventArgs e)
        {
            POS_form posForm = new POS_form();

            posForm.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            DisplaySales displaySales = new DisplaySales();
            displaySales.Show();

        }

        private void viewOrders_Click(object sender, EventArgs e)
        {
            OrderView viewOrder = new OrderView();
            viewOrder.Show();
        }
    }
}
