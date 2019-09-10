using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap2_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {

            String NOME;

            Console.Write("Entre seu nome: ");
            NOME = Console.ReadLine();
            Console.WriteLine("Olá, " + NOME);

            Console.WriteLine();
            Console.WriteLine("Tecle <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}
