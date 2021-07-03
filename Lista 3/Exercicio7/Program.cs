using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Insira um número inteiro positivo par: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("\nOs números pares de 0 até " + num + " são: ");

            int cont = 0;

            do
            {
                cont++;

                if ((cont % 2) == 0)
                    Console.WriteLine(cont);
            }
            while (cont < num);
        }
    }
}
