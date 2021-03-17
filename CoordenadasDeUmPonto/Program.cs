using System;

namespace CoordenadasDeUmPonto
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            decimal pontoX = decimal.Parse(input[0]);
            decimal pontoY = decimal.Parse(input[1]);

            EncontrarCoordenada(pontoX, pontoY);
        }

        static void EncontrarCoordenada(decimal pontoX, decimal pontoY)
        {
            if (pontoX == 0 && pontoY == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (pontoX == 0 && pontoY != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (pontoX != 0 && pontoY == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (pontoX > 0 && pontoY > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (pontoX < 0 && pontoY > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (pontoX < 0 && pontoY < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
