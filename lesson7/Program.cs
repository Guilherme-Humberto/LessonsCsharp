using System;

namespace lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um nome: ");
            string @nome = Console.ReadLine();

            Console.Write("Digite o sobrenome: ");
            string @surname = Console.ReadLine();
            
            // Não é possível criar instâncias de classes estáticas
            User.Name = @nome;
            User.Surname = @surname;

            Console.Write(User.ShowUserName());
        }
    }
}
