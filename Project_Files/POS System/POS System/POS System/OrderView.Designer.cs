
namespace POS_System
{
    partial class OrderView
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
            this.orderTabs = new System.Windows.Forms.TabControl();
            this.orderDetail = new System.Windows.Forms.ListBox();
            this.btnPaid = new System.Windows.Forms.Button();
            this.btnServed = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderTabs
            // 
            this.orderTabs.Location = new System.Drawing.Point(12, 37);
            this.orderTabs.Name = "orderTabs";
            this.orderTabs.SelectedIndex = 0;
            this.orderTabs.Size = new System.Drawing.Size(577, 401);
            this.orderTabs.TabIndex = 0;
            // 
            // orderDetail
            // 
            this.orderDetail.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDetail.FormattingEnabled = true;
            this.orderDetail.ItemHeight = 16;
            this.orderDetail.Location = new System.Drawing.Point(596, 37);
            this.orderDetail.Name = "orderDetail";
            this.orderDetail.Size = new System.Drawing.Size(300, 388);
            this.orderDetail.TabIndex = 1;
            this.orderDetail.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.FormatOrderList);
            // 
            // btnPaid
            // 
            this.btnPaid.Location = new System.Drawing.Point(112, 444);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(120, 61);
            this.btnPaid.TabIndex = 2;
            this.btnPaid.Text = "Pay Order";
            this.btnPaid.UseVisualStyleBackColor = true;
            // 
            // btnServed
            // 
            this.btnServed.Location = new System.Drawing.Point(238, 444);
            this.btnServed.Name = "btnServed";
            this.btnServed.Size = new System.Drawing.Size(120, 61);
            this.btnServed.TabIndex = 3;
            this.btnServed.Text = "Serve Order";
            this.btnServed.UseVisualStyleBackColor = true;
            this.btnServed.Click += new System.EventHandler(this.btnServed_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(364, 444);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(120, 61);
            this.btnComplete.TabIndex = 4;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 548);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnServed);
            this.Controls.Add(this.btnPaid);
            this.Controls.Add(this.orderDetail);
            this.Controls.Add(this.orderTabs);
            this.Name = "OrderView";
            this.Text = "OrderView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl orderTabs;
        private System.Windows.Forms.ListBox orderDetail;
        private System.Windows.Forms.Button btnPaid;
        private System.Windows.Forms.Button btnServed;
        private System.Windows.Forms.Button btnComplete;
    }
}