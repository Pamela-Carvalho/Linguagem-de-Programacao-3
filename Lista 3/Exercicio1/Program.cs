using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, aux = 0;
            do
            {
                cont++;

                if ((cont % 3) == 0)
                {
                    Console.WriteLine(cont);
                    aux++;
                }
            }
            while (aux < 5);
        }
    }
}
