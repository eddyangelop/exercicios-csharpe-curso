using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MetodoSealedAccount.Entities
{

    // O metodo não deixa a classe herdar outra selada
    //internal class SavingsAccountPlus : SavingsAccount
    //{
    //}
    internal class SavingsAccountPlus : SavingsAccount
    {

        // Cuidado ao sobre-escrever metodos de outras classes
        public override void Withdraw(double amount)
        {
            
            base.Withdraw(amount);
            Balance -= 25.0;
        }

        // Use o metodo sealed no metodo para não ser usado em outras classes
        // isso protege sua aplicação no futuro em questão de implementações indevidas
    }

}
