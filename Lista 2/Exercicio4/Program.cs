﻿using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Insira um número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro número: ");
            num2 = int.Parse(Console.ReadLine());

            if(num1 > num2) {
                Console.WriteLine(num1 + " é maior do que " + num2);
                Console.WriteLine("A diferença entre eles é " + (num1 - num2));
            }
            else {
                Console.WriteLine(num2 + " é maior do que " + num1);
                Console.WriteLine("A diferença entre eles é " + (num2 - num1));
            }
        }
    }
}
