using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_POO
{
    class Smartphone : Produto
    {
        public string Marca { get; set; }

        public Smartphone(string nome, double preco, int estoque, string marca) : base(nome, preco, estoque)
        {
            Marca = marca;
        }

        public override void ImprimirDetalhes()
        {
            Console.WriteLine($"Smartphone: {Nome} ({Marca}) - Preço: R$ {Preco} - Estoque: {Estoque}");
        }
    }
}
