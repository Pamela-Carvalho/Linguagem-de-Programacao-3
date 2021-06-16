using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia uma temperatura em graus Kelvin e apresente-a convertida em graus Celsius. A fórmula de conversão é: C = K − 273.15, sendo C a temperatura em Celsius e K a temperatura em Kelvin.

            double temp, convertido;
            Console.WriteLine("Qual temperatura em Kelvin você gostaria de saber em Celsius?");
            temp = double.Parse(Console.ReadLine());

            convertido = temp - 273.15;

            Console.WriteLine("A temperatura de Celsius é " + convertido);
        }
    }
}
