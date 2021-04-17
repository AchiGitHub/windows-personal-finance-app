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

namespace PersonalFinanceApp.View
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {

        }

        private void accountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accountType.SelectedIndex != 0)
            {
                accountNumberLbl.Visible = true;
                accountNumber.Visible = true;
                bankNameLbl.Visible = true;
                bankName.Visible = true;
            }
            else
            {
                accountNumberLbl.Visible = false;
                accountNumber.Visible = false;
                bankNameLbl.Visible = false;
                bankName.Visible = false;
            }

        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            AddAccountController addAccountController = new AddAccountController(accountName.Text, amount.Text, accountType.Text, accountNumber.Text, bankName.Text);
            addAccountController.createAccount();
            accountName.Text = "";
            amount.Text = "";
            accountType.Text = "";
            bankName.Text = "";
            accountNumber.Text = "";
            MessageBox.Show("Account Created Successfully!");
        }
    }
}
