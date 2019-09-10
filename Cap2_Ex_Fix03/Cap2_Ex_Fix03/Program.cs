using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*CONVERSOR - FAHRENHEIT - CELSIUS*/

namespace Cap2_Ex_Fix03
{
    class Program
    {
        static void Main(string[] args)
        {

            float C, F;

            Console.Write("Qual é o valor em Fahrenheit?: ");
            F = float.Parse(Console.ReadLine());

            C = ((F - 32) * 5) / 9;

            Console.WriteLine();
            Console.Write("O valor convertido para Celsius é de aproximadamente: " + C.ToString("##,#0.0") + " °C");
            Console.WriteLine();
        }
    }
}
