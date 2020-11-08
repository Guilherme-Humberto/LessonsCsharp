using System;

namespace lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string @name = Console.ReadLine();

            var people = new User();
            people.SetName(@name);

            Console.Write(people.SetName());
        }
    }
}
