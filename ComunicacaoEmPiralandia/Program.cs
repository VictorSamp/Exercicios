using System;
using System.Linq;

namespace ComunicacaoEmPiralandia
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string v = new string(n.Reverse().ToArray());
            Console.WriteLine(v);
        }
    }
}
