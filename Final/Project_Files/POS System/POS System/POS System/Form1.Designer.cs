﻿
namespace POS_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOpenPOS = new System.Windows.Forms.Button();
            this.lbManage = new System.Windows.Forms.Label();
            this.lbOps = new System.Windows.Forms.Label();
            this.btnSales = new System.Windows.Forms.Button();
            this.viewOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Menu Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "View Menu Items";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOpenPOS
            // 
            this.btnOpenPOS.Location = new System.Drawing.Point(229, 78);
            this.btnOpenPOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenPOS.Name = "btnOpenPOS";
            this.btnOpenPOS.Size = new System.Drawing.Size(150, 33);
            this.btnOpenPOS.TabIndex = 3;
            this.btnOpenPOS.Text = "Open POS";
            this.btnOpenPOS.UseVisualStyleBackColor = true;
            this.btnOpenPOS.Click += new System.EventHandler(this.btnOpenPOS_Click);
            // 
            // lbManage
            // 
            this.lbManage.AutoSize = true;
            this.lbManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManage.Location = new System.Drawing.Point(26, 41);
            this.lbManage.Name = "lbManage";
            this.lbManage.Size = new System.Drawing.Size(168, 20);
            this.lbManage.TabIndex = 4;
            this.lbManage.Text = "Inventory Managment";
            // 
            // lbOps
            // 
            this.lbOps.AutoSize = true;
            this.lbOps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOps.Location = new System.Drawing.Point(259, 41);
            this.lbOps.Name = "lbOps";
            this.lbOps.Size = new System.Drawing.Size(91, 20);
            this.lbOps.TabIndex = 5;
            this.lbOps.Text = "Operations";
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(229, 117);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(150, 30);
            this.btnSales.TabIndex = 6;
            this.btnSales.Text = "Sales Graph";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // viewOrders
            // 
            this.viewOrders.Location = new System.Drawing.Point(229, 153);
            this.viewOrders.Name = "viewOrders";
            this.viewOrders.Size = new System.Drawing.Size(150, 30);
            this.viewOrders.TabIndex = 8;
            this.viewOrders.Text = "View Orders";
            this.viewOrders.UseVisualStyleBackColor = true;
            this.viewOrders.Click += new System.EventHandler(this.viewOrders_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewOrders);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.lbOps);
            this.Controls.Add(this.lbManage);
            this.Controls.Add(this.btnOpenPOS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOpenPOS;
        private System.Windows.Forms.Label lbManage;
        private System.Windows.Forms.Label lbOps;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button viewOrders;
    }
}