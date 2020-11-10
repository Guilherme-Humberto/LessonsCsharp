using System;

namespace lesson9
{
    struct Peoples
    {
        public string Name;
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {   
            Peoples people = new Peoples();

            Console.Write("Digite seu nome: ");
            people.Name = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            people.Age = int.Parse(Console.ReadLine());

            if(people.Age >= 18) {
                Console.Write($"Você {people.Name} é maior de idade.");
            }
            else if(people.Age >= 13 && people.Age <= 17) {
                Console.Write($"Você {people.Name} é um adolescente.");
            }
            else {
                Console.Write($"Você {people.Name} é menor de idade.");
            }
            
        }
    }
}
