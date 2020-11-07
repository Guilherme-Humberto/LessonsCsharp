// Trabalhando com arrays

using System;
using System.Collections.Generic;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usuarios = new string[4] { "Guilherme", "Humberto", "Ana", "Maria" };
            
            foreach (var users in usuarios)
            {
                Console.WriteLine(users);
            }

            Console.WriteLine();

            List<string> frutas = new List<string>()
            {
                "Banana", 
                "Maça", 
                "Laranja", 
                "Uva"
            };

            foreach (var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            Console.WriteLine();

            Console.Write("Digite o nome de alguma objeto: ");
            string objeto = Console.ReadLine();

            List<string> objetos = new List<string>();

            objetos.Add(objeto);

            foreach (var item in objetos)
            {
                Console.WriteLine(item);
            }

        }
    }
}
