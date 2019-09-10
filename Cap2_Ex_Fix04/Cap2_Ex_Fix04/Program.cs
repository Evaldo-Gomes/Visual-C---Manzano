using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*CONVERSOR CELSIUS - FAHRENHEIT*/

namespace Cap2_Ex_Fix04
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, F;

            Console.Write("Qual é o valor em Celsius?: ");
            C = double.Parse(Console.ReadLine());

            F = (C * 1.8) + 32;

            Console.WriteLine();
            Console.Write("O valor convertido para Fahrenheit é de aproximadamente: " + F.ToString("##,#0.0") + " °F");
            Console.WriteLine();
        }
    }
}
