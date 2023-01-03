using System;
using System.Collections.Generic;
using Predicate.Entities;

namespace PredicateRemoveAll
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("Hd Case", 80.90));

            //expression Lambda
            list.RemoveAll(p => p.Price >= 100.0);
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }           

        }
    }
}
