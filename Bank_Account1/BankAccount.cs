using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account1
{
        public class BankAccount
        {
            public string AccountNumber { get; }
            public double Balance { get; private set; }
            public BankAccount(string accountNumber, double initialBalance)
            {
                AccountNumber = accountNumber;
                Balance = initialBalance;
            }
            public void Deposit(double amount)
            {
                if (amount > 0)
                {
                    Balance += amount;
                }
                else
                {
                    throw new ArgumentException("Сума поповнення має бути більше 0.");
                }
            }
            public void Withdraw(double amount)
            {
                if (amount > 0 && amount <= Balance)
                {
                    Balance -= amount;
                }
                else if (amount <= 0)
                {
                    throw new ArgumentException("Сума зняття має бути більше 0.");
                }
                else
                {
                    throw new InvalidOperationException("Недостатньо коштів на рахунку.");
                }
            }
            public string ShowInfo()
            {
            return $"Номер рахунку: {AccountNumber}, Баланс: {Balance} грн.";
            }
    }
    
}
