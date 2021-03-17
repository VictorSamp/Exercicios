using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ValidacaoDeNota
{
    class Program
    {
        static List<double> notasValidas = new List<double>();

        static void Main(string[] args)
        {
            do
            {
                double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                ValidarNota(nota);
            } while (notasValidas.Count < 2);

            var media = CalcularMedia(notasValidas);

            Console.WriteLine("media = {0}", media);
        }

        static void ValidarNota(double nota)
        {
            if (nota < 0 || nota > 10.0)
            {
                Console.WriteLine("nota invalida");
            }
            else
            {
                notasValidas.Add(nota);
            }
        }

        static string CalcularMedia(List<double> notasValidas)
        {
            return (notasValidas.Sum() / notasValidas.Count)
                .ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
