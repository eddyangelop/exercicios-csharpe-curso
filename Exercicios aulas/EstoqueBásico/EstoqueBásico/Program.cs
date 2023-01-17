using System;
using System.Globalization;

namespace EstoqueBasico
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no Estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p.ValorTotalEmEstoque();

            //forma ruim de resolver
            //Console.WriteLine(p.Nome + ",$ " + p.Preco.ToString("F2"), CultureInfo.InvariantCulture + ", " + p.Quantidade + " unidades, Total: $ " + p.ValorTotalEmEstoque);

            Console.WriteLine();

            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte =  int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}