using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, media;

            Console.WriteLine("Insira as notas de 0 a 10");
            Console.WriteLine("Nota 1: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Nota 2: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Nota 3: ");
            nota3 = float.Parse(Console.ReadLine());

            media = (((nota1 * 1) + (nota2 * 1) + (nota3 * 2)) / 4) * 10;

            Console.WriteLine("A média do aluno é " + media);

            if (media >= 60)
                Console.WriteLine("O aluno foi aprovado.");
            else
                Console.WriteLine("O aluno foi reprovado.");
        }
    }
}
