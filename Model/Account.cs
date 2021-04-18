﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace PersonalFinanceApp.Model
{
    public class Account
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\achin\Documents\PersonalFinance_DB.mdf;Integrated Security=True;Connect Timeout=30");

        public Account() 
        {
            
        }
        public void createAccount(String account_name, Double initial_amount, Double current_amount, String account_type, String bank_account_number, String bank_name) {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into [Accounts] (account_name, initial_amount, current_amount, account_type, bank_account_number, bank_name) values ('"+ account_name + "', '" + initial_amount + "','" + current_amount + "','" + account_type + "','" + bank_account_number + "','" + bank_name + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public List<string> getTotalAccountBalance() {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * from [Accounts]";
            SqlDataReader reader = cmd.ExecuteReader();
            var accountBalances = new List<string>();
            while (reader.Read())
            {
                accountBalances.Add(reader.GetValue(3).ToString());
            }
            connection.Close();

            return accountBalances;
        }

        public List<string> getAccountNames() {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * from [Accounts]";
            SqlDataReader reader = cmd.ExecuteReader();
            var accountNames = new List<string>();
            while (reader.Read())
            {
                accountNames.Add(reader.GetValue(1).ToString());
            }
            connection.Close();

            return accountNames;
        }

        public void updateAccount(String accountName, double amount) {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("@currentAmount", amount);
            cmd.Parameters.AddWithValue("@accountName", accountName);
            cmd.CommandText = "UPDATE [Accounts] SET current_amount = current_amount + @currentAmount WHERE account_name=@accountName";
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
