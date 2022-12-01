using System;
using System.IO;
using System.Collections.Generic;

namespace directory_directoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder";


            try
            {
                //Metodo Generic
                //IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                //Versão completa
                //Directory.CreateDirectory(@"c:\temp\myfolder\newfolder");

                //Versão resumida
                Directory.CreateDirectory(path + "\\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

    }

}