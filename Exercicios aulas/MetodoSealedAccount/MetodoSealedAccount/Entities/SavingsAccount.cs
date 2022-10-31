namespace MetodoSealedAccount.Entities
{
    // Este metodo sela a classe pra não ser herdada por outra classe novamente
    //sealed class SavingsAccount : Account
    //{

    class SavingsAccount : Account
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
        // Sealed sela o metodo para não ser sobre-escrevido novamente em outra classe
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
