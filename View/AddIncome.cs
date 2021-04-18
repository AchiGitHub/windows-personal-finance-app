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
    public partial class AddIncome : UserControl
    {
        public AddIncome()
        {
            InitializeComponent();
            TransactionController transactionController = new TransactionController();
            BindingSource bs = new BindingSource();
            List<string> accountNames = transactionController.getAccountNames();
            bs.DataSource = accountNames;
            paymentTypeBtn.DataSource = bs;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void createIncomeBtn_Click(object sender, EventArgs e)
        {
            if (incomeName.Text == "" || note.Text == "" || amount.Text == "" || paymentTypeBtn.Text == "") {
                MessageBox.Show("Fill All Fields!");
            }
            else
            {
                TransactionController transactionController = new TransactionController();
                transactionController.createTransaction(note.Text, incomeDate.Value, "I", amount.Text, incomeName.Text, paymentTypeBtn.Text);
                note.Text = "";
                amount.Text = "";
                incomeName.Text = "";
                paymentTypeBtn.Text = "";
                MessageBox.Show("Income Added Successfully!");
            }
        }

        private void AddIncome_Load(object sender, EventArgs e)
        {

        }
    }
}
