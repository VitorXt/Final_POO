using Final_POO;

class Program
{
    static void Main(string[] args)
    {
        Loja loja = new Loja();

        int opcao = -1;
        while (opcao != 0)
        {
            Console.WriteLine("=== MENU ===");
            Console.WriteLine("1 - Adicionar Produto");
            Console.WriteLine("2 - Listar Produtos");
            Console.WriteLine("3 - Buscar Produto por Nome");
            Console.WriteLine("4 - Buscar Produtos por Marca");
            Console.WriteLine("5 - Realizar Compra do Produto");
            Console.WriteLine("6 - Realizar Venda do Produto");
            Console.WriteLine("7 - Atualizar Preço");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    

                    Console.WriteLine("Selecione o tipo de produto:");
                    Console.WriteLine("1 - Smartphone");
                    Console.WriteLine("2 - Notebook");
                    Console.WriteLine("3 - Televisão");
                    Console.WriteLine("4 - Fone");
                    Console.WriteLine("5 - Impressora");
                    Console.Write("Opção: ");
                    int tipo = int.Parse(Console.ReadLine());

                    Console.Write("Digite o nome do produto: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite o preço do produto: ");
                    double preco = double.Parse(Console.ReadLine());
                    Console.Write("Digite a quantidade em estoque do produto: ");
                    int estoque = int.Parse(Console.ReadLine());

                    Produto produto = null;
                    switch (tipo)
                    {
                        case 1:
                            Console.Write("Digite a marca do smartphone: ");
                            string marca = Console.ReadLine();
                            produto = new Smartphone(nome, preco, estoque, marca);
                            break;
                        case 2:
                            Console.Write("Digite o fabricante do Notebook: ");
                            string fabricanteN = Console.ReadLine();
                            produto = new Notebook(nome, preco, estoque, fabricanteN);
                            break;
                        case 3:
                            Console.Write("Digite o fabricante da Televisão: ");
                            string fabricanteT = Console.ReadLine();
                            produto = new Televisao(nome, preco, estoque, fabricanteT);
                            break;
                        case 4:
                            Console.Write("Digite o fabricante do Fone: ");
                            string fabricanteF = Console.ReadLine();
                            produto = new Fone(nome, preco, estoque, fabricanteF);
                            break;
                        case 5:
                            Console.Write("Digite o fabricante da impressora: ");
                            string impressoraI = Console.ReadLine();
                            produto = new Impressora(nome, preco, estoque, impressoraI);
                            break;
                    }

                    if (produto != null)
                    {
                        loja.AdicionarProduto(produto);
                    }
                    break;
                case 2:
                    loja.ListarProdutos();
                    break;
                case 3:
                    Console.Write("Digite o nome do produto: ");
                    string nomeBusca = Console.ReadLine();
                    Produto produtoEncontrado = loja.BuscarProdutoPorNome(nomeBusca);
                    if (produtoEncontrado != null)
                    {
                        produtoEncontrado.ImprimirDetalhes();
                    }
                    else
                    {
                        Console.WriteLine("Produto não encontrado.");
                    }
                    break;
                case 4:
                    Console.WriteLine("Selecione o tipo de produto:");
                    Console.WriteLine("1 - Smartphone");
                    Console.WriteLine("2 - Notebook");
                    Console.WriteLine("3 - Televisão");
                    Console.WriteLine("4 - Fone");
                    Console.WriteLine("5 - Impressora");
                    Console.Write("Opção: ");

                    int busca = int.Parse(Console.ReadLine());
                    switch (busca)
                    {
                        case 1:
                            Console.Write("Digite a marca dos smartphones: ");
                            string marcaBusca = Console.ReadLine();
                            List<Produto> SmartEncontrados = loja.BuscarProdutosPorMarca(marcaBusca);
                            if (SmartEncontrados.Count > 0)
                            {
                                Console.WriteLine($"Produtos da marca {marcaBusca}:");
                                foreach (Produto prod in SmartEncontrados)
                                {
                                    prod.ImprimirDetalhes();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nenhum produto encontrado.");
                            }
                            break;
                        case 2:
                            Console.Write("Digite o fabricante do Notebook: ");
                            string fabricanteNBusca = Console.ReadLine();
                            List<Produto> NotesEncontrados = loja.BuscarProdutosPorFabricanteN(fabricanteNBusca);
                            if (NotesEncontrados.Count > 0)
                            {
                                Console.WriteLine($"Notebook do fabricante: {fabricanteNBusca}:");
                                foreach (Produto prod in NotesEncontrados)
                                {
                                    prod.ImprimirDetalhes();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nenhum produto encontrado.");
                            }
                            break;
                        case 3:
                            Console.Write("Digite o fabricante da Televisão: ");
                            string fabricanteTBusca = Console.ReadLine();
                            List<Produto> TvEncontrados = loja.BuscarProdutosPorFabricanteT(fabricanteTBusca);
                            if (TvEncontrados.Count > 0)
                            {
                                Console.WriteLine($"Televisão do fabricante: {fabricanteTBusca}:");
                                foreach (Produto prod in TvEncontrados)
                                {
                                    prod.ImprimirDetalhes();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nenhum produto encontrado.");
                            }
                            break;
                        case 4:
                            Console.Write("Digite o fabricante do Fone: ");
                            string fabricanteFBusca = Console.ReadLine();
                            List<Produto> FoEncontrados = loja.BuscarProdutosPorFabricanteF(fabricanteFBusca);
                            if (FoEncontrados.Count > 0)
                            {
                                Console.WriteLine($"Fones do fabricante: {fabricanteFBusca}:");
                                foreach (Produto prod in FoEncontrados)
                                {
                                    prod.ImprimirDetalhes();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nenhum produto encontrado.");
                            }
                            break;
                        case 5:
                            Console.Write("Digite o fabricante da impressora: ");
                            string fabricanteIBusca = Console.ReadLine();
                            List<Produto> ImEncontrados = loja.BuscarProdutosPorFabricanteI(fabricanteIBusca);
                            if (ImEncontrados.Count > 0)
                            {
                                Console.WriteLine($"Impressoras do fabricante: {fabricanteIBusca}:");
                                foreach (Produto prod in ImEncontrados)
                                {
                                    prod.ImprimirDetalhes();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nenhum produto encontrado.");
                            }
                            break;
                    }
                    break;

                case 5:
                    Console.Write("Digite o nome do produto: ");
                    string nomeCompra = Console.ReadLine();
                    Console.Write("Digite a quantidade a ser adicionada ao estoque: ");
                    int quantidadeCompra = int.Parse(Console.ReadLine());
                    loja.AtualizarEstoqueCompra(nomeCompra, quantidadeCompra);
                    break;
                case 6:
                    Console.Write("Digite o nome do produto: ");
                    string nomeVenda = Console.ReadLine();
                    Console.Write("Digite a quantidade a ser vendida: ");
                    int quantidadeVenda = int.Parse(Console.ReadLine());
                    loja.AtualizarEstoqueVenda(nomeVenda, quantidadeVenda);
                    break;
                case 7:
                    Console.Write("Digite o nome do produto: ");
                    string nomeAlteracaoPreco = Console.ReadLine();
                    Console.Write("Digite o novo preço do produto: ");
                    double novoPreco = double.Parse(Console.ReadLine());
                    loja.AtualizarPrecoProduto(nomeAlteracaoPreco, novoPreco);
                    break;
                case 0:
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine();
        }
    }
}