using System;

namespace time_span
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metodo TimeSpan.
            
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            // imprime hora/minuto/segundo.
            Console.WriteLine(t1);

            // imprime a relação de 100 nano segundos com relação ao TimeSpan.
            Console.WriteLine(t1.Ticks);

            // imprime o TimeSpan vazio.
            TimeSpan t2 = new TimeSpan();

            // imprime o TimeSpan com relaçãp a ticks de nano segundos.
            TimeSpan t3 = new TimeSpan(900000000L);

            // imprime hora/minuto/segundos.
            TimeSpan t4 = new TimeSpan(2, 11, 21);

            // imprime dia/hora/minuto/segundos.
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21);

            // imprime dia/hora/minuto/segundos/mile segundo.
            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);

            // Metodos From.

            // imprime dias/horas.
            TimeSpan t7 = TimeSpan.FromDays(1.5);

            //imprime horas/minutos
            TimeSpan t8 = TimeSpan.FromHours(1.5);

            //imprime minutos/segundos.
            TimeSpan t9 = TimeSpan.FromMinutes(1.5);

            // imprime segundos/mile segundos.
            TimeSpan t10 = TimeSpan.FromSeconds(1.5);

            // imprime mile segundos/ ticks.
            TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);

            // imprime o tempo em relação a ticks numeros Long.
            TimeSpan t12 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);
            Console.WriteLine(t12);


        }
    }
}