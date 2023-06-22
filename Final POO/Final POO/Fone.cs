using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_POO
{
    class Fone : Produto
    {
        public string FabricanteFO { get; set; }

        public Fone(string nome, double preco, int estoque, string fabricanteF) : base(nome, preco, estoque)
        {
            FabricanteFO = fabricanteF;
        }

        public override void ImprimirDetalhes()
        {
            Console.WriteLine($"Fone: {Nome} ({FabricanteFO}) - Preço: R$ {Preco} - Estoque: {Estoque}");
        }
    }
}
