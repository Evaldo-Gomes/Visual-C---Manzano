using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*POLIMORFISMO UNIVERSAL DE INCLUSÃO*/

namespace Cap7_Ex04
{
    class Program
    {

        class ClassePai
        {
            public virtual void Executa()
            {
                Console.WriteLine("Ação na classe-pai");
            }
        }

        class ClasseFilho : ClassePai
        {
            public override void Executa()
            {
                Console.WriteLine("Ação na classe-filho");
            }
        }

        static void Main(string[] args)
        {

            ClassePai PAI = new ClassePai();
            ClasseFilho FILHO = new ClasseFilho();

            PAI.Executa();
            FILHO.Executa();

            PAI = FILHO;
            PAI.Executa();

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar...");
            Console.ReadKey();

        }
    }
}
