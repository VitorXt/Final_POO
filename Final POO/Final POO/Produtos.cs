using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_POO
{
    abstract class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

        public Produto(string nome, double preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        protected Produto()
        {
        }

        public abstract void ImprimirDetalhes();

        public void AtualizarPreco(double novoPreco)
        {
            this.Preco = novoPreco;
        }
    }
}
