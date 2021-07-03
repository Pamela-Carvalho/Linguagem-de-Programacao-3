using System;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            float ladoA, ladoB, ladoC;

            Console.WriteLine("Insira os lados do triângulo");
            Console.WriteLine("A: ");
            ladoA = float.Parse(Console.ReadLine());

            Console.WriteLine("B: ");
            ladoB = float.Parse(Console.ReadLine());

            Console.WriteLine("C: ");
            ladoC = float.Parse(Console.ReadLine());

            if(((ladoA + ladoB) > ladoC) && ((ladoA + ladoC) > ladoB) && ((ladoC + ladoB) > ladoA)) {
                if ((ladoA == ladoB) && (ladoB == ladoC))
                    Console.WriteLine("O triângulo é equilátero.");
                else if ((ladoA != ladoB) && (ladoA != ladoC) && (ladoB != ladoC))
                    Console.WriteLine("O triângulo é escaleno.");
                else
                    Console.WriteLine("O triângulo é isósceles");
            }
            else
                Console.WriteLine("Os dados informados não comportam um triângulo");
        }
    }
}
