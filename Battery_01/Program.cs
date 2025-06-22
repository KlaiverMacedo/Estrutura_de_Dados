using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battery_01
{
    public class ProgramBattery_01
    {
        static void Main(string[] args)
        {
        }
        public static void Execute()
        {
            Stack<string> pilha = new Stack<string>();
            char valor;
            do
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1- Empilhar um elemento.");
                Console.WriteLine("2 - Desempilhar um elemento.");
                Console.WriteLine("3 - Exibir o topo da pilha.");
                Console.WriteLine("4 - Exibir o tamanho da pilha.");
                Console.WriteLine("5 - Exibir todos os elementos da pilha.");
                Console.WriteLine("0 - Sair");
                valor = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (valor)
                {
                    case '1':
                        Console.WriteLine("Digite o Elemento que deseja empilhar?");
                        string caracter = Console.ReadLine();

                        Console.WriteLine();
                        pilha.Push(caracter);
                        break;
                    case '2':
                        if (pilha.Count > 0)
                        {
                            Console.WriteLine("Elemento desempilhado." + pilha.Pop());
                        }
                        else
                        {
                            Console.WriteLine("Nenhum elemento vazio!");
                        }
                        break;
                    case '3':
                        if (pilha.Count > 0)
                        {
                            Console.WriteLine("Elemento do topo." + pilha.Peek());
                        }
                        else
                        {
                            Console.WriteLine("Nenhum elemento vazio!");
                        }

                        break;
                    case '4':
                        Console.WriteLine("Tamanho da Pilha." + pilha.Count());
                        break;
                    case '5':
                        if (pilha.Count == 0)
                        {
                            Console.WriteLine("Nenhum elemento vazio!");
                        }
                        else
                        {
                            Console.WriteLine("Todos os elementos.");
                            foreach (var item in pilha)
                            {
                                Console.WriteLine(" " + item);
                            }
                        }

                        break;
                    case '0':
                        Console.WriteLine("Saindo!!!!!!");
                        break;


                    default:
                        Console.WriteLine("Opção invalida:");
                        break;
                }
                Console.WriteLine();

            } while (valor != '0');
        }
    }
}
