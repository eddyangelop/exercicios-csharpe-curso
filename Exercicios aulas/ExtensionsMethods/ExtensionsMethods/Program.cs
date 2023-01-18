using System;

namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2022, 12, 26, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }

    }
}