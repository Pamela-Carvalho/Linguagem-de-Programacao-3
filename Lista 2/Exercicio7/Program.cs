using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, emprestimo;

            Console.WriteLine("Salário: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor da prestação do empréstimo: ");
            emprestimo = double.Parse(Console.ReadLine());

            if (emprestimo > ((20.0 / 100.0) * salario))
                Console.WriteLine("Empréstimo não concedido");
            else
                Console.WriteLine("Empréstimo concedido");
        }
    }
}
