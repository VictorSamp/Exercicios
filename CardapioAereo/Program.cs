using System;

namespace CardapioAereo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int Ca, Ba, Pa, Cr, Br, Pr, dif1, dif2, dif3, total = 0;
            string[] input1, input2;

            input1 = Console.ReadLine().Split(" ");
            Ca = int.Parse(input1[0]);
            Ba = int.Parse(input1[1]);
            Pa = int.Parse(input1[2]);

            input2 = Console.ReadLine().Split(" ");
            Cr = int.Parse(input2[0]);
            Br = int.Parse(input2[1]);
            Pr = int.Parse(input2[2]);

            dif1 = Ca - Cr;
            dif2 = Ba - Br;
            dif3 = Pa - Pr;

            if (dif1 < 0)
            {
                total = dif1;
            }
            if (dif2 < 0)
            {
                total = total + dif2;
            }
            if (dif3 < 0)
            {
                total = total + dif3;
            }

            Console.WriteLine(Math.Abs(total));
        }
    }
}