﻿
namespace Test_Kotlin_Novator
{
    partial class Form2
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
            this.Cancel = new System.Windows.Forms.Button();
            this.addOrg = new System.Windows.Forms.Button();
            this.orgAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.orgInn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orgName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(136, 142);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // addOrg
            // 
            this.addOrg.Location = new System.Drawing.Point(55, 142);
            this.addOrg.Name = "addOrg";
            this.addOrg.Size = new System.Drawing.Size(75, 23);
            this.addOrg.TabIndex = 14;
            this.addOrg.Text = "ОК";
            this.addOrg.UseVisualStyleBackColor = true;
            this.addOrg.Click += new System.EventHandler(this.addOrg_Click);
            // 
            // orgAddress
            // 
            this.orgAddress.Location = new System.Drawing.Point(153, 89);
            this.orgAddress.Name = "orgAddress";
            this.orgAddress.Size = new System.Drawing.Size(100, 20);
            this.orgAddress.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Адрес организации";
            // 
            // orgInn
            // 
            this.orgInn.Location = new System.Drawing.Point(153, 55);
            this.orgInn.Name = "orgInn";
            this.orgInn.Size = new System.Drawing.Size(100, 20);
            this.orgInn.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ИНН";
            // 
            // orgName
            // 
            this.orgName.Location = new System.Drawing.Point(153, 17);
            this.orgName.Name = "orgName";
            this.orgName.Size = new System.Drawing.Size(100, 20);
            this.orgName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название организации";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 187);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.addOrg);
            this.Controls.Add(this.orgAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orgInn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orgName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button addOrg;
        private System.Windows.Forms.TextBox orgAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox orgInn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orgName;
        private System.Windows.Forms.Label label1;
    }
}