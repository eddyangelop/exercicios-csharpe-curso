﻿using System;
using System.Net.WebSockets;

namespace ConjuntosSortedSet02
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            PrintCollection(a);

            Console.WriteLine();

            //union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b); 
            PrintCollection(c);

            Console.WriteLine();

            //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            Console.WriteLine();

            // difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);

        }

        static void PrintCollection<T> (IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
