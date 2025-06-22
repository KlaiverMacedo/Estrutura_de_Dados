using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataSort
{
    public class ProgramDataSort
    {

        static void Main(string[] args)
        {
            Executa();
        }
        public static void Executa()
        { 
            ListaDinamica<int> lista = new ListaDinamica<int>();
            while(true)
            {
                Console.Clear();
                Console.WriteLine("==== ORDENAR LISTA ====");
                Console.WriteLine("1 - Inserir nova lista");
                Console.WriteLine("2 - Exibir a lista atual");
                Console.WriteLine("3 - Ordenar lista");
                Console.WriteLine("4 - Gerar lista aleatória");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Escolha uma opção: ");
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        lista = new ListaDinamica<int>();
                        Console.WriteLine("\nQuantos elementos deseja inserir?");
                        if (int.TryParse(Console.ReadLine(), out int n) && n>0)
                        {
                            for (int i = 0; i < n; i++)
                            {
                                Console.Write($"Digite o {i +1}° valor: ");
                                if (int.TryParse(Console.ReadLine(), out int valor)) 
                                {
                                    lista.Inserir(valor);
                                }
                                else
                                {
                                    Console.WriteLine("Opção Inválida. " + "Pressione ENTER para continuar.");
                                    Console.ReadLine();
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("Número inválido. Pressione ENTER" +
                                " para continuar.");
                            Console.ReadLine();
                        }
                        break;
                    case "2":
                        Console.WriteLine("\nLista atual: ");

                        lista.Exibir();

                        Console.WriteLine("Número inválido. Pressione ENTER" +
                                " para continuar.");
                        Console.ReadLine();
                        break;
                    case "3":
                        if (lista.Vazia())
                        {
                            Console.WriteLine("Lista está vazia. " + "Inserir elementos primeiro");
                            Console.WriteLine("Pressione ENTER" +
                                " para continuar.");
                            Console.ReadLine();
                        }
                        Console.WriteLine("\nEscolha um algoritmo" + " de ordenação: ");

                        Console.WriteLine("1 - Bubble Sort");
                        Console.WriteLine("?2 - Selection Sort");
                        Console.WriteLine("?3 - Isertion Sort");
                        Console.WriteLine("?4 - Merge Sorte");
                        Console.WriteLine("?5 - Quick Sort");
                        Console.WriteLine("Opção: ");
                        string escolha = Console.ReadLine();

                        Console.WriteLine("\nLista antes de ordenação ");
                        lista.Exibir();

                        var copiaOrdenavel = lista.Clonar();
                        Stopwatch sw = Stopwatch.StartNew();

                        switch (escolha)
                        {
                            case "1": copiaOrdenavel.OrdenarBubble(); break;
                            //Implementar os demais...

                            case "2": copiaOrdenavel.OrdenarBubble(); break;
                            case "3": copiaOrdenavel.OrdenarBubble(); break;
                            case "4": copiaOrdenavel.OrdenarBubble(); break;
                            case "5": copiaOrdenavel.OrdenarBubble(); break;
                            default:
                                Console.WriteLine("Opção inválida.");
                                Console.ReadLine();

                                continue;
                        }
                        sw.Stop();
                        Console.WriteLine("\nLista após ordenação:");
                        copiaOrdenavel.Exibir();
                        Console.WriteLine($"\nTempo de execução: {sw.ElapsedMilliseconds} ms");
                        Console.WriteLine($"\nComparações: {copiaOrdenavel.Comparacoes}");
                        Console.WriteLine($"\nTrocas: {copiaOrdenavel.Trocas}");
                        Console.WriteLine($"\nPressione ENTER para continuar.");
                        Console.ReadLine();
                        break;

                    case "4":
                        Console.WriteLine("\nQuantos números deseja gerar? ");
                        if (int.TryParse(Console.ReadLine(), out int qtd) &&  qtd > 0)
                        {
                            Console.WriteLine("Valor mínimo: ");
                            int min = int.TryParse(Console.ReadLine(), out int minimo) ? minimo: 0;
                            Console.Write("Valor maximo: ");
                            int max = int.TryParse(Console.ReadLine(), out int maximo) ? maximo: 100;

                            lista = new ListaDinamica<int>();
                            lista.GerarAleatorio(qtd, min, max);
                            Console.WriteLine("Lista gerada com sucesso");
                        }
                        else
                        {
                            Console.WriteLine("Quantidade Inválida.");
                        }
                        Console.WriteLine("\nPressione ENTER para continuar.");
                        Console.ReadLine();

                        break;
                    case "0":
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.WriteLine("Opção Inválida. " + "Pressione ENTER para continuar.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
