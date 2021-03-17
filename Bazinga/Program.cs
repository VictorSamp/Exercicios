using System;

namespace Bazinga
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeDeTestes;
            string[] valorEscolhido;
            string escolhaSheldon, escolhaRaj;

            quantidadeDeTestes = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= quantidadeDeTestes; contador++)
            {
                valorEscolhido = Console.ReadLine().Split(' ');

                escolhaSheldon = valorEscolhido[0];
                escolhaRaj = valorEscolhido[1];

                ValidarVencedor(escolhaSheldon, escolhaRaj, contador);
            }
        }

        static void ValidarVencedor(string escolhaSheldon, string escolhaRaj, int contador)
        {
            if (escolhaSheldon == escolhaRaj)
            {
                Console.WriteLine($"Caso #{contador}: De novo!");
            }
            else
            {
                if (escolhaSheldon == "tesoura" && (escolhaRaj == "papel" || escolhaRaj == "lagarto"))
                {
                    Console.WriteLine($"Caso #{contador}: Bazinga!");
                }
                if (escolhaSheldon == "papel" && (escolhaRaj == "pedra" || escolhaRaj == "Spock"))
                {
                    Console.WriteLine($"Caso #{contador}: Bazinga!");
                }
                if (escolhaSheldon == "pedra" && (escolhaRaj == "lagarto" || escolhaRaj == "tesoura"))
                {
                    Console.WriteLine($"Caso #{contador}: Bazinga!");
                }
                if (escolhaSheldon == "lagarto" && (escolhaRaj == "Spock" || escolhaRaj == "papel"))
                {
                    Console.WriteLine($"Caso #{contador}: Bazinga!");
                }
                if (escolhaSheldon == "Spock" && (escolhaRaj == "tesoura" || escolhaRaj == "pedra"))
                {
                    Console.WriteLine($"Caso #{contador}: Bazinga!");
                }
                if (escolhaRaj == "tesoura" && (escolhaSheldon == "papel" || escolhaSheldon == "lagarto"))
                {
                    Console.WriteLine($"Caso #{contador}: Raj trapaceou!");
                }
                if (escolhaRaj == "papel" && (escolhaSheldon == "pedra" || escolhaSheldon == "Spock"))
                {
                    Console.WriteLine($"Caso #{contador}: Raj trapaceou!");
                }
                if (escolhaRaj == "pedra" && (escolhaSheldon == "lagarto" || escolhaSheldon == "tesoura"))
                {
                    Console.WriteLine($"Caso #{contador}: Raj trapaceou!");
                }
                if (escolhaRaj == "lagarto" && (escolhaSheldon == "Spock" || escolhaSheldon == "papel"))
                {
                    Console.WriteLine($"Caso #{contador}: Raj trapaceou!");
                }
                if (escolhaRaj == "Spock" && (escolhaSheldon == "tesoura" || escolhaSheldon == "pedra"))
                {
                    Console.WriteLine($"Caso #{contador}: Raj trapaceou!");
                }
            }
        }
    }
}
