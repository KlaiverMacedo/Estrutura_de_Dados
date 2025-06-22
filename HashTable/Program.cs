using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using HashTable;

namespace HashTable
{
    public class ProgramHash
    {
        public static void Main(string[] args)
        {
        }
        public static void Executa()
        {
            HashTable<int> table = new HashTable<int>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== TABELA HASH ====");
                Console.WriteLine("1. Inserir valor");
                Console.WriteLine("2. Buscar valor");
                Console.WriteLine("3. Remover valor");
                Console.WriteLine("4. Exibir tabela");
                Console.WriteLine("0. Sair");
                Console.WriteLine("Escolha uma opção: ");

                string option = Console.ReadLine();
                Console.Clear();

                switch (option)
                {
                    case "1":
                        Console.Write(" ");
                        if (int.TryParse(Console.ReadLine(), out int valueInsert))
                        {
                            table.Insert(valueInsert);
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido");
                        }
                            break;
                    case "2":
                        Console.Write("Valor inválido");
                        if (int.TryParse(Console.ReadLine(), out int valueSearch))
                        {
                            if (table.Search(valueSearch))
                            {
                                Console.WriteLine($" {valueSearch} encontrado");
                            }
                            else
                            {
                                Console.WriteLine($" {valueSearch} não está na tabela.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido.");
                        }
                        break;
                    case "3":
                        Console.Write("Valor a remover ");
                        if (int.TryParse(Console.ReadLine(), out int valorRemove))
                        {
                            if (table.Remove(valorRemove))
                            {
                                Console.WriteLine($" {valorRemove} removido");
                            }
                            else
                            {
                                Console.WriteLine($" {valorRemove} não encontrado");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido");
                        }
                            break;
                    case "4":
                        Console.WriteLine("Tabela Hash");
                        table.Display();
                        break;
                    case "0":
                        Console.Write("Saindo... ");
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine("Pressione a tecla ENTER para avançar");
                Console.ReadLine();


            }
        }
    }

}

