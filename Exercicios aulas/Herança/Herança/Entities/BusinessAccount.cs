using Heranca.Entities;
using Heranca.Entities;


namespace Heranca.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }

        // construtor da subclasse businessAccount chamando a suoer classe account
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;

        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;

            }


        }


    }
}
