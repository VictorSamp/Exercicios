using System;

namespace Bazinga
{
    class Program
    {
        static void Main()
        {
            string[] escolhas = { "tesoura", "papel", "pedra", "lagarto", "Spock" };
            string escolhaSheldon, escolhaRaj;

            int qtdTeste = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= qtdTeste; contador++)
            {
                string[] valores = Console.ReadLine().Split(" ");
                escolhaSheldon = valores[0];
                escolhaRaj = valores[1];

                if (escolhaSheldon == escolhaRaj)
                    Console.WriteLine($"Caso #{contador}: De novo!");

                else
                {
                    if (escolhaSheldon == escolhas[0] && (escolhaRaj == escolhas[1] || escolhaRaj == escolhas[3]) ||
                        escolhaSheldon == escolhas[1] && (escolhaRaj == escolhas[2] || escolhaRaj == escolhas[4]) ||
                        escolhaSheldon == escolhas[2] && (escolhaRaj == escolhas[0] || escolhaRaj == escolhas[3]) ||
                        escolhaSheldon == escolhas[3] && (escolhaRaj == escolhas[1] || escolhaRaj == escolhas[4]) ||
                        escolhaSheldon == escolhas[4] && (escolhaRaj == escolhas[0] || escolhaRaj == escolhas[2]))
                    {
                        Console.WriteLine($"Caso #{contador}: Bazinga!");

                    }
                    else
                    {
                        Console.WriteLine($"Caso #{contador}: Raj trapaceou!");

                    }
                }
            }
        }
    }
}
