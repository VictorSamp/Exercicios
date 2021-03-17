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

            total = Somar(pimentaoAmarelo, pimentaoVermelho);

            Console.WriteLine("X = {0}", total);
        }

        static int Somar(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
    }
}
