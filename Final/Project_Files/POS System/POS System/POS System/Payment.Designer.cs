﻿
namespace POS_System
{
    partial class Payment
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnSubmitPay = new System.Windows.Forms.Button();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Due:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(177, 42);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 1;
            // 
            // btnSubmitPay
            // 
            this.btnSubmitPay.Location = new System.Drawing.Point(55, 130);
            this.btnSubmitPay.Name = "btnSubmitPay";
            this.btnSubmitPay.Size = new System.Drawing.Size(222, 31);
            this.btnSubmitPay.TabIndex = 2;
            this.btnSubmitPay.Text = "Make Payment";
            this.btnSubmitPay.UseVisualStyleBackColor = true;
            this.btnSubmitPay.Click += new System.EventHandler(this.PaymentMade);
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(177, 83);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(100, 22);
            this.txtPay.TabIndex = 4;
            this.txtPay.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Payment Amount:";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 218);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmitPay);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnSubmitPay;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label label2;
    }
}