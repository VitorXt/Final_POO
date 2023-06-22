using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_POO
{
    class Notebook : Produto
    {
        public string FabricanteNo { get; set; }

        public Notebook(string nome, double preco, int estoque, string fabricanteN) : base(nome, preco, estoque)
        {
            FabricanteNo = fabricanteN;
        }

        public override void ImprimirDetalhes()
        {
            Console.WriteLine($"Notebook: {Nome} ({FabricanteNo}) - Preço: R$ {Preco} - Estoque: {Estoque}");
        }
    }
}
