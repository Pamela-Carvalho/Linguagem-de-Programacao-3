using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;
            string sexo;

            Console.WriteLine("-----------Calcule seu peso ideal-----------");
            Console.WriteLine("Altura (em metros): ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Sexo (digite 'feminino' ou 'masculino'): ");
            sexo = Console.ReadLine();

            if (sexo.ToLower() == "masculino")
                Console.WriteLine("O peso ideal é " + ((72.7 * altura) - 58.0));
            else if (sexo.ToLower() == "feminino")
                Console.WriteLine("O peso ideal é " + ((62.1 * altura) - 44.7));
            else
                Console.WriteLine("O dado informado é inválido");
        }
    }
}
