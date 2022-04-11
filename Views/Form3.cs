using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Kotlin_Novator
{
    public partial class Form3 : Form
    {
        private bool fromSecondConstructor;
        private Form1 mainform = null;

        public Form3(Form mainForm)
        {
            mainform = mainForm as Form1;
            InitializeComponent();
            fromSecondConstructor = false;
        }

        public Form3(string account, string name, string bik, string balance, Form mainForm)
        {
            mainform = mainForm as Form1;
            InitializeComponent();

            accAccount.Text = account;
            accName.Text = name;
            accBik.Text = bik;
            accBalance.Text = balance;

            fromSecondConstructor = true;
        }

        private void addAcc_Click(object sender, EventArgs e)
        {
            var account = accAccount.Text;
            var name = accName.Text;
            var bik = accBik.Text;
            var balance = accBalance.Text;

            int customerID = mainform.GetCurrentCustomer();

            if (Checker.CheckAccountInput(account, name, bik, balance))
            {
                var db = new DataAccess();
                if (fromSecondConstructor == false)
                    db.InsertAccount(decimal.Parse(account), name, int.Parse(bik), decimal.Parse(balance), customerID);
                else
                {
                    int accountID = mainform.GetCurrentAccount();
                    db.UpdateAccount(decimal.Parse(account), name, int.Parse(bik), decimal.Parse(balance), accountID);
                }     
            }
            else
                MessageBox.Show("Неправильный ввод!");

            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
