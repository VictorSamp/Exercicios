using System;

namespace SomaSimples
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int valor1 = Convert.ToInt32(Console.ReadLine());
            int valor2 = Convert.ToInt32(Console.ReadLine());

            int soma = valor1 + valor2;

            Console.WriteLine("SOMA = {0}", soma);
        }
    }
}