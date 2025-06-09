using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointerList;

namespace PointerList
{
    public class No
    {
        public char Valor;
        public No Proximo;

        public No(char valor)
        {
            Valor = valor;
            Proximo = null;
        }
    }

    public class ListaDinamica
    {
        private No inicio;

        public ListaDinamica()
        {
            inicio = null;
        }

        public void Inserir(char valor)
        {
            No novo = new No(valor);
            if (inicio == null)
            {
                inicio = novo;
            }
            else
            {
                No atual = inicio;
                while (atual.Proximo != null)
                {
                    atual = atual.Proximo;
                }
                atual.Proximo = novo;
            }
        }

        public void InserirNaPosicao(int pos, char valor)
        {
            No novo = new No(valor);

            if (pos == 0)
            {
                novo.Proximo = inicio;
                inicio = novo;
                return;
            }

            No atual = inicio;
            for (int i = 0; i < pos - 1; i++)
            {
                if (atual == null)
                {
                    Console.WriteLine("Posição Inválida!");
                    return;
                }
                atual = atual.Proximo;
            }

            if (atual == null)
            {
                Console.WriteLine("Posição Inválida!");
                return;
            }

            novo.Proximo = atual.Proximo;
            atual.Proximo = novo;
        }

        public void Remover(int pos)
        {
            if (inicio == null)
            {
                Console.WriteLine("Lista vazia.");
                return;
            }

            if (pos == 0)
            {
                inicio = inicio.Proximo;
                return;
            }

            No atual = inicio;
            for (int i = 0; i < pos - 1; i++)
            {
                if (atual.Proximo == null)
                {
                    Console.WriteLine("Posição Inválida!");
                    return;
                }
                atual = atual.Proximo;
            }

            if (atual.Proximo == null)
            {
                Console.WriteLine("Posição Inválida!");
                return;
            }

            atual.Proximo = atual.Proximo.Proximo;
        }

        public void Exibir()
        {
            if (inicio == null)
            {
                Console.WriteLine("Lista vazia.");
                return;
            }

            Console.WriteLine("Lista: ");
            No atual = inicio;
            while (atual != null)
            {
                Console.Write(atual.Valor + " ");
                atual = atual.Proximo;
            }
            Console.WriteLine();
        }

        public char ElementoNaPosicao(int pos)
        {
            No atual = inicio;
            int cont = 0;

            while (atual != null)
            {
                if (cont == pos)
                    return atual.Valor;

                atual = atual.Proximo;
                cont++;
            }

            Console.WriteLine("Posição inválida.");
            return '\0';
        }

        public int Size()
        {
            int cont = 0;
            No atual = inicio;
            while (atual != null)
            {
                atual = atual.Proximo;
                cont++;
            }
            return cont;
        }

        public bool Empty()
        {
            return inicio == null;
        }
    }

    public static class PointerListExecutavel
    {
        static void Main(string[] args)
        { }
        public static void Executa()
        {
            ListaDinamica lista = new ListaDinamica();
            int opcao;
            char valor;
            int pos;

            do
            {
                Console.WriteLine("\nLISTA DINÂMICA (Encadeada)");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Inserir no final");
                Console.WriteLine("2. Inserir por posição específica");
                Console.WriteLine("3. Remover por posição");
                Console.WriteLine("4. Tamanho da Lista");
                Console.WriteLine("5. Exibir a Lista");
                Console.WriteLine("6. Exibir elemento na posição");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Entrada inválida!");
                    continue;
                }

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    case 1:
                        Console.Write("Digite um valor: ");
                        valor = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        lista.Inserir(valor);
                        break;
                    case 2:
                        Console.Write("Digite a posição: ");
                        pos = int.Parse(Console.ReadLine());
                        Console.Write("Digite o valor: ");
                        valor = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        lista.InserirNaPosicao(pos, valor);
                        break;
                    case 3:
                        Console.Write("Digite a posição para remover: ");
                        pos = int.Parse(Console.ReadLine());
                        lista.Remover(pos);
                        break;
                    case 4:
                        Console.WriteLine("Tamanho atual: " + lista.Size());
                        break;
                    case 5:
                        lista.Exibir();
                        break;
                    case 6:
                        Console.Write("Digite a posição: ");
                        pos = int.Parse(Console.ReadLine());
                        valor = lista.ElementoNaPosicao(pos);
                        Console.WriteLine("Elemento: " + valor);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 0);
        }
    }
}
