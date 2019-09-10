using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap3_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUMERO;

            Console.Write("Entre com um valor: ");
            NUMERO = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (NUMERO >= 20 && NUMERO <= 90)
            {
                Console.Write("O valor está entre 20 e 90");
            }
            else
            {
                Console.Write("O valor não está entre 20 e 90");
            }

            Console.WriteLine();
            Console.Write("Tecla <enter> para continuar...");
            Console.WriteLine();
        }
    }
}
