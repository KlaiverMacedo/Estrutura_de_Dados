using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battery_02
{
    public class ProgramBattery_02
    {
        static void Main(string[] args)
        {
        }
        public static void Execute()
        {
            Stack<char> pilha = new Stack<char>();
            char opcao;
            do
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Inserir um elemento na pilha: ");
                Console.WriteLine("2 - Remover um elemento da pilha: ");
                Console.WriteLine("3 - Exibir elementos da pilha: ");
                Console.WriteLine("4 - Mostrar o topo da pilha: ");
                Console.WriteLine("5 - Mostrar o tamanho da pila: ");
                Console.WriteLine("0 - Sair");
                opcao = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (opcao)
                {
                    case '1':
                        Console.WriteLine("Digite um caractere para impilhar: ");
                        char caractere = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        pilha.Push(caractere);
                        break;
                    case '2':
                        if (pilha.Count > 0)
                        {
                            Console.WriteLine("Elemento removido: " + pilha.Pop());
                        }
                        else
                        {
                            Console.WriteLine("Pilha vazia.");
                        }
                        break;
                    case '3':
                        if (pilha.Count == 0)
                        {
                            Console.WriteLine("Pilha vazia!");
                        }
                        else
                        {
                            Console.WriteLine("Pilha:");
                            foreach (var item in pilha)
                            {
                                Console.WriteLine(" " + item);
                            }
                        }
                        break;
                    case '4':
                        if (pilha.Count > 0)
                        {
                            Console.WriteLine("Topo da pilha: " + pilha.Peek());
                        }
                        else
                        {
                            Console.WriteLine("Pilha vazia: ");
                        }
                        break;
                    case '5':
                        Console.WriteLine("Tamanho da pilha: " + pilha.Count());
                        break;
                    case '0':
                        Console.WriteLine("Saindo... ");
                        break;


                    default:
                        Console.WriteLine("Opção invalida:");
                        break;
                }
                Console.WriteLine();

            } while (opcao != '0');
        }
    }
}
