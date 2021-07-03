using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Repetição com for");
            
            for (int i = 1; i <= 100; i++)
                Console.WriteLine(i);

            Console.WriteLine("\nRepetição com while");

            int y = 1;
            while (y <= 100) {
                Console.WriteLine(y);
                y++;
            }   

            Console.WriteLine("\nRepetição com do-while");

            int z = 1;
            do {
                Console.WriteLine(z);
                z++;
            }
            while (z <= 100);
        }
    }
}
