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

namespace PersonalFinanceApp.View
{
    public partial class AllTasks : Form
    {
        public AllTasks()
        {
            InitializeComponent();
            LoadTableData();
        }

        private void LoadTableData() { 
            Event newEvent = new Event();
            var data = newEvent.GetTasks();

            AllTasksTable.AutoGenerateColumns = false;
            AllTasksTable.DataSource = data;
        }

        private void UpdateEvent_Click(object sender, EventArgs e)
        {
            Event newEvent = new Event();
            newEvent.UpdateTask(AllTasksTable.DataSource as DataTable);
            MessageBox.Show("Task Updated Successfully!");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
