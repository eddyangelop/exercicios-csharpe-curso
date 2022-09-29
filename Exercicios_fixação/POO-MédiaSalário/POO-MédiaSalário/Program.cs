
using System;
using System.Globalization;

namespace Media_Salario
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Media = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine("Salário Médio = " + Media.ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadLine();

        }
    }
}