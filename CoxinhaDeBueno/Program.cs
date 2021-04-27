using System;
using System.Globalization;

namespace CoxinhaDeBueno
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input;
            int quantidadeCoxinhas, quantidadeParticipantes;
            double media;

            input = Console.ReadLine().Split(' ');

            quantidadeCoxinhas = int.Parse(input[0]);
            quantidadeParticipantes = int.Parse(input[1]);

            media = (double)quantidadeCoxinhas / quantidadeParticipantes;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}