using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceApp.Model;

namespace PersonalFinanceApp.Controller
{
    class TransactionController
    {
        public TransactionController() 
        {
        }

        public void createTransaction(String description, DateTime date, String type, String amount, String name, String payment_type) {
            Transactions transactions = new Transactions();
            transactions.CreateTransaction(description, date, type, double.Parse(amount), name, payment_type);
            Account account = new Account();
            double updateAmount = double.Parse(amount);
            if (type == "E") 
            {
                updateAmount *= -1;
            }
            account.updateAccount(payment_type, updateAmount);
        }

        public List<string> getAccountNames() {
            Account account = new Account();
            return account.getAccountNames();
        }
    }
}
