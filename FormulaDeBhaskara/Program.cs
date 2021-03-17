using System;
using System.Globalization;

namespace FormulaDeBhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double ladoA, ladoB, ladoC;
            string[] valor = Console.ReadLine().Split();

            ladoA = double.Parse(valor[0]);
            ladoB = double.Parse(valor[1]);
            ladoC = double.Parse(valor[2]);

            CalcularBhaskara(ladoA, ladoB, ladoC);
        }

        static void CalcularBhaskara(double ladoA, double ladoB, double ladoC)
        {
            double delta, raiz1, raiz2;

            delta = (Math.Pow(ladoB, 2) - (4 * ladoA * ladoC));
            raiz1 = (-ladoB + Math.Sqrt(delta)) / (2 * ladoA);
            raiz2 = (-ladoB - Math.Sqrt(delta)) / (2 * ladoA);

            if ((2 * ladoA) != 0 || delta <= 0)
            {
                Console.WriteLine("R1 = {0}", raiz1
                    .ToString("F5", CultureInfo.InvariantCulture));

                Console.WriteLine("R2 = {0}", raiz2
                    .ToString("F5", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}
