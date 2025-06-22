using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battery_03
{
    class Pilha
    {
        private char[] elementos;
        private int topo;
        private int tamanho;

        public Pilha(int capacidade)
        {
            elementos = new char[capacidade];
            topo = -1;
            tamanho = 0;
        }
        //Método para adicionar um elemento na pilha
        public void Push(char caractere)
        {
            if (tamanho == elementos.Length)
            {
                Console.WriteLine("Erro: pilha cheia!");
                return;
            }
            elementos[++topo] = caractere;
            tamanho++;

        }
        //Método para exibir oque tem na pilha
        public void Exibir()
        {
            if (Empty())
            {
                Console.WriteLine("Pilha vazia!");
                return;
            }
            Console.WriteLine("Pilha: ");
            for (int i = topo; i >= 0; i--)
            {
                Console.WriteLine(" " + elementos[i]);
            }
            Console.WriteLine();
        }
        public bool Empty()
        {
            return tamanho == 0;
        }
        //metodo para retornoar o tamanha da pilha
        public int Size()
        {
            return tamanho;
        }

        //Metodo para obter o elemento do topo da pilha
        public char Top()
        {
            if (Empty())
            {
                Console.WriteLine("Pilha vazia!");
                return '\0';
            }
            return elementos[topo];
        }
        //Metodo para remover o elemento do topo da pilha
        public char Pop()
        {
            //validação futuras
            if (Empty())
            {
                Console.WriteLine("Pilha vazia!");
                return '\0';
            }
            char c = elementos[topo--];
            tamanho--;
            return c;
        }
    }
    public class ProgramBattery_03
    {
        static void Main(string[] args)
        {
        }
        public static void Execute()
        {
            Pilha pilha = new Pilha(10);
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
                opcao = Console.ReadKey().KeyChar;//ler somente 1 caractere
                Console.WriteLine();

                switch (opcao)
                {
                    case '1':
                        Console.WriteLine("Digite um caractere para empilhar: ");
                        char caracter = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        pilha.Push(caracter);
                        break;
                    case '2':
                        Console.WriteLine("Elemento removido: " + pilha.Pop());
                        break;
                    case '3':
                        pilha.Exibir();
                        break;
                    case '4':
                        Console.WriteLine("Topo da pilha: " + pilha.Top());
                        break;
                    case '5':
                        Console.WriteLine("Tamanho da pilha: " + pilha.Size());
                        break;
                    case '0':
                        Console.WriteLine("Saindo... ");
                        break;

                    default:
                        Console.WriteLine("Opção invalida:");
                        break;
                }
                Console.WriteLine();
            }
            while (opcao != 0);
        }
    }
}
