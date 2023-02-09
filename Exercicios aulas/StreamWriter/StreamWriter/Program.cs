using System;
using System.IO;

namespace streamWriter
{
    class Program
    {
        // cria e escreve um novo arquivo, com letras maiusculas.
        static void Main(string[] args)
        {
            string sourcePath = @"c:\demo\file1.txt";
            string targetPath = @"c:\demo\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = new StreamWriter(targetPath))
                {
                    foreach (string line in lines)
                        sw.WriteLine(line.ToUpper());
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
