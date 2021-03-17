using System;

namespace Tuitando
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = Console.ReadLine();
            char[] vetorCaracteres = texto.ToCharArray();

            if (vetorCaracteres.Length <= 140)
                Console.WriteLine("TWEET");
            else
                Console.WriteLine("MUTE");
        }
    }
}
