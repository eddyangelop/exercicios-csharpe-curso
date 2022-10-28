using System;
using System.Globalization;
using System.Security.Principal;
using VirtualOverride.Entities;

namespace virtual_override
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine("Saldo da conta com Taxa: R$" + acc1.Balance.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Saldo da conta sem Taxa: R$" + acc2.Balance.ToString("F2"), CultureInfo.InvariantCulture);



        }
    }
}