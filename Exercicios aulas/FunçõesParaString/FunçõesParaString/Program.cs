using System;

namespace funcoes_strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string original = "abcde FGHIJ ABC abc DEFG ";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);

            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            // imprime valores originais no console.
            Console.WriteLine("Original: -" + original + "-");

            // imprime valores em maiusculo.
            Console.WriteLine("ToUpper: -" + s1 + "-");

            // imprime valores em minusculo.
            Console.WriteLine("ToLower: -" + s2 + "-");

            // retira os espços em branco dos objetos da string original.
            Console.WriteLine("Trim: -" + s3 + "-");

            // indentifica a posição inicial do objeto na string.
            Console.WriteLine("IndexOf('bc'): " + n1);

            // identifica a posição final da ocorrencia do objeto na string.
            Console.WriteLine("LastIndexOf('bc'): " + n2);

            // recorta o objeto a partir da posição do objeto em diante.
            Console.WriteLine("Substring(3): -" + s4 + "-");

            // recorta o objeto entre as posições.
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");

            // substitui o string original por outro string onde tiver ocorrencia.
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            // substitui o string original por outro string onde tiver ocorrencia.
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");

            //testa se a string recebeu um valor nulo ou vazio.
            Console.WriteLine("IsNullOrEmpty: " + b1);

            // testa se a string recebeu um valor nulo ou espaços vazios.
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);




        }
    }
}