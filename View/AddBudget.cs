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
    public partial class AddBudget : UserControl
    {
        public AddBudget()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void createBudgetBtn_Click(object sender, EventArgs e)
        {
            BudgetController addBudget = new BudgetController(budgetName.Text,budgetStartDate.Value, budgetEndDate.Value, budgetAmount.Text);
            addBudget.createTransaction();
            budgetName.Text = "";
            budgetAmount.Text = "";
            MessageBox.Show("Budget Created Successfully!");
        }
    }
}
