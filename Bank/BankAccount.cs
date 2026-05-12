using System;

namespace Bank
{
    public class BankAccount 
    {
        private double balance;

        public BankAccount()
        {
        }//end constructor1

        public BankAccount(double balance)
        {
            this.balance = balance;

        }//end constructor2

        public double Balance
        {
            get { return balance; } //property that returns 1 balance
        }

        public void Add(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            balance += amount;
        }//end Add


        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            balance -= amount;
        }//end Withdraw

        public void TransferFunds(BankAccount otherAccount, double amount)
        {
            if (otherAccount is null)
            {
                throw new ArgumentNullException(nameof(otherAccount));
            }

            Withdraw(amount);
            otherAccount.Add(amount);
        }//end TransferFunds
    }//end class BankAccoun
}//end namespace Bank