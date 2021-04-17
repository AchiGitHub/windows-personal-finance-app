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

namespace PersonalFinanceApp
{
    public partial class AddEvent : UserControl
    {
        public AddEvent()
        {
            InitializeComponent();
        }

        private void createTask_Click(object sender, EventArgs e)
        {
            EventController addTask = new EventController(taskTitle.Text, taskDate.Value, taskNote.Text, "T", null, appointmentFrom.Value, appointmentTo.Value);
            addTask.createEvent();
            taskTitle.Text = "";
            taskNote.Text = "";
            MessageBox.Show("Task Created Successfully!");
        }

        private void createAppointment_Click(object sender, EventArgs e)
        {
            EventController addAppointment = new EventController(appointmentTitle.Text, taskDate.Value, null, "A", appointmentWith.Text, appointmentFrom.Value, appointmentTo.Value);
            addAppointment.createEvent();
            appointmentTitle.Text = "";
            appointmentWith.Text = "";
            MessageBox.Show("Appointment Created Successfully!");
        }
    }
}
