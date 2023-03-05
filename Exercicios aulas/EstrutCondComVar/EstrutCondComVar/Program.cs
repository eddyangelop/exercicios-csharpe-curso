using System;
namespace encadeamento_estrutura_condicional
{
    class program
    {
        static void Main(string[] args)
        {
            var numeroDoMes = int.Parse(Console.ReadLine());
            var nomesMes = new string[]{"","Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro",
    "Outubro", "Novembro", "Dezembro"};

            if (numeroDoMes != 0)
            {
                Console.WriteLine(nomesMes[numeroDoMes]);
            }

        }

    }


}