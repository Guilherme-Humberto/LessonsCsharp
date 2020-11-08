using System;

namespace lesson8
{
    class Program
    {
        struct People
        {
            public string Name;
            public string Surname;
        }
        // Ao trabalhar com variáveis constantes, tem de se atribuir algum valor
        // Variáveis constantes são imutáveis;
        const string Name = "Guilherme Humberto";
        static void Main(string[] args)
        {
            Console.WriteLine(Name);

            People people = new People();
            people.Name = "Guilherme";
            people.Surname = "Humberto";

            Console.Write(people.Name + " " + people.Surname);
        }
    }
}
