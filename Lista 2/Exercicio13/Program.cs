using System;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Calcule a área de um trapézio-------");
            float bmenor, bmaior, altura, area;

            Console.WriteLine("Base menor: ");
            bmenor = float.Parse(Console.ReadLine());

            Console.WriteLine("Base maior: ");
            bmaior = float.Parse(Console.ReadLine());

            Console.WriteLine("Altura: ");
            altura = float.Parse(Console.ReadLine());

            area = ((bmenor + bmaior) * altura) / 2;

            Console.WriteLine("A área é " + area);
        }
    }
}
