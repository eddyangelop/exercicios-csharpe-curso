using System;

namespace BlocoUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Forma completa
            /*
            string path = @"c:\temp\filex.txt";

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("an error occurred");
                Console.WriteLine(e.Message);
            }
            */

            //Forma reduzida
            string path = @"c:\temp\file1.txt";

            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("an error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
