using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PersonalFinanceApp.Model
{
    class Budget
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\achin\Documents\PersonalFinance_DB.mdf;Integrated Security=True;Connect Timeout=30");

        public Budget()
        {

        }
        public void createBudget(String budget_name, DateTime start_date, DateTime end_date, Double amount)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into [Budget] (budget_name, start_date, end_date, amount) values ('" + budget_name + "', '" + start_date + "','" + end_date + "','" + amount + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
