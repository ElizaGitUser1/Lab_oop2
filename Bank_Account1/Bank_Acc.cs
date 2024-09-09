using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Account1
{
    public partial class Bank_Acc : Form
    {
        public Bank_Acc()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private BankAccount account;
        private void btCreateAcc_Click(object sender, EventArgs e)
        {
            string accountNumber = tbAccNum.Text;
            double initialBalance = 0;
            account = new BankAccount(accountNumber, initialBalance);
            lblBalance.Text = "Рахунок створено. Поточний баланс: 0 грн.";
        }
        private void btDeposit_Click(object sender, EventArgs e)
        {
            if (account != null)
            {
                double amount = double.Parse(tbDepositAmount.Text);
                try
                {
                    account.Deposit(amount);
                    lblBalance.Text = $"Поповнено! Поточний баланс: {account.Balance} грн.";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Спочатку створіть рахунок.");
            }
        }
        private void btWithdraw_Click(object sender, EventArgs e)
        {
            if (account != null)
            {
                double amount = double.Parse(tbWithdrawAmount.Text);
                try
                {
                    account.Withdraw(amount);
                    lblBalance.Text = $"Знято! Поточний баланс: {account.Balance} грн.";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Спочатку створіть рахунок.");
            }
        }
        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            if (account != null)
            {
                MessageBox.Show(account.ShowInfo());
            }
            else
            {
                MessageBox.Show("Спочатку створіть рахунок.");
            }
        }
    }
}
