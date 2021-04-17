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
        private String description;
        private DateTime date;
        private String type;
        private Double amount;
        private String name;
        private String payment_type;

        public TransactionController(String description, DateTime date, String type, String amount, String name, String payment_type) 
        {
            this.description = description;
            this.date = date;
            this.type = type;
            this.amount = double.Parse(amount);
            this.name = name;
            this.payment_type = payment_type;
        }

        public void createTransaction() {
            Transactions transactions = new Transactions();
            transactions.createTransaction(description, date, type, amount, name, payment_type);
        }
    }
}
