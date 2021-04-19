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
        }

        private void MoveBtnPointer(Control btn) 
        {
            btnPointerPanel.Width = btn.Width;
            btnPointerPanel.Left = btn.Left;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MoveBtnPointer(dashboardBtn);
            Dashboard db = new Dashboard();
            db.LoadAccountDetails();
            db.LoadRecentTransactions();
            db.LoadTotalBalance();

            dashboard.Refresh();
            dashboard.BringToFront();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MoveBtnPointer(eventBtn);
            addEvent.BringToFront();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            MoveBtnPointer(financialStatusBtn);
        }

        private void AddIncome_Click(object sender, EventArgs e)
        {
            MoveBtnPointer(addIncomeBtn);
            addIncomePanel.BringToFront();
        }

        private void AddExpenseBtn_Click(object sender, EventArgs e)
        {
            MoveBtnPointer(addExpenseBtn);
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
