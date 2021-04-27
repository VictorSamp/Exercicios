using System;

namespace Multiplos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int valor1 = int.Parse(valores[0]);
            int valor2 = int.Parse(valores[1]);

            ValidarMultiplos(valor1, valor2);
        }

        private static void ValidarMultiplos(int valor1, int valor2)
        {
            if (valor1 % valor2 == 0 || valor2 % valor1 == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}