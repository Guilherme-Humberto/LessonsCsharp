using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do usuário");
            string nome = Console.ReadLine();

            User usuario = new User();
            string nomedigitado = usuario.Users(nome);
            
            Console.WriteLine("O nome digitado foi " + nomedigitado);
        }
    }
}
