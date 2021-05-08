using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalFinanceApp.View;

namespace PersonalFinanceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MoveBtnPointer(dashboardBtn);
            dashboard.BringToFront();
        }

        private void MoveBtnPointer(Control btn) 
        {
            btnPointerPanel.Width = btn.Width;
            btnPointerPanel.Left = btn.Left;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MoveBtnPointer(dashboardBtn);
            dashboard.BringToFront();
            dashboard.Focus();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MoveBtnPointer(eventBtn);
            addEvent.BringToFront();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            MoveBtnPointer(otherBtn);
            otherPanel.BringToFront();
        }

        private void AddIncome_Click(object sender, EventArgs e)
        {
            MoveBtnPointer(addIncomeBtn);
            addIncomePanel.RefreshAddIncome();
            addIncomePanel.BringToFront();
        }

        private void AddExpenseBtn_Click(object sender, EventArgs e)
        {
            MoveBtnPointer(addExpenseBtn);
            addExpense.RefreshAddExpense();
            addExpense.BringToFront();
        }

        private void AddBudgetBtn_Click(object sender, EventArgs e)
        {
            MoveBtnPointer(addBudgetBtn);
            addBudget.BringToFront();
        }

        private void GenerateReportBtn_Click(object sender, EventArgs e)
        {
            MoveBtnPointer(generateReportBtn);
            generateReport.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
