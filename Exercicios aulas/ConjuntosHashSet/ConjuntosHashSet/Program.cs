using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace conjuntosHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("TV"));
            Console.WriteLine(set.Contains("Computer"));

            Console.WriteLine();

            foreach (string p in set)
            {
                Console.WriteLine(p);
            }

        }
    }
}
