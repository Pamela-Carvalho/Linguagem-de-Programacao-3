using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux, menor, maior;

            Console.WriteLine("Para encerrar forneça um valor negativo.");
            Console.WriteLine("Insira um número: ");
            aux = int.Parse(Console.ReadLine());
            menor = aux;
            maior = aux;

            if(aux >= 0) {
                do
                {
                    Console.WriteLine("Insira um número: ");
                    aux = int.Parse(Console.ReadLine());

                    if(aux >= 0) {
                        if (aux < menor)
                            menor = aux;

                        if (aux > maior)
                            maior = aux;
                    }

                }
                while (aux >= 0);
            }

            Console.WriteLine("Menor número: " + menor);
            Console.WriteLine("Maior número: " + maior);
        }
    }
}
