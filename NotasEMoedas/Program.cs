using System;
using System.Collections.Generic;
using System.Globalization;

namespace NotasEMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal valorMonetario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<decimal> notas = new List<decimal> { 100.00m, 50.00m, 20.00m, 10.00m, 5.00m, 2.00m };
            List<decimal> moedas = new List<decimal> { 1.00m, 0.50m, 0.25m, 0.10m, 0.05m, 0.01m };

            Console.WriteLine("NOTAS:");

            for (int i = 0; i < notas.Count; i++)
            {
                decimal nota = notas[i];
                int quociente = (int)(valorMonetario / notas[i]);
                valorMonetario %= notas[i];
                Console.WriteLine("{0} nota(s) de R$ {1}", quociente, nota.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine("MOEDAS:");

            for (int i = 0; i < moedas.Count; i++)
            {
                decimal moeda = moedas[i];
                int quociente = (int)(valorMonetario / moedas[i]);
                valorMonetario %= moedas[i];
                Console.WriteLine("{0} moeda(s) de R$ {1}", quociente, moeda.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
