using System;

namespace propriedades_time_span
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demo: MaxValue, MinValue, Zero
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            Console.WriteLine("---------------------------------");

            // Demo - propriedades
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);

            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);

            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            Console.WriteLine("-----------------------------------------");

            //Demo - operações
            TimeSpan op1 = new TimeSpan(1, 30, 10);
            TimeSpan op2 = new TimeSpan(0, 10, 5);
            TimeSpan sum = op1.Add(op2);
            TimeSpan dif = op1.Subtract(op2);
            TimeSpan mult = op2.Multiply(2.0);
            TimeSpan div = op2.Divide(2.0);
            Console.WriteLine(op1);
            Console.WriteLine(op2);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}
