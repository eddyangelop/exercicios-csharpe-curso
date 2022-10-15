using System;

namespace date_time
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);


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

            DateTime x = new DateTime(2001, 8, 15, 13, 45, 58);


            DateTime y1 = x.AddDays(1);
            DateTime y2 = x.AddHours(1);
            DateTime y3 = x.AddMilliseconds(1);
            DateTime y4 = x.AddMinutes(1);
            DateTime y5 = x.AddMonths(1);
            DateTime y6 = x.AddSeconds(1);
            DateTime y7 = x.AddTicks(9000000000L);
            DateTime y8 = x.AddYears(1);

            Console.WriteLine(y1);
            Console.WriteLine(y2);
            Console.WriteLine(y3);
            Console.WriteLine(y4);
            Console.WriteLine(y5);
            Console.WriteLine(y6);
            Console.WriteLine(y7);
            Console.WriteLine(y8);


            DateTime a = new DateTime(2001, 8, 15);
            DateTime b = new DateTime(2001, 8, 18);
            //DateTime x1 = x.Subtract(y);

            TimeSpan t = a.Subtract(b);

            Console.WriteLine(t);
        }
    }
}