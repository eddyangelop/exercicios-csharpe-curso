using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[]args)
        {

            double[,] mat = new double[2, 3];

            // quantos elementos tem na matriz
            Console.WriteLine(mat.Length);

            // quanto é a primeira dimenssão da matriz(quantidade de linhas)
            Console.WriteLine(mat.Rank);

            // indica o tamanho da dimensão zero(linhas)
            Console.WriteLine(mat.GetLength(0));

            // indica o tamanho da dimenssão um(colunas)
            Console.WriteLine(mat.GetLength(1));


        }
    }
}