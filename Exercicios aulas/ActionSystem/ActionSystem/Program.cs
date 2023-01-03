﻿using System;
using System.Collections.Generic;
using ActionSystem.Entities;

namespace Action
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

            //Expression Action
            Action<Product> act = UpdatePrice;
            list.ForEach(act);

            //Expression Lambda
            //Action<Product> act = p => { p.Price += p.Price * 0.1; };
            //list.ForEach(act);

            //Expression InLine não precisa constructor UpdatePrice!
            //list.ForEach(p => { p.Price += p.Price * 0.1; });


            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
            //p.Price = p.Price * 1.1;
        }



    }
}
