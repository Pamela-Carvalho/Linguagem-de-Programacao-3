using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia um número real e o imprima.

            float num;

            Console.WriteLine("Insira um número real: ");
            num = float.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou o número " + num + ".");

        }
    }
}
