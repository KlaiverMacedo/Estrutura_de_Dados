using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSearchStatic
{
    public class ProgramDataSearchStatic
    {
        // Lista estática de produtos
        static List<Produto> produtos = new List<Produto>
        {
            new Produto(1, "Notebook", 4200.99m),
            new Produto(2, "Smartphone", 2599.99m),
            new Produto(3, "Tablet", 1500.00m)
        };

        static void Main(string[] args)
        {
        }
            public static void Executa()
        { 
            Console.WriteLine("=== GERENCIADOR DE PRODUTOS ===");

            while (true)
            {
                Console.WriteLine("\nMENU PRINCIPAL:");
                Console.WriteLine("1. Inserir novo produto");
                Console.WriteLine("2. Remover produto");
                Console.WriteLine("3. Exibir todos os produtos");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");

                int opcao;
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida! Digite um número de 1 a 4.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        InserirProduto();
                        break;
                    case 2:
                        RemoverProduto();
                        break;
                    case 3:
                        ExibirTodosProdutos();
                        break;
                    case 4:
                        Console.WriteLine("Saindo do sistema...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida! Digite um número de 1 a 4.");
                        break;
                }
            }
        }

        static void InserirProduto()
        {
            Console.WriteLine("\n--- INSERIR NOVO PRODUTO ---");

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            decimal preco = decimal.Parse(Console.ReadLine());

            produtos.Add(new Produto(id, nome, preco));
            Console.WriteLine("Produto adicionado com sucesso!");
        }

        static void RemoverProduto()
        {
            Console.WriteLine("\n--- REMOVER PRODUTO ---");
            Console.Write("Digite o ID do produto a ser removido: ");
            int id = int.Parse(Console.ReadLine());

            Produto produto = produtos.Find(p => p.Id == id);
            if (produto != null)
            {
                produtos.Remove(produto);
                Console.WriteLine("Produto removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado!");
            }
        }

        static void ExibirTodosProdutos()
        {
            Console.WriteLine("\n--- LISTA DE PRODUTOS ---");
            Console.WriteLine("ID\tNome\t\tPreço");
            Console.WriteLine("------------------------------");

            if (produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
                return;
            }

            foreach (var produto in produtos)
            {
                Console.WriteLine($"{produto.Id}\t{produto.Nome}\t{produto.Preco:C}");
            }
        }
    }

    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto(int id, string nome, decimal preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }
    }
}