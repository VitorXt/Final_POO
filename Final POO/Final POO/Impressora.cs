using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_POO
{
    class Impressora : Produto
    {
        public string ImpressoraIM { get; set; }

        public Impressora(string nome, double preco, int estoque, string impressoraI) : base(nome, preco, estoque)
        {
            ImpressoraIM = impressoraI;
        }

        public override void ImprimirDetalhes()
        {
            Console.WriteLine($"Impressora: {Nome} ({ImpressoraIM}) - Preço: R$ {Preco} - Estoque: {Estoque}");
        }
    }
}
