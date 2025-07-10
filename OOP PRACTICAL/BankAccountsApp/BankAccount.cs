using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsApp
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; protected set; }
       

        public virtual string Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return "Deposit amount must be positive.";
            }
            Balance += amount;
            return $"Amount {amount} deposited successfully";
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                return "Withdrawal amount must be positive.";
            }
            if (amount > Balance)
            {
                return "Insufficient funds for withdrawal.";
            }
            Balance -= amount;
            return $"Amount {amount} withdrawn successfully";
        }




        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;

        }
    }
}
