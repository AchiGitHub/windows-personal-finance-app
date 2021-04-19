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

            LoadTotalBalance();

            LoadRecentTransactions();

            LoadAccountDetails();

        }

        private void addAccountBtn_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount();
            addAccount.StartPosition = FormStartPosition.CenterParent;
            addAccount.ShowDialog(this);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadTotalBalance();
        }

        public void LoadTotalBalance() {
            DashboardController dashboardController = new DashboardController();
            double totalAmount = dashboardController.getTotalBalance();

            totalBalanceLbl.Text = "Rs. " + totalAmount.ToString("N2");
        }

        private void Dashboard_VisibleChanged(object sender, EventArgs e)
        {
            LoadTotalBalance();
        }
        public void LoadRecentTransactions()
        {
            Transactions transactions = new Transactions();
            DataTable dtbl = new DataTable();

            transactions.GetTransactions().Fill(dtbl);

            recentTransactions.AutoGenerateColumns = false;
            recentTransactions.DataSource = dtbl;
        }

        public void LoadAccountDetails() {
            Account account = new Account();
            var listOfAccounts = account.GetAccounts();

            int x = 0;
            int y = 0;
            for (int i = 0; i < listOfAccounts.Count; i++)
            {
                var control = new AccountDetails(listOfAccounts[i]);
                control.Location = new Point(x, y);
                accountsPanel.Controls.Add(control);
                x += control.Width + 10;
            }
        }

    }
}
