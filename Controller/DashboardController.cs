using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceApp.Model;

namespace PersonalFinanceApp.Controller
{
    class DashboardController
    {
        public double getTotalBalance() {
            double totalBalance = 0.0;
            Account account = new Account();
            var accounts = account.getTotalAccountBalance();
            foreach (string amount in accounts)
            {
                var current_amount  =  double.Parse(amount);
                totalBalance = totalBalance + current_amount;
            }
            return totalBalance;
        }
    }

}
