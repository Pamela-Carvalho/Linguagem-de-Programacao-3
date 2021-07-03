using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2;

            Console.WriteLine("Insira a primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira a segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());

            if((nota1 >= 0.0) && (nota1 <= 10.0)) {
                if ((nota2 >= 0.0) && (nota2 <= 10.0))
                {
                    Console.WriteLine("A média do(a) aluno(a) é " + (nota1 + nota2) / 2);
                }
                else
                    Console.WriteLine("A segunda nota é inválida.");
            }
            else
                Console.WriteLine("A primeira nota é inválida.");
        }
    }
}
