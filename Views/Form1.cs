using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Test_Kotlin_Novator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowCustomers();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AccountGrid.Rows.Clear();
            int customerID = GetCurrentCustomer();
            ShowAccounts(customerID);
        }

        private void ShowCustomers()
        {
            var db = new DataAccess();
            List<Customer> customers = db.GetCustomers();

            CustomersGrid.Rows.Clear();

            foreach (Customer customer in customers)
            {
                CustomersGrid.Rows.Add(new object[] 
                {
                    customer.Id,
                    customer.Name,
                    customer.INN,
                    customer.Address 
                });
            }
        }

        private void ShowAccounts(int customerID)
        {
            var db = new DataAccess();
            List<Account> accounts = db.GetAccounts(customerID);

            AccountGrid.Rows.Clear();

            foreach (var account in accounts)
            {
                AccountGrid.Rows.Add(new object[]
                {
                    account.Id,
                    account.account,
                    account.Name,
                    account.BIK,
                    account.Balance
                });
            }
        }

        private void DeleteCustomer_Click(object sender, EventArgs e) => DeleteRowAt(CustomersGrid, new DataAccess().DeleteCustomer);

        private void DeleteAccount_Click(object sender, EventArgs e) => DeleteRowAt(AccountGrid, new DataAccess().DeleteAccount);

        private void DeleteRowAt(DataGridView grid, Action<int> deleteMethod)
        {
            if (grid.CurrentRow == null) return;
            int id = (int)CustomersGrid.CurrentRow.Cells[0].Value;

            deleteMethod(id);

            foreach (DataGridViewRow row in grid.SelectedRows)
            {
                grid.Rows.RemoveAt(row.Index);
            }
        }

        private void AddCustomer_Click(object sender, EventArgs e) => ShowDialogBox(new Form2(this), Dialog_Form2Closed);

        private void AddAccount_Click(object sender, EventArgs e) => ShowDialogBox(new Form3(this), Dialog_Form3Closed);

        private void ShowDialogBox(Form form, FormClosedEventHandler method)
        {
            var dialog = form;
            dialog.FormClosed += method;
            dialog.ShowDialog();
        }

        private void Dialog_Form2Closed(object sender, FormClosedEventArgs e) => ShowCustomers();

        private void Dialog_Form3Closed(object sender, FormClosedEventArgs e)
        {
            int customerID = GetCurrentCustomer();
            ShowAccounts(customerID);
        }

        public int GetCurrentCustomer() => (int)CustomersGrid.CurrentRow.Cells[0].Value;

        public int GetCurrentAccount() => (int)AccountGrid.CurrentRow.Cells[0].Value;

        private void EditCustomer_Click(object sender, EventArgs e)
        {
            var row = CustomersGrid.CurrentRow;

            string name = row.Cells[1].Value.ToString();
            string INN = row.Cells[2].Value.ToString();
            string address = row.Cells[3].Value.ToString();

            ShowDialogBox(new Form2(name, INN, address, this), Dialog_Form2Closed);
        }

        private void EditAccount_Click(object sender, EventArgs e)
        {
            var row = AccountGrid.CurrentRow;

            string account = row.Cells[1].Value.ToString();
            string name = row.Cells[2].Value.ToString();
            string bik = row.Cells[3].Value.ToString();
            string balance = row.Cells[4].Value.ToString();

            ShowDialogBox(new Form3(account, name, bik, balance, this), Dialog_Form3Closed);
        }
    }
}
