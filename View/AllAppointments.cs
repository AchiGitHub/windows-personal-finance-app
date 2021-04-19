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
    public partial class AllAppointments : Form
    {
        public AllAppointments()
        {
            InitializeComponent();
            LoadTableData();
        }

        private void LoadTableData()
        {
            Event newEvent = new Event();
            var data = newEvent.GetAppointments();

            AllAppointmentsTable.AutoGenerateColumns = false;
            AllAppointmentsTable.DataSource = data;
        }
    }
}
