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
        }

        private void createExpense_Click(object sender, EventArgs e)
        {
            TransactionController transactionController = new TransactionController(note.Text, expenseDate.Value, "E", amount.Text, expenseName.Text, paymentType.Text);
            transactionController.createTransaction();
            note.Text = "";
            amount.Text = "";
            amount.Text = "";
            expenseDate.Text = "";
            paymentType.Text = "";
            expenseName.Text = "";
            MessageBox.Show("Expense Added Successfully!");
        }
    }
}

