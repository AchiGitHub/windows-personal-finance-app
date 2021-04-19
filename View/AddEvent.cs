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

        private void CreateTask_Click(object sender, EventArgs e)
        {
            if (taskTitle.Text == "" || taskNote.Text == "")
            {
                MessageBox.Show("Fill All Fields!");
            }
            else
            {
                EventController addTask = new EventController(taskTitle.Text, taskDate.Value, taskNote.Text, "T", null, appointmentFrom.Value, appointmentTo.Value);
                addTask.CreateEvent();
                taskTitle.Text = "";
                taskNote.Text = "";
                MessageBox.Show("Task Created Successfully!");
            }
        }

        private void CreateAppointment_Click(object sender, EventArgs e)
        {
            if (appointmentTitle.Text == "" || appointmentWith.Text == "")
            {
                MessageBox.Show("Fill All Fields!");
            }
            else
            {
                EventController addAppointment = new EventController(appointmentTitle.Text, taskDate.Value, null, "A", appointmentWith.Text, appointmentFrom.Value, appointmentTo.Value);
                addAppointment.CreateEvent();
                appointmentTitle.Text = "";
                appointmentWith.Text = "";
                MessageBox.Show("Appointment Created Successfully!");
            }
             
        }
    }
}
