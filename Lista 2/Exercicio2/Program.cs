using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Insira um número: ");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("O quadrado de " + num + " é " + Math.Pow(num, 2));
                Console.WriteLine("A raiz quadrada de " + num + " é " + Math.Sqrt(num));
            }
        }
    }
}
