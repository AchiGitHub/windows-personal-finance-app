using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceApp.Model;

namespace PersonalFinanceApp.Controller
{
    class AddAccountController
    {
        private String account_name;
        private Double initial_amount;
        private Double current_amount;
        private String account_type;
        private String bank_account_number;
        private String bank_name;

        public AddAccountController(String account_name, String amount, String account_type, String bank_account_number, String bank_name) {
            this.account_name = account_name;
            this.account_type = account_type;
            this.initial_amount = double.Parse(amount);
            this.current_amount = double.Parse(amount);
            this.bank_account_number = bank_account_number;
            this.bank_name = bank_name; 
        }

        public void createAccount() {
            Account account = new Account();
            account.createAccount(account_name, initial_amount, current_amount, account_type, bank_account_number, bank_name);
        }
    }
}
