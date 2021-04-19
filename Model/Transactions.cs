using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PersonalFinanceApp.Model
{
    class Transactions
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\achin\Documents\PersonalFinance_DB.mdf;Integrated Security=True;Connect Timeout=30");

        public Transactions()
        {

        }
        public void CreateTransaction(String description, DateTime date, String type, Double amount, String name, String payment_type)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into [Transactions] (description, transaction_date, type, amount, name, payment_type) values ('" + description + "', '" + date + "','" + type + "','" + amount + "', '" + name + "', '" + payment_type + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public SqlDataAdapter GetTransactions()
        {
            connection.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * from [Transactions] ORDER BY transaction_date DESC", connection);
            return sqlDa;
        }
        public DataTable GetReportData(DateTime startDate, DateTime endDate)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            SqlDataAdapter data = new SqlDataAdapter("SELECT * from [Transactions] WHERE transaction_date BETWEEN @sDate AND @eDate", connection);

            //query parameters to select the date range
            data.SelectCommand.Parameters.AddWithValue("@sDate", startDate);
            data.SelectCommand.Parameters.AddWithValue("@eDate", endDate);

            DataTable dbtl = new DataTable();

            data.Fill(dbtl);
            return dbtl;
        }

        public List<string> GetTotalExpenses(DateTime predictDate)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT amount from [Transactions] where transaction_date between DATEADD(MONTH, -2, '"+ predictDate + "') and '" + predictDate + "' and type='E'";
            SqlDataReader reader = cmd.ExecuteReader();
            var expences = new List<string>();
            while (reader.Read())
            {
                expences.Add(reader.GetValue(0).ToString());
            }

            return expences;
        }

        public List<string> GetTotalIncome(DateTime predictDate)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT amount from [Transactions] where transaction_date between DATEADD(MONTH, -2, '" + predictDate + "') and '" + predictDate + "' and type='I'";
            SqlDataReader reader = cmd.ExecuteReader();
            var income = new List<string>();
            while (reader.Read())
            {
                income.Add(reader.GetValue(0).ToString());
            }

            return income;
        }
    }
}
