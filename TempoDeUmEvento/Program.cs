using System;

namespace TempoDeUmEvento
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaInicio, horaInicio, minutoInicio, segundoInicio,
                diaFim, horaFim, minutoFim, segundoFim;

            DateTime dataInicio, dataFim;

            string[] input1 = Console.ReadLine().Split(' ');
            diaInicio = int.Parse(input1[1]);

            string[] input2 = Console.ReadLine().Split(" : ");
            horaInicio = int.Parse(input2[0]);
            minutoInicio = int.Parse(input2[1]);
            segundoInicio = int.Parse(input2[2]);

            dataInicio = new DateTime(1, 1, diaInicio, horaInicio, minutoInicio, segundoInicio);

            string[] input3 = Console.ReadLine().Split(' ');
            diaFim = int.Parse(input3[1]);

            string[] input4 = Console.ReadLine().Split(" : ");
            horaFim = int.Parse(input4[0]);
            minutoFim = int.Parse(input4[1]);
            segundoFim = int.Parse(input4[2]);

            dataFim = new DateTime(1, 1, diaFim, horaFim, minutoFim, segundoFim);

            TimeSpan duracao = dataFim.Subtract(dataInicio);

            Console.WriteLine($"{duracao.Days} dia(s)");
            Console.WriteLine($"{duracao.Hours} hora(s)");
            Console.WriteLine($"{duracao.Minutes} minuto(s)");
            Console.WriteLine($"{duracao.Seconds} segundo(s)");
        }
    }
}
