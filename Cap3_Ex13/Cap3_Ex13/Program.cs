using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap3_Ex06
{
    class Program
    {
        static void Main(string[] args)
        {

            int DIVIDENDO, DIVISOR, QUOCIENTE;

            Console.Write("Entre como o valor do dividendo: ");
            DIVIDENDO = int.Parse(Console.ReadLine());

            Console.Write("Entre commo valor do divisor: ");
            DIVISOR = int.Parse(Console.ReadLine());

            QUOCIENTE = DIVIDENDO / DIVISOR;

            Console.WriteLine();
            Console.WriteLine("Resultado = {0}", QUOCIENTE);

            Console.WriteLine();
            Console.Write("Tecle <enter> para encerrar...");
            Console.WriteLine();


        }
    }
}
