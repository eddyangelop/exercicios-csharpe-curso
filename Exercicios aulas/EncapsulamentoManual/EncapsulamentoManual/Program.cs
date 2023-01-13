using System;
using System.Globalization;
namespace EncapsulamentoManual
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("T");

            // (não aceita modificação do produto pelo Set por conta do metodo Get)
            // p.Setpreco(100.00);

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
        }
    }
}

