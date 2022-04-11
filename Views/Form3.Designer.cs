
namespace Test_Kotlin_Novator
{
    partial class Form3
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
            this.button2 = new System.Windows.Forms.Button();
            this.addAcc = new System.Windows.Forms.Button();
            this.accBik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.accName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.accAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accBalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // addAcc
            // 
            this.addAcc.Location = new System.Drawing.Point(38, 204);
            this.addAcc.Name = "addAcc";
            this.addAcc.Size = new System.Drawing.Size(75, 23);
            this.addAcc.TabIndex = 22;
            this.addAcc.Text = "ОК";
            this.addAcc.UseVisualStyleBackColor = true;
            this.addAcc.Click += new System.EventHandler(this.addAcc_Click);
            // 
            // accBik
            // 
            this.accBik.Location = new System.Drawing.Point(147, 87);
            this.accBik.Name = "accBik";
            this.accBik.Size = new System.Drawing.Size(100, 20);
            this.accBik.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "БИК банка";
            // 
            // accName
            // 
            this.accName.Location = new System.Drawing.Point(147, 53);
            this.accName.Name = "accName";
            this.accName.Size = new System.Drawing.Size(100, 20);
            this.accName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Название счета";
            // 
            // accAccount
            // 
            this.accAccount.Location = new System.Drawing.Point(147, 15);
            this.accAccount.Name = "accAccount";
            this.accAccount.Size = new System.Drawing.Size(100, 20);
            this.accAccount.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Счет";
            // 
            // accBalance
            // 
            this.accBalance.Location = new System.Drawing.Point(147, 123);
            this.accBalance.Name = "accBalance";
            this.accBalance.Size = new System.Drawing.Size(100, 20);
            this.accBalance.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Остаток на счете";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 239);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.accBalance);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addAcc);
            this.Controls.Add(this.accBik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accAccount);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addAcc;
        private System.Windows.Forms.TextBox accBik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox accName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accBalance;
        private System.Windows.Forms.Label label4;
    }
}