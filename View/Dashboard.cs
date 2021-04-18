using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalFinanceApp.Model;
using PersonalFinanceApp.Controller;

namespace PersonalFinanceApp.View
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            Transactions transactions = new Transactions();
            DataTable dtbl = new DataTable();

            transactions.GetTransactions().Fill(dtbl);

            recentTransactions.AutoGenerateColumns = false;
            recentTransactions.DataSource = dtbl;

            loadTotalBalance();
        }

        private void addAccountBtn_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount();
            addAccount.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            loadTotalBalance();
        }

        private void loadTotalBalance() {
            DashboardController dashboardController = new DashboardController();
            double totalAmount = dashboardController.getTotalBalance();

            totalBalanceLbl.Text = "Rs. " + totalAmount.ToString("N2");
        }

        private void Dashboard_VisibleChanged(object sender, EventArgs e)
        {
            loadTotalBalance();
        }
    }
}
