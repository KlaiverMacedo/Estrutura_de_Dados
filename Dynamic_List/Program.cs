using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> list = new List<char>();
            int option;
            char value;

            do
            {
                Console.WriteLine("\nLISTA DINAMICA - List<T>");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Inserir elemento");
                Console.WriteLine("2. Remover elemento");
                Console.WriteLine("3. Exibir Lista");
                Console.WriteLine("4. Verificar se contem na lista");
                Console.WriteLine("5. Tamanho da lista");
                Console.WriteLine("6. Limpar");
                Console.Write("Escolha uma posição: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    case 1:
                        Console.WriteLine("Digite um valor: ");
                        value = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        list.Add(value);
                        break;
                    case 2:
                        Console.WriteLine("Digite o valor a ser removido: ");
                        value = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        if (list.Remove(value))
                            Console.WriteLine("Valor removido com sucesso.");
                        else
                            Console.WriteLine("Valor não encontrado");
                        break;
                    case 3:
                        if (list.Count == 0)
                        {
                            Console.WriteLine("Lista vazia.");
                        }
                        else
                        {
                            Console.WriteLine("Lista: ");
                            foreach (char c in list)
                            {
                                Console.WriteLine(c + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        Console.Write("Digite o valor a ser verificado: ");
                        value = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        Console.WriteLine(list.Contains(value)//Teste lógico
                                                               //Verdadeiro
                            ? "Valor encontrado na lista"
                            //Falso
                            : "Valor não encontrado"
                            );
                        break;
                    case 5:
                        Console.WriteLine("Tamanho da Lista: " + list.Count);
                        break;
                    case 6:
                        list.Clear();
                        Console.WriteLine("Lista limpa.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (option != 0);
        }
    }
}
