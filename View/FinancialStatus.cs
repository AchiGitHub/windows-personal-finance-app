using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalFinanceApp.Controller;

namespace PersonalFinanceApp.View
{
    public partial class FinancialStatus : Form
    {
        public FinancialStatus()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            FinancePredictionController predictionController = new FinancePredictionController();
            var predictedIncome = predictionController.GetTotalIncome(PredictDate.Value);
            var predictedExpense = predictionController.GetTotalExpense(PredictDate.Value);

            DashboardController dashboardController = new DashboardController();
            double totalAmount = dashboardController.GetTotalBalance();

            double totalBalancePrediction = totalAmount + (predictedIncome - predictedExpense);

            if (Double.IsNaN(predictedIncome) || Double.IsNaN(predictedExpense) || Double.IsNaN(totalBalancePrediction)) {
                totalIncome.Text = "-";
                totalExpense.Text = "-";
                accountBalance.Text = "-";

                MessageBox.Show("Not enough data to predict Finance!");
            }
            else
            {
                totalIncome.Text = "Rs. " + predictedIncome.ToString("N2");
                totalExpense.Text = "Rs. " + predictedExpense.ToString("N2");
                accountBalance.Text = "Rs. " + totalBalancePrediction.ToString("N2");

            }
        }
    }
}
