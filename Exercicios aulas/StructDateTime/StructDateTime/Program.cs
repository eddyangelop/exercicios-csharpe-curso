using System;
using System.ComponentModel.Design.Serialization;

namespace date_time
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);

            // Propriedades do DateTime.
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            Console.WriteLine("--------------------------------------");
       

            // Date time para string.
            DateTime d1= new DateTime(2001, 8, 15, 13, 45, 58);

            string s1 = d1.ToLongDateString();
            string s2 = d1.ToLongTimeString();
            string s3 = d1.ToShortDateString();
            string s4 = d1.ToShortTimeString();
            string s5 = d1.ToString();
            string s6 = d1.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d1.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            Console.WriteLine("---------------------------------------");

            // Date time add.
            DateTime x1 = DateTime.Now;
            DateTime y0 = x1.AddDays(7);
            


            DateTime x = new DateTime(2001, 8, 15, 13, 45, 58);

            Console.WriteLine("DateTime: 2001, 8, 15, 13, 45, 58");

            DateTime y1 = x.AddDays(1);
            DateTime y2 = x.AddHours(2);      
            DateTime y3 = x.AddMinutes(3);
            DateTime y4 = x.AddMonths(1);
            DateTime y5 = x.AddSeconds(1);
            DateTime y6 = x.AddMilliseconds(5);
            DateTime y7 = x.AddTicks(9000000000L);
            DateTime y8 = x.AddYears(1);

            Console.WriteLine("Esta é a data e hora atual do boleto: " + x1);
            Console.WriteLine("O seu vencimento está para o dia: " + y0); 

            Console.WriteLine();
            Console.WriteLine("RESULTADOS:");
            Console.WriteLine();

            Console.WriteLine("Dias: " + y1);
            Console.WriteLine("Horas: " + y2);
            Console.WriteLine("Minutos: " + y3);
            Console.WriteLine("Meses: " + y4);
            Console.WriteLine("Segundos: " + y5);
            Console.WriteLine("Mile segundos: " + y6);
            Console.WriteLine("Tiks: " + y7);
            Console.WriteLine("Anos: " + y8);


            

            

        }
    }
}