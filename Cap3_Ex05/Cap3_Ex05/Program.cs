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
            string NOME1, NOME2, SEXO1, SEXO2;

            Console.Write("Entre com o 1° nome.....................:");
            NOME1 = Console.ReadLine();
            Console.Write("Entre com o sexo do 1° nome.............:");
            SEXO1 = Console.ReadLine();

            Console.Write("Entre com o 2° nome.....................:");
            NOME2 = Console.ReadLine();
            Console.Write("Entre com o sexo do 2° nome.............:");
            SEXO2 = Console.ReadLine();

            Console.WriteLine();
            if (SEXO1 == "M" ^ SEXO2 == "M")
                Console.WriteLine(NOME1 + " dança com " + NOME2);
            else
                Console.WriteLine(NOME1 + " não dança com " + NOME2);

            Console.WriteLine();
            Console.Write("Tecla <enter> para continuar...");
            Console.WriteLine();
        }
    }
}
