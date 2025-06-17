using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticList
{
    public class ProgramStaticList
    {
        class StaticList
        {
            private int[] elementos;
            private int tamanho;
            private int capacidade;

            public StaticList(int capacidade)
            {
                this.capacidade = capacidade;
                elementos = new int[capacidade];
                tamanho = 0;
            }

            public void Inserir(int valor)
            {
                if (tamanho >= capacidade)
                {
                    Console.WriteLine("Lista cheia. Não é possível inserir.");
                    return;
                }
                elementos[tamanho] = valor;
                tamanho++;
                Console.WriteLine("Valor inserido com sucesso.");
            }

            public void Remover(int valor)
            {
                int index = -1;

                for (int i = 0; i < tamanho; i++)
                {
                    if (elementos[i] == valor)
                    {
                        index = i;
                        break;
                    }
                }

                if (index == -1)
                {
                    Console.WriteLine("Valor não encontrado na lista.");
                    return;
                }

                for (int i = index; i < tamanho - 1; i++)
                {
                    elementos[i] = elementos[i + 1];
                }

                tamanho--;
                Console.WriteLine("Valor removido com sucesso.");
            }

            public void Exibir()
            {
                if (tamanho == 0)
                {
                    Console.WriteLine("Lista vazia.");
                    return;
                }

                Console.WriteLine("Elementos na lista:");
                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine($" {elementos[i]}");
                }
            }

            public void Consultar(int valor)
            {
                for (int i = 0; i < tamanho; i++)
                {
                    if (elementos[i] == valor)
                    {
                        Console.WriteLine("Valor encontrado na lista.");
                        return;
                    }
                }
                Console.WriteLine("Valor não está na lista.");
            }
        }
        public static void Main(string[] args)
        {
        }
        public static void Executa()
        {
                StaticList lista = new StaticList(10);
                int opcao;

                do
                {
                    Console.WriteLine("\n==== MENU - Lista Estática ====");
                    Console.WriteLine("1. Inserir elemento");
                    Console.WriteLine("2. Remover elemento");
                    Console.WriteLine("3. Exibir lista");
                    Console.WriteLine("4. Consultar elemento");
                    Console.WriteLine("0. Sair");
                    Console.Write("Escolha uma opção: ");

                    opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Console.Write("Digite o valor para inserir: ");
                            int inserir = int.Parse(Console.ReadLine());
                            lista.Inserir(inserir);
                            break;

                        case 2:
                            Console.Write("Digite o valor para remover: ");
                            int remover = int.Parse(Console.ReadLine());
                            lista.Remover(remover);
                            break;

                        case 3:
                            lista.Exibir();
                            break;

                        case 4:
                            Console.Write("Digite o valor para consultar: ");
                            int consultar = int.Parse(Console.ReadLine());
                            lista.Consultar(consultar);
                            break;

                        case 0:
                            Console.WriteLine("Saindo do programa...");
                            break;

                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }

                } while (opcao != 0);
            }
        }
    }
