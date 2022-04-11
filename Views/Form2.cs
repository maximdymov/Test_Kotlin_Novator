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
    public partial class Form2 : Form
    {
        private bool fromSecondConstructor;
        private Form1 mainForm = null;

        public Form2(Form main)
        {
            InitializeComponent();
            fromSecondConstructor = false;
        }

        public Form2(string name, string INN, string address, Form main)
        {
            mainForm = main as Form1;
            InitializeComponent();

            orgName.Text = name;
            orgInn.Text = INN;
            orgAddress.Text = address;

            fromSecondConstructor = true;
        }

        private void addOrg_Click(object sender, EventArgs e)
        {
            var name = orgName.Text;
            var inn = orgInn.Text;
            var addr = orgAddress.Text;

            if (Checker.CheckCustomerInput(name, inn, addr))
            {
                var db = new DataAccess();

                if (fromSecondConstructor == false)
                    db.InsertCustomer(name, long.Parse(inn), addr);
                else
                {
                    int customerID = mainForm.GetCurrentCustomer();
                    db.UpdateCustomer(name, long.Parse(inn), addr, customerID);
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
