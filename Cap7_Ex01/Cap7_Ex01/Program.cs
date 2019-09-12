using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap7_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {

            CadAluno ALUNO = new CadAluno();

            Console.Write("Entre o nome...: ");
            ALUNO.NOME = Console.ReadLine();
            Console.Write("Entre a sala...: ");
            ALUNO.SALA = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Entre as notas:");
            Console.WriteLine();
            for (int i = 0; i <= 3; i++)
            {
                Console.Write("{0}° nota ......: ", i + 1);
                ALUNO.NOTA[i] = float.Parse(Console.ReadLine());
            }
            ALUNO.CalcMedia();

            Console.WriteLine();
            Console.WriteLine("Nome ...........: {0}", ALUNO.NOME);
            Console.WriteLine("Sala ...........: {0}", ALUNO.SALA);
            Console.WriteLine();
            Console.WriteLine("Notas: ");
            Console.WriteLine();
            for (int i = 0; i <= 3; i++)
            {
                Console.Write("{0}° nota ......: ", i + 1);
                Console.WriteLine("{0,5:0.00}", ALUNO.NOTA[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Média .......: {0,5:0.00}", ALUNO.CalcMedia());

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar...");
        }
    }
}
