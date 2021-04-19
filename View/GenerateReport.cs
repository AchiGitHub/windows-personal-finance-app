using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalFinanceApp.Model;

namespace PersonalFinanceApp
{
    public partial class GenerateReport : UserControl
    {

        static ReaderWriterLock locker = new ReaderWriterLock();
        public GenerateReport()
        {
            InitializeComponent();
        }

        private void GenerateReport_Load(object sender, EventArgs e)
        {

        }

        private void DownloadReport_Click(object sender, EventArgs e)
        {
            if (ReportName.Text == "")
            {
                MessageBox.Show("Enter Report Name");
            }
            else
            {
                //writing the file in a thread safe manner
                //this implementation can be useful when the application grows and wrties to multiple files at once
                try
                {
                    locker.AcquireWriterLock(int.MaxValue);
                    string dateString = DateTime.Today.ToLongDateString();
                    var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dateString + " - " + ReportName.Text + ".txt");

                    Transactions transactions = new Transactions();
                    var data = transactions.GetReportData(ReportStartDate.Value, ReportEndDate.Value);

                    StreamWriter tw = File.AppendText(fileName);

                    foreach (DataRow row in data.Rows)
                    {
                        string id = row["transaction_id"].ToString();
                        string name = row["name"].ToString();
                        string type = row["type"].ToString();
                        string amount = row["amount"].ToString();
                        string description = row["description"].ToString();
                        string date = row["date"].ToString();
                        string payment_type = row["payment_type"].ToString();

                        tw.Write(id);
                        tw.Write(", " + name);
                        tw.Write(", " + type);
                        tw.Write(", " + amount);
                        tw.Write(", " + description);
                        tw.Write(", " + date);
                        tw.Write(", " + payment_type);
                        tw.Write("\n");

                    }

                    tw.Close();
                    MessageBox.Show("Report Generate Successfully!\nSaved At: " + fileName);
                    ReportName.Text = "";
                }
                finally
                {
                    locker.ReleaseReaderLock();
                }
            }

        }
    }
}
