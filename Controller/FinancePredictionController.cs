using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinanceApp.Model;

namespace PersonalFinanceApp.Controller
{
    class FinancePredictionController
    {
        public FinancePredictionController() { }
        public double GetTotalIncome(DateTime predictDate)
        {
            Transactions transactions = new Transactions();
            var income = transactions.GetTotalIncome(predictDate);
            double totalIncome = 0.0;
            foreach (string s in income)
            {
                totalIncome +=  double.Parse(s);
            }

            return totalIncome / income.Count;
        }

        public double GetTotalExpense(DateTime predictDate)
        {
            Transactions transactions = new Transactions();
            var expenses = transactions.GetTotalExpenses(predictDate);
            double totalExpense = 0.0;
            foreach (string s in expenses)
            {
                totalExpense += double.Parse(s);
            }

            return totalExpense / expenses.Count;
        }
    }
}
