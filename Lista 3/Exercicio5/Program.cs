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

            //int num;
            //int mult = 0;

            //Console.WriteLine(" Entre com um número inteiro: ");
            //num = int.Parse(Console.ReadLine());

            //for(int  i = num + 1 ; mult == 0; i++ )
            //{
                //mult = (i % 11 == 0) || (i % 13 == 0) || (i % 17 == 0) ? i : 0;
            //}
            //Console.WriteLine(" O primeiro número principal múltiplo de 11, 13 ou 17 é: " + mult);
        }
    }
}
