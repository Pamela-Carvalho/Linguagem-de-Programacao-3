using System;

namespace Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, tempo;

            Console.WriteLine("-----------Você pode se aposentar?---------");
            Console.WriteLine("Idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Tempo de serviço: ");
            tempo = int.Parse(Console.ReadLine());

            if ((idade >= 65) || (tempo >= 30) || ((idade >= 60) && (tempo >= 25)))
                Console.WriteLine("Você já pode se aposentar.");
            else
                Console.WriteLine("Você ainda não pode se aposentar");
        }
    }
}
