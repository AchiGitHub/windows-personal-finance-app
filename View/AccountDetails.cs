using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalFinanceApp.Utilities;

namespace PersonalFinanceApp.View
{
    public partial class AccountDetails : UserControl
    {
        public AccountDetails(UserAccount account)
        {
            InitializeComponent();
            accountName.Text = account.AccountName;
            currentAmount.Text = "Rs. " + double.Parse(account.CurrentAmount).ToString("N2");
            initialAmount.Text = "Initial Rs. " + double.Parse(account.InitialAmount).ToString("N2");
        }

        private void AccountDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
