using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia um número real e imprima o resultado do quadrado desse número.

            float num;

            Console.WriteLine("Insira um número real: ");
            num = float.Parse(Console.ReadLine());

            Console.WriteLine("O quadrado de " + num + " é igual a " + Math.Pow(num, 2));
        }
    }
}
