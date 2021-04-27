using System;
using System.Globalization;

namespace CrescimentoPopulacional
{
    class Program
    {
        static void Main(string[] args)
        {
            int casosDeTeste = int.Parse(Console.ReadLine());

            for (int i = 0; i < casosDeTeste; i++)
            {
                int populacaoA, populacaoB;
                double crescimentoPopulacionalA, crescimentoPopulacionalB;

                string[] valores = Console.ReadLine().Split(' ');
                populacaoA = int.Parse(valores[0]);
                populacaoB = int.Parse(valores[1]);
                crescimentoPopulacionalA = double.Parse(valores[2], CultureInfo.InvariantCulture);
                crescimentoPopulacionalB = double.Parse(valores[3], CultureInfo.InvariantCulture);

                CalcularAnos(populacaoA, populacaoB, crescimentoPopulacionalA, crescimentoPopulacionalB);

            }
        }

        static void CalcularAnos(int populacaoA, int populacaoB,
            double crescimentoPopulacionalA, double crescimentoPopulacionalB)
        {
            double anos = 0;

            while (populacaoA <= populacaoB)
            {
                populacaoA += (int)(populacaoA * (crescimentoPopulacionalA / 100));
                populacaoB += (int)(populacaoB * (crescimentoPopulacionalB / 100));
                anos++;

                if (anos > 100)
                {
                    Console.WriteLine("Mais de 1 seculo.");
                    break;
                }
            }

            if (anos <= 100)
            {
                Console.WriteLine($"{anos} anos.");
            }
        }
    }
}
