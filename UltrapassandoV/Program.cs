using System;

namespace UltrapassandoV
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int R = int.Parse(Console.ReadLine());
            int V = 0;
            int contador = 1;

            do
            {
                V = int.Parse(Console.ReadLine());
            } while (V <= R);

            int i = R;

            while (i <= V)
            {
                contador++;
                R += 1;
                i += R;
            }

            Console.WriteLine(contador);
        }
    }
}