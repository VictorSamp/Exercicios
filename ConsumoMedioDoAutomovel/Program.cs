using System;
using System.Globalization;

namespace ConsumoMedioDoAutomovel
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia;
            double combustivelGasto, consumoMedio;

            distancia = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            combustivelGasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumoMedio = distancia / combustivelGasto;

            Console.WriteLine("{0} km/l", consumoMedio.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
