using System;

namespace lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            var pessoa = new Usuario();
            pessoa.setName(nome);

            Console.Write(pessoa.setName());
        }
    }
}
