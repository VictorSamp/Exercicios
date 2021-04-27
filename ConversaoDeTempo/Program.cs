using System;

namespace ConversaoDeTempo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int N, seg, min, hr, resto;

            N = int.Parse(Console.ReadLine());

            hr = (int)N / 3600;
            resto = N % 3600;

            min = resto / 60;
            resto = resto % 60;

            seg = resto;

            Console.WriteLine(hr + ":" + min + ":" + seg);
        }
    }
}