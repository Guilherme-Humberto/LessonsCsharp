using System;

namespace lesson4.Models
{
    public class Produto
    {
        // Propriedades
        public string Nome { get; set; }
        public int Preco { get; set; }

        // O void indica que não irá haver retorno depois da execução da função
        public void Produtos(string nome, int valor)
        {
            this.Nome = nome;
            this.Preco = valor;
        }

        public string compareValores(int valor) {
            if(valor < this.Preco) {
                return "Você não pode pagar por esta " + this.Nome;
            }
            else {
                return "Você deve pagar R$:" + (valor - this.Preco);
            }
        }
    }
}