using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceApp.Model;

namespace PersonalFinanceApp.Controller
{
    class BudgetController
    {
        private String budget_name;
        private DateTime start_date;
        private DateTime end_date;
        private Double amount;

        public BudgetController(String budget_name, DateTime start_date, DateTime end_date, String amount)
        {
            this.budget_name = budget_name;
            this.start_date = start_date;
            this.end_date = end_date;
            this.amount = double.Parse(amount);
        }

        public void CreateTransaction()
        {
            Budget budget = new Budget();
            budget.createBudget(budget_name, start_date, end_date, amount);
        }
    }
}
