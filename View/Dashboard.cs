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

            this.refreshDashboard();
        }

        private void AddAccountBtn_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount();
            //bind the add account form closing event
            addAccount.FormClosing += new FormClosingEventHandler(this.AddAccount_FormClosing);
            addAccount.StartPosition = FormStartPosition.CenterParent;
            addAccount.ShowDialog(this);
        }

        public void LoadTotalBalance()
        {
            DashboardController dashboardController = new DashboardController();
            double totalAmount = dashboardController.GetTotalBalance();

            totalBalanceLbl.Text = "Rs. " + totalAmount.ToString("N2");
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
                var control = new AccountDetails(listOfAccounts[i])
                {
                    Location = new Point(x, y)
                };
                accountsPanel.Controls.Add(control);
                x += control.Width + 10;
            }
        }

        //refresh the data in the dashboard when there are updates
        private void Dashboard_Enter(object sender, EventArgs e)
        {
            //call when the dashboard gains focus
            this.refreshDashboard();
        }
        //refresh the dashboard when an account is added
        private void AddAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.refreshDashboard();
        }

        private void refreshDashboard() {
            LoadTotalBalance();
            LoadRecentTransactions();
            LoadAccountDetails();
        }
    }
}
