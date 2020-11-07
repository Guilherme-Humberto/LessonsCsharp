using System;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite alguma coisa");
            string coisa = Console.ReadLine();

            Console.WriteLine("Maiúsculo: " + coisa.ToUpper());
            Console.WriteLine("Minúsculo: " + coisa.ToLower());
            Console.WriteLine("Tamanho: " + coisa.Length + " letras");
            Console.WriteLine("Parte do valor: " + coisa.Substring(0, 3));
            Console.WriteLine("Contém: " + coisa.Contains("Gui"));
        }
    }
}
