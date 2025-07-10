using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsApp
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }


        //inheritance constructor meaning that it calls the base class constructor also
        public SavingsAccount(string owner, decimal interestRate) : base($"{owner} {interestRate}%")
        {
            InterestRate = interestRate;
        }

        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return "Deposit amount must be positive.";
            }
            Balance += amount;
            // Apply interest on the deposited amount
            decimal interest = amount * InterestRate / 100;
            Balance += interest;
            return $"Amount {amount} deposited successfully with interest of {interest}. New balance is {Balance}.";
        }

    }
}
