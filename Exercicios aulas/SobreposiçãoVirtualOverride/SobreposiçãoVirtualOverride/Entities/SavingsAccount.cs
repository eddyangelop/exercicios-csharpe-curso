namespace VirtualOverride.Entities
{
    internal class SavingsAccount : Account
    {

        public double InterestRate { get; set; }


        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }


        // Sobrescrever a regra da super-classe com override virtual
        public override void Withdraw(double amount)
        {
            //Metodo de saldo com e sem desconto
            //Balance -= amount;

            //Implementar taxa extra na conta com o metodo base
            base.Withdraw(amount);
            Balance -= 20.0;
        }

    }
}
