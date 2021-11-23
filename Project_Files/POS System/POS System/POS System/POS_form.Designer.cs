
namespace POS_System
{
    partial class POS_form
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
            this.lstItemsChosen = new System.Windows.Forms.ListBox();
            this.MenuTabs = new System.Windows.Forms.TabControl();
            this.txtInfoPanel = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnPay = new System.Windows.Forms.Button();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstItemsChosen
            // 
            this.lstItemsChosen.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstItemsChosen.FormattingEnabled = true;
            this.lstItemsChosen.ItemHeight = 16;
            this.lstItemsChosen.Location = new System.Drawing.Point(800, 17);
            this.lstItemsChosen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstItemsChosen.Name = "lstItemsChosen";
            this.lstItemsChosen.Size = new System.Drawing.Size(478, 420);
            this.lstItemsChosen.TabIndex = 0;
            this.lstItemsChosen.SelectedIndexChanged += new System.EventHandler(this.lstItemsChosen_SelectedIndexChanged);
            this.lstItemsChosen.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.FormatListItem);
            // 
            // MenuTabs
            // 
            this.MenuTabs.Location = new System.Drawing.Point(35, 103);
            this.MenuTabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuTabs.Name = "MenuTabs";
            this.MenuTabs.SelectedIndex = 0;
            this.MenuTabs.Size = new System.Drawing.Size(671, 334);
            this.MenuTabs.TabIndex = 2;
            this.MenuTabs.SelectedIndexChanged += new System.EventHandler(this.MenuTabs_SelectedIndexChanged);
            // 
            // txtInfoPanel
            // 
            this.txtInfoPanel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoPanel.Location = new System.Drawing.Point(37, 21);
            this.txtInfoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInfoPanel.Name = "txtInfoPanel";
            this.txtInfoPanel.Size = new System.Drawing.Size(669, 41);
            this.txtInfoPanel.TabIndex = 3;
            this.txtInfoPanel.Text = "Next Customer";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(803, 458);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(171, 61);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "&Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.DeleteItem);
            // 
            // BtnPay
            // 
            this.BtnPay.BackColor = System.Drawing.Color.Lime;
            this.BtnPay.Location = new System.Drawing.Point(35, 460);
            this.BtnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(325, 56);
            this.BtnPay.TabIndex = 5;
            this.BtnPay.Text = "Pay Now";
            this.BtnPay.UseVisualStyleBackColor = false;
            this.BtnPay.Click += new System.EventHandler(this.OpenPaymentEvent);
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(1017, 458);
            this.txtOrderTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(261, 22);
            this.txtOrderTotal.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Place Order";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // POS_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 546);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOrderTotal);
            this.Controls.Add(this.BtnPay);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.txtInfoPanel);
            this.Controls.Add(this.MenuTabs);
            this.Controls.Add(this.lstItemsChosen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "POS_form";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstItemsChosen;
        private System.Windows.Forms.TabControl MenuTabs;
        private System.Windows.Forms.TextBox txtInfoPanel;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnPay;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Button button1;
    }
}