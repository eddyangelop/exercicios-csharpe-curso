using System;
using System.Collections.Generic;
using System.Globalization;
using MetodosAbstratos2.Entities;


namespace MetodosAbstratos2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> list = new List<TaxPayer>();

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine($"TaxPayer payer #{n} data:" );
                Console.Write("Individual or company (i/c)?. ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double helthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, income, helthExpenditures));
                }
                else
                {
                    Console.Write("Number of enployees: ");
                    int numberOfEnployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, numberOfEnployees));
                }

            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach(TaxPayer tp in list)
            {
                double tax = tp.Tax();
                Console.WriteLine(tp.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $" + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}