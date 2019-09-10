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
            string MES;

            Console.Write("Entre o mês (numérico literal minúsculo): ");
            MES = Console.ReadLine();

            Console.WriteLine();
            switch (MES)
            {
                case "um":
                    Console.WriteLine("Janeiro");
                    break;
                case "dois":
                    Console.WriteLine("Fevereiro");
                    break;
                case "três":
                    Console.WriteLine("Março");
                    break;
                case "quatro":
                    Console.WriteLine("Abril");
                    break;
                case "cinco":
                    Console.WriteLine("Maio");
                    break;
                case "seis":
                    Console.WriteLine("Junho");
                    break;
                case "sete":
                    Console.WriteLine("Julho");
                    break;
                case "oito":
                    Console.WriteLine("Agosto");
                    break;
                case "nove":
                    Console.WriteLine("Setembro");
                    break;
                case "dez":
                    Console.WriteLine("Outubro");
                    break;
                case "onze":
                    Console.WriteLine("Novembro");
                    break;
                case "doze":
                    Console.WriteLine("Dezembro");
                    break;
                default:
                    Console.WriteLine("Mês inválido");
                    break;
            }

            Console.WriteLine();
            Console.Write("Tecle <enter> para encerrar...");
            Console.WriteLine();


        }
    }
}
