using System;

namespace VisitaNaFeira
{
    class Program
    {
        static void Main(string[] args)
        {
            int pimentaoAmarelo, pimentaoVermelho, total;
            string[] input = Console.ReadLine().Split(' ');
            pimentaoAmarelo = int.Parse(input[0]);
            pimentaoVermelho = int.Parse(input[1]);

            total = pimentaoAmarelo + pimentaoVermelho;

            Console.WriteLine("X = {0}", total);
        }
    }
}
