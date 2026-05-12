using System;

namespace Bank
{
    public class BankAccount 
    {
        private double balance;

        public BankAccount()
        {
        }

        public BankAccount(double balance)
        {
            this.balance = balance;

        }

        public double Balance
        {
            get { return balance; }
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

        }


    }//end class BankAccount

}//end namespace Bank