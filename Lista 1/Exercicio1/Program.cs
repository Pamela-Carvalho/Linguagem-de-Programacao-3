using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça uma programa que leia um número inteiro e o imprima.

            int num;

            Console.WriteLine("Insira um número inteiro: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou o número " + num + ".");
        }
    }
}
