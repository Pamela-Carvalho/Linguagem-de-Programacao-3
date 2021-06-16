using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia um número real e imprima a quinta parte deste número.

            float num;

            Console.WriteLine("Insira um número real: ");
            num = float.Parse(Console.ReadLine());

            Console.WriteLine("A quinta parte de " + num + " é " + num / 5);
        }
    }
}
