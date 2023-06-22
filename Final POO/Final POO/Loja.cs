using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_POO
{
    class Loja
    {
        private List<Produto> produtos;
        public Loja()
        {
            produtos = new List<Produto>();
        }
        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
            Console.WriteLine("Produto adicionado com sucesso!");
        }
        public void ListarProdutos()
        {
            Console.WriteLine("=== Lista de Produtos ===");
            foreach (Produto produto in produtos)
            {
                produto.ImprimirDetalhes();
                Console.WriteLine("==========================");
            }
        }
        public Produto BuscarProdutoPorNome(string nome)
        {
            return produtos.Find(p => p.Nome.ToLower().Contains(nome.ToLower()));
        }
        public List<Produto> BuscarProdutosPorMarca(string marca)
        {
            return produtos.Where(p => p is Smartphone && ((Smartphone)p).Marca.ToLower() == marca.ToLower()).ToList();
        }
        public List<Produto> BuscarProdutosPorFabricanteN(string FabricanteN)
        {
            return produtos.Where(p => p is Notebook && ((Notebook)p).FabricanteNo.ToLower() == FabricanteN.ToLower()).ToList();
        }
        public List<Produto> BuscarProdutosPorFabricanteT(string FabricanteT)
        {
            return produtos.Where(p => p is Televisao && ((Televisao)p).FabricanteTV.ToLower() == FabricanteT.ToLower()).ToList();
        }
        public List<Produto> BuscarProdutosPorFabricanteF(string FabricanteF)
        {
            return produtos.Where(p => p is Fone && ((Fone)p).FabricanteFO.ToLower() == FabricanteF.ToLower()).ToList();
        }
        public List<Produto> BuscarProdutosPorFabricanteI(string FabricanteI)
        {
            return produtos.Where(p => p is Impressora && ((Impressora)p).ImpressoraIM.ToLower() == FabricanteI.ToLower()).ToList();
        }
        public void AtualizarEstoqueCompra(string nome, int quantidade)
        {
            Produto produto = BuscarProdutoPorNome(nome);
            if (produto != null)
            {
                produto.Estoque += quantidade;
                Console.WriteLine($"Estoque do produto {produto.Nome} atualizado para: {produto.Estoque}");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }
        public void AtualizarEstoqueVenda(string nome, int quantidade)
        {
            Produto produto = BuscarProdutoPorNome(nome);
            if (produto != null)
            {
                if (produto.Estoque >= quantidade)
                {
                    produto.Estoque -= quantidade;
                    Console.WriteLine($"Estoque do produto {produto.Nome} atualizado para: {produto.Estoque}");
                }
                else
                {
                    Console.WriteLine("Quantidade em estoque insuficiente para realizar a venda.");
                }
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }
        public void AtualizarPrecoProduto(string nome, double novoPreco)
        {
            Produto produto = BuscarProdutoPorNome(nome);
            if (produto != null)
            {
                produto.AtualizarPreco(novoPreco);
                Console.WriteLine("Preço do produto atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }
    }
}
