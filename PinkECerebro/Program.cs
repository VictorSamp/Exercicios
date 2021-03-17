using System;

namespace PinkECerebro
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeNumeros = int.Parse(Console.ReadLine());

            string[] listaPink = new string[quantidadeNumeros];
            listaPink = Console.ReadLine().Split(' ');

            int multiplosDe2 = 0,
                multiplosDe3 = 0,
                multiplosDe4 = 0,
                multiplosDe5 = 0;

            foreach (var numero in listaPink)
            {
                int numeroConvertido = int.Parse(numero);

                if (numeroConvertido % 2 == 0) multiplosDe2++;
                if (numeroConvertido % 3 == 0) multiplosDe3++;
                if (numeroConvertido % 4 == 0) multiplosDe4++;
                if (numeroConvertido % 5 == 0) multiplosDe5++;
            }

            Console.WriteLine($"{multiplosDe2} Multiplo(s) de 2");
            Console.WriteLine($"{multiplosDe3} Multiplo(s) de 3");
            Console.WriteLine($"{multiplosDe4} Multiplo(s) de 4");
            Console.WriteLine($"{multiplosDe5} Multiplo(s) de 5");
        }
    }
}
