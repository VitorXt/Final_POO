using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_POO
{
    class Televisao : Produto
    {
        public string FabricanteTV { get; set; }

        public Televisao(string nome, double preco, int estoque, string fabricanteT) : base(nome, preco, estoque)
        {
            FabricanteTV = fabricanteT;
        }

        public override void ImprimirDetalhes()
        {
            Console.WriteLine($"Televisão: {Nome} ({FabricanteTV}) - Preço: R$ {Preco} - Estoque: {Estoque}");
        }
    }
}
