using Banking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingGUI
{
    public partial class Form1 : Form
    {
        List<Account> accounts = new List<Account>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // "hardcode" a few accounts
            accounts.Add(new Account()); // balance zero
            accounts.Add(new Account(100));
            accounts.Add(new Account(500));
            DisplayAccounts();
        }

        // display accounts in the list box and select the first
        private void DisplayAccounts()
        {
            lstAccounts.Items.Clear(); // erase old content
            foreach (Account a in accounts) // display all accounts
                lstAccounts.Items.Add(a);
            lstAccounts.SelectedIndex = 0; // select the first
        }

        // create another account
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(Validator.IsPresent(txtInitialBalance, "Initial balance") &&
                Validator.IsNonNegativeDecimal(txtInitialBalance, "Initial balance")
               )
            {
                decimal initBalance = Convert.ToDecimal(txtInitialBalance.Text);
                Account newAcct = new Account(initBalance); // cerate new avvoint
                accounts.Add(newAcct); // add to the list
                DisplayAccounts();
            }
        }

        // perform deposit on selected account
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if(lstAccounts.SelectedIndex == -1)// no selection
            {
                MessageBox.Show("Select account first", "Deposit");
                lstAccounts.Focus();
            }
            else // account is selected
            {
                Account acct = accounts[lstAccounts.SelectedIndex];
                if (Validator.IsPresent(txtAmount, "Money amount") &&
                    Validator.IsNonNegativeDecimal(txtAmount, "Money amount")// valid amount
                    )
                {
                    decimal amount = Convert.ToDecimal(txtAmount.Text);
                    acct.Deposit(amount);
                    DisplayAccounts();
                }
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (lstAccounts.SelectedIndex == -1)// no selection
            {
                MessageBox.Show("Select account first", "Withdraw");
                lstAccounts.Focus();
            }
            else // account is selected
            {
                Account acct = accounts[lstAccounts.SelectedIndex];
                if (Validator.IsPresent(txtAmount, "Money amount") &&
                    Validator.IsNonNegativeDecimal(txtAmount, "Money amount")// valid amount
                    )
                {
                    decimal amount = Convert.ToDecimal(txtAmount.Text);
                    bool valid = acct.Withdraw(amount);
                    if(valid)
                        DisplayAccounts();
                    else //NSF
                    {
                        MessageBox.Show("Insufficient funds. You may withdraw at most " +
                            acct.Balance.ToString("c"), "Withdraw");
                        txtAmount.SelectAll();
                        txtAmount.Focus();
                    }
                }
            }
        }
    }
}
