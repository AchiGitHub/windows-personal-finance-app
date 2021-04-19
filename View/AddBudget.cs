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

        private void CreateBudgetBtn_Click(object sender, EventArgs e)
        {
            if (budgetName.Text == "" || budgetAmount.Text == "")
            {
                MessageBox.Show("Fill All Fields!");
            }
            else
            {
                BudgetController addBudget = new BudgetController(budgetName.Text, budgetStartDate.Value, budgetEndDate.Value, budgetAmount.Text);
                addBudget.CreateTransaction();
                budgetName.Text = "";
                budgetAmount.Text = "";
                MessageBox.Show("Budget Created Successfully!");
            }
        }
    }
}
