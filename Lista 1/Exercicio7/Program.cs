using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia uma temperatura em graus Fahrenheit e apresente-a convertida em graus Celsuis. A fórmula de conversão é: C = 5.0∗(F −32.0)/ 9.0, sendo C a temperatura em Celsius e F a temperatura em Fahrenheit.

            double temp, convertido;
            Console.WriteLine("Qual temperatura em Fahrenheit você gostaria de saber em Celsius?");
            temp = double.Parse(Console.ReadLine());

            convertido = (temp - 32) * 5.0 / 9.0;

            Console.WriteLine("A temperatura de Celsius é " + convertido);
        }
    }
}
