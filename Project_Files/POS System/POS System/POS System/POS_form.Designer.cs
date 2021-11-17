
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
            this.SuspendLayout();
            // 
            // lstItemsChosen
            // 
            this.lstItemsChosen.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstItemsChosen.FormattingEnabled = true;
            this.lstItemsChosen.ItemHeight = 18;
            this.lstItemsChosen.Location = new System.Drawing.Point(900, 21);
            this.lstItemsChosen.Name = "lstItemsChosen";
            this.lstItemsChosen.Size = new System.Drawing.Size(537, 526);
            this.lstItemsChosen.TabIndex = 0;
            this.lstItemsChosen.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.FormatListItem);
            // 
            // MenuTabs
            // 
            this.MenuTabs.Location = new System.Drawing.Point(39, 129);
            this.MenuTabs.Name = "MenuTabs";
            this.MenuTabs.SelectedIndex = 0;
            this.MenuTabs.Size = new System.Drawing.Size(755, 418);
            this.MenuTabs.TabIndex = 2;
            // 
            // txtInfoPanel
            // 
            this.txtInfoPanel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoPanel.Location = new System.Drawing.Point(42, 26);
            this.txtInfoPanel.Name = "txtInfoPanel";
            this.txtInfoPanel.Size = new System.Drawing.Size(752, 48);
            this.txtInfoPanel.TabIndex = 3;
            this.txtInfoPanel.Text = "Next Customer";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(903, 572);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(192, 76);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "&Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.DeleteItem);
            // 
            // BtnPay
            // 
            this.BtnPay.BackColor = System.Drawing.Color.Lime;
            this.BtnPay.Location = new System.Drawing.Point(39, 578);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(750, 70);
            this.BtnPay.TabIndex = 5;
            this.BtnPay.Text = "Pay";
            this.BtnPay.UseVisualStyleBackColor = false;
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(1144, 572);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(293, 26);
            this.txtOrderTotal.TabIndex = 6;
            // 
            // POS_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 682);
            this.Controls.Add(this.txtOrderTotal);
            this.Controls.Add(this.BtnPay);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.txtInfoPanel);
            this.Controls.Add(this.MenuTabs);
            this.Controls.Add(this.lstItemsChosen);
            this.Name = "POS_form";
            this.Text = "Welocme";
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
    }
}