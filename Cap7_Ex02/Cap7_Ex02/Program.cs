using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap7_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {

            CadAluno ALUNO = new CadAluno();
            float MEDIA;

            Console.Write("Entre o nome...: ");
            ALUNO.NOME = Console.ReadLine();
            Console.Write("Entre a sala ....: ");
            ALUNO.SALA = Console.ReadLine();
            Console.Write("Entre a nota 1 ..: ");
            ALUNO.N1 = float.Parse(Console.ReadLine());
            Console.Write("Entre a nota 2 ..: ");
            ALUNO.N2 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Nome ................: " + ALUNO.NOME);
            Console.WriteLine("Sala ................: " + ALUNO.SALA);
            MEDIA = ALUNO.CalcMedia(ALUNO.N1, ALUNO.N2);
            Console.WriteLine("Media ...............: " + MEDIA);
            Console.Write("Situação ................: ");

            if (CadAluno.CondAluno(ALUNO.CalcMedia(ALUNO.N1, ALUNO.N2), 5.0))
                Console.WriteLine("Aprovado");
            else
                Console.WriteLine("Reprovado");

            Console.WriteLine();
            Console.Write("Tecla algo para encerrar...");
        }
    }
}
