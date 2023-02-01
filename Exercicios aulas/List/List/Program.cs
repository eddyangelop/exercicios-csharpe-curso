using System;
using System.Collections.Generic;

namespace ListAddInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            // Adiciona objetos na lista
            Console.WriteLine();

            Console.WriteLine("--------------Objetos adicionados na lista---------------------");

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Add("Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // Insere objetos na lista
            Console.WriteLine();

            Console.WriteLine("--------------Objetos inserido na lista------------------------");

            list.Insert(1, "Eddy");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            /*
            // Mostra a quantidade de objetos na lista
            Console.WriteLine();
            Console.WriteLine("--------------Mostra a quantidade de objetos da lista----------");
            Console.WriteLine("List Count: " + list.Count);
            */

            /*
            // Encontra a primeira letra do objeto predicado com a função lambda
            Console.WriteLine();
            Console.WriteLine("--------------Primeiro objeto começado com A-------------------");
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First object 'A': " + s1);
            */

            /*
            // Encontra a ultima letra do objeto predicado com a função lambda
            Console.WriteLine();
            Console.WriteLine("--------------Primeiro objeto termnado com A-------------------");
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last object 'A': " + s2);
            */


            /*
            // Encontra na lista o primeiro e o ultimo nome começados com a letra A
            Console.WriteLine();
            Console.WriteLine("----Posições de objetos começados e terminados com a letra A---");
            int position1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + position1);
            int position2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + position2);
            */

            /*
            // Identifica e mostra objetos com 5 caracteres
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine();
            Console.WriteLine("------------------Objetos com 5 caracteres---------------------");
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }
            */

            /*
            // Remove objeto especifico da lista
            list.Remove("Alex");
            Console.WriteLine();
            Console.WriteLine("---------------Objeto especifico removido----------------------");
            foreach(string obj in list)
            Console.WriteLine(obj);
            */

            /*
            // Remove todos os objetos identificados pelo caracter da lista
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine();
            Console.WriteLine("-----------Objeto removido com caracter especifico-------------");
            foreach (string obj in list)
                Console.WriteLine(obj);
            */

            list.RemoveAt(3);
            Console.WriteLine();
            Console.WriteLine("-----------Objeto removido na posição especifica---------------");
            foreach (string obj in list)
                Console.WriteLine(obj);

            list.RemoveRange(2, 2);
            Console.WriteLine();
            Console.WriteLine("--------Objeto removido na posição especifica e sequencial-----");
            foreach (string obj in list)
                Console.WriteLine(obj);

            Console.ReadLine();
        }

    }
}
