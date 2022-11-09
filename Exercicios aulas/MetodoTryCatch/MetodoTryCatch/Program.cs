using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);

            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Você ta dividindo errado seu corno!");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Foramt error! " + e.Message);
            }

            Console.ReadLine();
        }
    }
}
