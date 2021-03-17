using System;
using System.Globalization;

namespace AumentoDeSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double novoSalario;
            double reajuste;
            double percentual;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario < 0.00)
            {
                return;
            }
            else if (salario <= 400.00)
            {
                percentual = 15;
                reajuste = salario * (percentual / 100);
                novoSalario = salario + reajuste;
            }
            else if (salario <= 800.00)
            {
                percentual = 12;
                reajuste = salario * (percentual / 100);
                novoSalario = salario + reajuste;
            }
            else if (salario <= 1200.00)
            {
                percentual = 10;
                reajuste = salario * (percentual / 100);
                novoSalario = salario + reajuste;
            }
            else if (salario <= 2000.00)
            {
                percentual = 7;
                reajuste = salario * (percentual / 100);
                novoSalario = salario + reajuste;
            }
            else
            {
                percentual = 4;
                reajuste = salario * (percentual / 100);
                novoSalario = salario + reajuste;
            }

            Console.WriteLine("Novo salario: {0}", novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: {0}", reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: {0} %", percentual);
        }
    }
}
