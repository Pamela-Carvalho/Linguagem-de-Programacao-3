using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia uma temperatura em graus Celsius e apresente-a convertida em graus Fahrenheit. A fórmula de conversão é: F = C ∗ (9.0 / 5.0) + 32.0, sendo F a temperatura em Fahrenheit e C a temperatura em Celsius.

            double temp, convertido;
            Console.WriteLine("Qual temperatura em Celsius você gostaria de saber em Fahrenheit?");
            temp = double.Parse(Console.ReadLine());

            convertido = temp * (9.0 / 5.0) + 32;

            Console.WriteLine("A temperatura de Fahrenheit é " + convertido);
        }
    }
}
