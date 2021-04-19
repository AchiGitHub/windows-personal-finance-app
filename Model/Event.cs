using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PersonalFinanceApp.Model
{
    class Event
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\achin\Documents\PersonalFinance_DB.mdf;Integrated Security=True;Connect Timeout=30");

        public Event()
        {

        }
        public void CreateEvent(String title, DateTime date, String note, String type , String appointmentWith, DateTime appointment_from, DateTime appointment_to)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into [Event] (title, task_date, note, type, appointment_with, appointment_from, appointment_to) values ('" + title + "', '" + date + "','" + note + "', '" + type + "','" + appointmentWith + "','" + appointment_from + "','" + appointment_to + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
        }

    }
}
