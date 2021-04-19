using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceApp.View
{
    public partial class Other : UserControl
    {
        public Other()
        {
            InitializeComponent();
        }

        private void TasksBtn_Click(object sender, EventArgs e)
        {
            AllTasks allTasks = new AllTasks();
            allTasks.StartPosition = FormStartPosition.CenterParent;
            allTasks.ShowDialog(this);
        }

        private void AppointmentsBtn_Click(object sender, EventArgs e)
        {
            AllAppointments allAppointments = new AllAppointments();
            allAppointments.StartPosition = FormStartPosition.CenterParent;
            allAppointments.ShowDialog(this);
        }

        private void FinancialStatePrediction_Click(object sender, EventArgs e)
        {
            FinancialStatus financialStatus = new FinancialStatus();
            financialStatus.StartPosition = FormStartPosition.CenterParent;
            financialStatus.ShowDialog(this);
        }
    }
}
