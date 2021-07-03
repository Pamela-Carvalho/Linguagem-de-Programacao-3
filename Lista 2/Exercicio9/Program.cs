using System;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            int soma = 0;

            Console.WriteLine("Insira um número inteiro maior que zero: ");
            valor = Console.ReadLine();

            if (int.Parse(valor) > 0) {
                foreach (char x in valor)
                {
                    soma += (int)char.GetNumericValue(x);
                }

                Console.Write("A soma dos algarismos é: " + soma);
            }
            else
                Console.WriteLine("Número inválido");
        }
    }
}
