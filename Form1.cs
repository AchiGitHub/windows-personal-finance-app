using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void moveBtnPointer(Control btn) 
        {
            btnPointerPanel.Width = btn.Width;
            btnPointerPanel.Left = btn.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moveBtnPointer(dashboardBtn);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moveBtnPointer(eventBtn);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            moveBtnPointer(financialStatusBtn);
        }

        private void addIncome_Click(object sender, EventArgs e)
        {
            moveBtnPointer(addIncomeBtn);
        }

        private void addExpenseBtn_Click(object sender, EventArgs e)
        {
            moveBtnPointer(addExpenseBtn);
        }

        private void addBudgetBtn_Click(object sender, EventArgs e)
        {
            moveBtnPointer(addBudgetBtn);
        }

        private void generateReportBtn_Click(object sender, EventArgs e)
        {
            moveBtnPointer(generateReportBtn);
        }
    }
}
