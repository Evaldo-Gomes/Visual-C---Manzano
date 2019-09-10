using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap5_Ex08
{
    class Program
    {
        static void Main(string[] args)
        {

            double V1 = 15.55;
            int V2 = (int)V1;
            //SE FOSSE FEITA A OPERAÇÃO - V2 = V1 - DARIA ERRO!
            // .55 NÃO PODE SER GUARDADO NA VARIÁVEL INT V2!

            Console.WriteLine(V2);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar...");
            Console.ReadKey();

        }
    }
}
