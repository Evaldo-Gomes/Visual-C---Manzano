using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap5_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Execução do programa principal - 1");
            SubRotina();
            Console.WriteLine("Execução do programa principal - 2");

            Console.WriteLine();
            Console.Write("Tecle pare encerrar...");
            Console.ReadKey();
        }

        public static void SubRotina()
        {
            Console.WriteLine("Execução do sub-rotina");
        }

    }
}
