using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o caractere da linha: ");
            char l = char.Parse(Console.ReadLine());

            Console.Write("Digite o número da coluna: ");
            int c = int.Parse(Console.ReadLine());

            PosicaoXadrez pos = new PosicaoXadrez(l, c);

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());

            Console.ReadLine();
        }
    }
}
