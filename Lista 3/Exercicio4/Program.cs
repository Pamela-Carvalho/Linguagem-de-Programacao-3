using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Insira um número: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("\nOs " + num + " primeiros ímpares são: ");

            int cont = 0;

            do {
                cont++;

                if ((cont % 2) == 1)
                {
                    Console.WriteLine(cont);
                    num--;
                }
            }
            while (num > 0);
        }
    }
}
