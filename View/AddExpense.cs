using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalFinanceApp.Controller;

namespace PersonalFinanceApp
{
    public partial class AddExpense : UserControl
    {
        public AddExpense()
        {
            InitializeComponent();
            TransactionController transactionController = new TransactionController();
            BindingSource bs = new BindingSource();
            List<string> accountNames = transactionController.GetAccountNames();
            bs.DataSource = accountNames;
            paymentType.DataSource = bs;
        }

        private void CreateExpense_Click(object sender, EventArgs e)
        {
            if (note.Text == "" || amount.Text == "" || expenseDate.Text == "" || paymentType.Text == "" || expenseName.Text == "")
            {
                MessageBox.Show("Fill All Fields!");
            } 
            else
            {
                TransactionController transactionController = new TransactionController();
                transactionController.CreateTransaction(note.Text, expenseDate.Value, "E", amount.Text, expenseName.Text, paymentType.Text);
                note.Text = "";
                amount.Text = "";
                expenseDate.Text = "";
                paymentType.Text = "";
                expenseName.Text = "";
                MessageBox.Show("Expense Added Successfully!");
            }
        }

        public void RefreshAddExpense() {
            TransactionController transactionController = new TransactionController();
            BindingSource bs = new BindingSource();
            List<string> accountNames = transactionController.GetAccountNames();
            bs.DataSource = accountNames;
            paymentType.DataSource = bs;
        }

        private void AddExpense_Load(object sender, EventArgs e)
        {

        }
    }
}

