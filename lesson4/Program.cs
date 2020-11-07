using System;
using lesson4.Models;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            int @carteira = 20;

            Console.WriteLine("Digite o nome do produto que deseja comprar");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o valor do produto");
            int valor = int.Parse(Console.ReadLine());

            // Criando uma instância(objeto) da classe produto
            var produto = new Produto();
            produto.Produtos(nome, valor);

            Console.WriteLine(produto.compareValores(@carteira));
        }
    }
}
