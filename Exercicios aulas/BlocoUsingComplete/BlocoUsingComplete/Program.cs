using System;

namespace BlocoUsingComplete
{
    class Program
    {
        static void Main(string[] args)
        {
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


        }
    }
}
