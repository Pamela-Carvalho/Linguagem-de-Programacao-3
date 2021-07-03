using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            float trabalho, avaliacao, exame, media;

            Console.WriteLine("Insira as respestivas notas com um valor de 0 a 10.");
            Console.WriteLine("Trabalho de laboratório: ");
            trabalho = float.Parse(Console.ReadLine());

            Console.WriteLine("Avaliação semestral: ");
            avaliacao = float.Parse(Console.ReadLine());

            Console.WriteLine("Exame final: ");
            exame = float.Parse(Console.ReadLine());

            media = ((trabalho * 2) + (avaliacao * 3) + (exame * 5)) / 10;

            Console.WriteLine("Nota final: " + media);

            if ((media >= 5) && (media <= 10))
                Console.WriteLine("O aluno foi aprovado.");
            else if ((media >= 3) && (media <= 4.9))
                Console.WriteLine("O aluno está de recuperação.");
            else if ((media >= 0) && (media <= 2.9))
                Console.WriteLine("O aluno foi reprovado.");
        }
    }
}
