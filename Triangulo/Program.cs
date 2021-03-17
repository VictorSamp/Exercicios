using System;
using System.Globalization;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double ladoA, ladoB, ladoC;
            string[] valores = Console.ReadLine().Split(' ');
            ladoA = double.Parse(valores[0], CultureInfo.InvariantCulture);
            ladoB = double.Parse(valores[1], CultureInfo.InvariantCulture);
            ladoC = double.Parse(valores[2], CultureInfo.InvariantCulture);

            ValidarTriangulo(ladoA, ladoB, ladoC);
        }

        static void ValidarTriangulo(double ladoA, double ladoB, double ladoC)
        {
            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoB))
            {
                double perimetro = ladoA + ladoB + ladoC;
                Console.WriteLine("Perimetro = {0}", perimetro
                    .ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                double area = ((ladoA + ladoB) * ladoC) / 2;
                Console.WriteLine("Area = {0}", area
                    .ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
