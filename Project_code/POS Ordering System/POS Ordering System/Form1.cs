using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Ordering_System
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel> ();
        int index;
        public Form1()
        {
            InitializeComponent();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1) listPanel[index++].BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(flowLayoutPanel1);
            listPanel.Add(flowLayoutPanel2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index > 0) listPanel[--index].BringToFront();
        }
    }
}
 