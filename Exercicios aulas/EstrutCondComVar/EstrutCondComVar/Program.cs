using System;
namespace EstruturaCondicionalVar
{
    class program
    {
        static void Main(string[] args)
        {
            var numeroDoMes = int.Parse(Console.ReadLine());
            var nomesMes = new string[] { "","Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

            if (numeroDoMes <= 0 || numeroDoMes > 12)
            {
                Console.WriteLine("Mês Invalido!");
            }
            else
            {
                Console.WriteLine("Seu Mês é: " + nomesMes[numeroDoMes]);
            }

        }

    }


}