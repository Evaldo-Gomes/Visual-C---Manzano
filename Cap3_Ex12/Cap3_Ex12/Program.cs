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

            int NR, PEDIDO;
            Random RANDOMICO = new Random();
            NR = RANDOMICO.Next(1, 6);

            Console.Write("Entre com um número entre 1 e 5: ");
            PEDIDO = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (PEDIDO == NR)
                Console.WriteLine("Acertou! - Foi sorteado: {0}.", NR);
            else
                Console.WriteLine("Errou! - Foi sorteado {0}.", NR);

            Console.WriteLine();
            Console.Write("Tecle <enter> para encerrar...");
            Console.WriteLine();


        }
    }
}
