
namespace Test_Kotlin_Novator
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
            this.components = new System.ComponentModel.Container();
            this.CustomersGrid = new System.Windows.Forms.DataGridView();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new Test_Kotlin_Novator.masterDataSet();
            this.customerTableAdapter = new Test_Kotlin_Novator.masterDataSetTableAdapters.CustomerTableAdapter();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.buttonEditCustomer = new System.Windows.Forms.Button();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.AccountGrid = new System.Windows.Forms.DataGridView();
            this.buttonDeleteAccount = new System.Windows.Forms.Button();
            this.buttonEditAccount = new System.Windows.Forms.Button();
            this.buttonAddAccount = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersGrid
            // 
            this.CustomersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersGrid.BackgroundColor = System.Drawing.Color.White;
            this.CustomersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Name,
            this.INN,
            this.Address});
            this.CustomersGrid.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.customerBindingSource, "ID", true));
            this.CustomersGrid.Location = new System.Drawing.Point(15, 25);
            this.CustomersGrid.Name = "CustomersGrid";
            this.CustomersGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.CustomersGrid.Size = new System.Drawing.Size(348, 179);
            this.CustomersGrid.TabIndex = 0;
            this.CustomersGrid.Tag = global::Test_Kotlin_Novator.Properties.Settings.Default.masterConnectionString;
            this.CustomersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddCustomer.Location = new System.Drawing.Point(53, 210);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCustomer.TabIndex = 2;
            this.buttonAddCustomer.Text = "Добавить";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // buttonEditCustomer
            // 
            this.buttonEditCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEditCustomer.Location = new System.Drawing.Point(134, 210);
            this.buttonEditCustomer.Name = "buttonEditCustomer";
            this.buttonEditCustomer.Size = new System.Drawing.Size(97, 23);
            this.buttonEditCustomer.TabIndex = 3;
            this.buttonEditCustomer.Text = "Редактировать";
            this.buttonEditCustomer.UseVisualStyleBackColor = true;
            this.buttonEditCustomer.Click += new System.EventHandler(this.EditCustomer_Click);
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(237, 210);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteCustomer.TabIndex = 4;
            this.buttonDeleteCustomer.Text = "Удалить";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.DeleteCustomer_Click);
            // 
            // AccountGrid
            // 
            this.AccountGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountGrid.BackgroundColor = System.Drawing.Color.White;
            this.AccountGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountId,
            this.account,
            this.accountName,
            this.bik,
            this.balance});
            this.AccountGrid.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.customerBindingSource, "ID", true));
            this.AccountGrid.Location = new System.Drawing.Point(10, 28);
            this.AccountGrid.Name = "AccountGrid";
            this.AccountGrid.Size = new System.Drawing.Size(341, 176);
            this.AccountGrid.TabIndex = 5;
            this.AccountGrid.Tag = global::Test_Kotlin_Novator.Properties.Settings.Default.masterConnectionString;
            // 
            // buttonDeleteAccount
            // 
            this.buttonDeleteAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteAccount.Location = new System.Drawing.Point(237, 212);
            this.buttonDeleteAccount.Name = "buttonDeleteAccount";
            this.buttonDeleteAccount.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAccount.TabIndex = 8;
            this.buttonDeleteAccount.Text = "Удалить";
            this.buttonDeleteAccount.UseVisualStyleBackColor = true;
            this.buttonDeleteAccount.Click += new System.EventHandler(this.DeleteAccount_Click);
            // 
            // buttonEditAccount
            // 
            this.buttonEditAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEditAccount.Location = new System.Drawing.Point(134, 212);
            this.buttonEditAccount.Name = "buttonEditAccount";
            this.buttonEditAccount.Size = new System.Drawing.Size(97, 23);
            this.buttonEditAccount.TabIndex = 7;
            this.buttonEditAccount.Text = "Редактировать";
            this.buttonEditAccount.UseVisualStyleBackColor = true;
            this.buttonEditAccount.Click += new System.EventHandler(this.EditAccount_Click);
            // 
            // buttonAddAccount
            // 
            this.buttonAddAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddAccount.Location = new System.Drawing.Point(53, 212);
            this.buttonAddAccount.Name = "buttonAddAccount";
            this.buttonAddAccount.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAccount.TabIndex = 6;
            this.buttonAddAccount.Text = "Добавить";
            this.buttonAddAccount.UseVisualStyleBackColor = true;
            this.buttonAddAccount.Click += new System.EventHandler(this.AddAccount_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDeleteCustomer);
            this.groupBox1.Controls.Add(this.buttonEditCustomer);
            this.groupBox1.Controls.Add(this.buttonAddCustomer);
            this.groupBox1.Controls.Add(this.CustomersGrid);
            this.groupBox1.Location = new System.Drawing.Point(39, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 250);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDeleteAccount);
            this.groupBox2.Controls.Add(this.buttonEditAccount);
            this.groupBox2.Controls.Add(this.buttonAddAccount);
            this.groupBox2.Controls.Add(this.AccountGrid);
            this.groupBox2.Location = new System.Drawing.Point(428, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 249);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Accounts";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // INN
            // 
            this.INN.HeaderText = "INN";
            this.INN.Name = "INN";
            this.INN.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // accountId
            // 
            this.accountId.HeaderText = "id";
            this.accountId.Name = "accountId";
            this.accountId.ReadOnly = true;
            // 
            // account
            // 
            this.account.HeaderText = "account";
            this.account.Name = "account";
            this.account.ReadOnly = true;
            // 
            // accountName
            // 
            this.accountName.HeaderText = "name";
            this.accountName.Name = "accountName";
            this.accountName.ReadOnly = true;
            // 
            // bik
            // 
            this.bik.HeaderText = "BIK";
            this.bik.Name = "bik";
            this.bik.ReadOnly = true;
            // 
            // balance
            // 
            this.balance.HeaderText = "balance";
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 299);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomersGrid;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private masterDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonEditCustomer;
        private System.Windows.Forms.Button buttonDeleteCustomer;
        private System.Windows.Forms.DataGridView AccountGrid;
        private System.Windows.Forms.Button buttonDeleteAccount;
        private System.Windows.Forms.Button buttonEditAccount;
        private System.Windows.Forms.Button buttonAddAccount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn INN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn account;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bik;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
    }
}

