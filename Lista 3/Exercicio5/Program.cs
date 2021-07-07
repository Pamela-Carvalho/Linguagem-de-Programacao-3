using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool aux = false;

            Console.WriteLine("Insira um número: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nO primeiro múltiplo de 11, 13 ou 17 é ");
            for(num = num + 1; aux == false; num++) { 
                if(num % 11 == 0) {
                    Console.Write(num + ", um múltiplo de 11");
                    aux = true;
                }
                else if (num % 13 == 0)
                {
                    Console.Write(num + ", um múltiplo de 13");
                    aux = true;
                }
                else if (num % 17 == 0)
                {
                    Console.Write(num + ", um múltiplo de 17");
                    aux = true;
                }
            }
        }
    }
}
