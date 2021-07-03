using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            for(int i = 0; i < 10; i++) {
                int num;
                
                Console.WriteLine("Insira um número: ");
                num = int.Parse(Console.ReadLine());

                soma += num;
            }

            Console.WriteLine("A soma dos números é " + soma);
        }
    }
}
