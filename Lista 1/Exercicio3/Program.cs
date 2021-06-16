using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Peça ao usuário para digitar três valores inteiros e imprima a soma deles.

            int num1, num2, num3;

            Console.WriteLine("Insira 3 números inteiros: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(num1 + "+" + num2 + "+" + num3 + "=" + (num1 + num2 + num3));
        }
    }
}
