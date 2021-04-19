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
            cmd.CommandText = "insert into [Transactions] (description, date, type, amount, name, payment_type) values ('" + description + "', '" + date + "','" + type + "','" + amount + "', '" + name + "', '" + payment_type + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public SqlDataAdapter GetTransactions()
        {
            connection.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * from [Transactions]", connection);
            return sqlDa;
        }
        public DataTable GetReportData(DateTime startDate, DateTime endDate)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            SqlDataAdapter data = new SqlDataAdapter("SELECT * from [Transactions] WHERE date BETWEEN @sDate AND @eDate", connection);
            data.SelectCommand.Parameters.AddWithValue("@sDate", startDate);
            data.SelectCommand.Parameters.AddWithValue("@eDate", endDate);

            DataTable dbtl = new DataTable();

            data.Fill(dbtl);
            return dbtl;
        }
    }
}
