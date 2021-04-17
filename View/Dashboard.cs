using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceApp.View
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void addAccountBtn_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount();
            addAccount.Show();
        }
    }
}
