using System;
using System.Globalization;

namespace Media1
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            CalcularMediaPonderada(nota1, nota2);
        }

        static void CalcularMediaPonderada(double nota1, double nota2)
        {
            double media = (nota1 * 3.5 + nota2 * 7.5) / 11;
            Console.WriteLine("MEDIA = {0}", media.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
