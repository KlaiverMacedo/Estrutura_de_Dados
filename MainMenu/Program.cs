using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dynamic_List;
using PointerList;
using StaticList;


namespace MainMenu
{
    class ProgramMainMenu
    {
        static void Main(string[] args)
        {
            MostrarMenuPrincipal();
        }


        static void MostrarMenuPrincipal()
        {
            Console.WriteLine("=== MENU ===");
            Console.WriteLine("1 - Executar projeto de Listas: ");
            Console.WriteLine("2 - Executar projeto de Vetores: ");
            Console.WriteLine("3 - Executar projeto de Matrizes: ");
            Console.WriteLine("4 - Executar projeto de Bateria: ");
            Console.WriteLine("5 - Executar projeto de Pesquisa de dados: ");
            Console.WriteLine("6 - Executar projeto de Tabela Hash: ");
            Console.WriteLine("7 - Executar projeto de Fila: ");
            Console.WriteLine("8 - Executar projeto de Algoritimos: ");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    MostrarMenuLista();
                    break;
                case "2":
                    MostrarMenuVetores();
                    break;
                case "3":
                    MostrarMenuMatrizes();
                    break;
                case "4":
                    MostrarMenuBateria();
                    break;
                case "5":
                    MostrarMenuPesquisaDeDados();
                    break;
                case "6":
                    MostrarMenuTabelaHash();
                    break;
                case "7":
                    MostrarMenuFila();
                    break;
                case "8":
                    MostrarMenuAlgoritmos();
                    break;
                case "0":
                    Console.WriteLine("Encerrando...");
                    break;
                default:

                    Console.WriteLine("Opção Inválida. " + "Pressione ENTER para continuar.");
                    Console.ReadLine();
                    MostrarMenuPrincipal();
                    break;
            }
        }
        static void MostrarMenuLista()
        {
            Console.WriteLine("=== LISTAS ===");
            Console.WriteLine("1 - Lista Dinamica.");
            Console.WriteLine("2 - Lista de Dinamica Encadeada");
            Console.WriteLine("3 - Lista Estatica");
            Console.WriteLine("0 - Voltar o Menu principal");
            var lista = Console.ReadLine();

            switch (lista)
            {
                case "1":
                    Lists.Dynamic();
                    break;

                case "2":
                    Lists.PointerList();
                    break;
                case "3":
                    Lists.StaticList();
                    break;
                case "0":
                    Console.WriteLine("Voltando ao menu principal..." + "Pressione ENTER para continuar.");
                    Console.ReadLine();
                    MostrarMenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção Inválida. " + "Pressione ENTER para continuar.");
                    Console.ReadLine();
                    MostrarMenuLista();
                    break;
            }
        }

        static void MostrarMenuVetores()
        {
            Console.WriteLine("=== VETORES ===");
            Console.WriteLine("1 - Vetor 01");
            Console.WriteLine("2 - Vetor 02");
            Console.WriteLine("3 - vetor 03");
            Console.WriteLine("4 - vetor 04");
            Console.WriteLine("5 - vetor 05");
            Console.WriteLine("6 - vetor 06");
            Console.WriteLine("7 - vetor 07");
            Console.WriteLine("8 - vetor 08");
            Console.WriteLine("9 - vetor 09");
            Console.WriteLine("0 - Voltar o Menu principal");
            var lista = Console.ReadLine();

            switch (lista)
            {
                case "1":
                    Vectors.Vectors_01();
                    break;
                case "2":
                    Vectors.Vectors_02();
                    break;
                case "3":
                    Vectors.Vectors_03();
                    break;
                case "4":
                    Vectors.Vectors_04();
                    break;
                case "5":
                    Vectors.Vectors_05();
                    break;
                case "6":
                    Vectors.Vectors_06();
                    break;
                case "7":
                    Vectors.Vectors_07();
                    break;
                case "8":
                    Vectors.Vectors_08();
                    break;
                case "9":
                    Vectors.Vectors_09();
                    break;
                case "0":
                    Console.WriteLine("Voltando ao menu principal..." + "Pressione ENTER para continuar.");
                    Console.ReadLine();
                    MostrarMenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção Inválida. " + "Pressione ENTER para continuar.");
                    Console.ReadLine();
                    MostrarMenuVetores();
                    break;
            }
        }
        static void MostrarMenuMatrizes()
        {
            Console.WriteLine("=== VETORES ===");
            Console.WriteLine("1 - Matriz 01");
            Console.WriteLine("2 - Matriz 02");
            Console.WriteLine("3 - Matriz 03");
            Console.WriteLine("4 - Matriz 04");
            Console.WriteLine("5 - Matriz 05");
            Console.WriteLine("6 - Matriz 06");
            Console.WriteLine("7 - Matriz 07");
             Console.WriteLine("0 - Voltar o Menu principal");
            var lista = Console.ReadLine();

            switch (lista)
            {
                case "1":
                    Matrices.Matrices_01();
                    break;
                case "2":
                    Matrices.Matrices_02();
                    break;
                case "3":
                    Matrices.Matrices_03();
                    break;
                case "4":
                    Matrices.Matrices_04();
                    break;
                case "5":
                    Matrices.Matrices_05();
                    break;
                case "6":
                    Matrices.Matrices_06();
                    break;
                case "7":
                    Matrices.Matrices_07();
                    break;
                case "0":
                    Console.WriteLine("Voltando ao menu principal..." + "Pressione ENTER para continuar.");
                    Console.ReadLine();
                    MostrarMenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção Inválida. " + "Pressione ENTER para continuar.");
                    Console.ReadLine();
                    MostrarMenuMatrizes();
                    break;
            }
        }

        static void MostrarMenuBateria()
        {
            Console.WriteLine("=== BATERIAS ===");
            Console.WriteLine("1 - Bateria 01.");
            Console.WriteLine("2 - Bateria 02");
            Console.WriteLine("3 - Bateria 03");
            Console.WriteLine("0 - Voltar o Menu principal");
            var lista = Console.ReadLine();

            switch (lista)
            {
                case "1":
                    Battery.Battery_01();
                    break;

                case "2":
                    Battery.Battery_02();
                    break;
                case "3":
                    Battery.Battery_03();
                    break;
                case "0":
                    Console.WriteLine("Voltando ao menu principal..." + "Pressione ENTER para continuar.");
                    Console.ReadLine();
                    MostrarMenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção Inválida. " + "Pressione ENTER para continuar.");
                    Console.ReadLine();
                    MostrarMenuBateria();
                    break;
            }
        }
        static void MostrarMenuPesquisaDeDados()
        {
            Console.WriteLine("=== PESQUISA DE DADOS ===");
            Console.WriteLine("1 - Pesquisa de dados.");
            Console.WriteLine("0 - Voltar o Menu principal");
            var lista = Console.ReadLine();

            switch (lista)
            {
                case "1":
                    DataSearch.PesquisadeDados();
                    break;
                case "0":
                    Console.WriteLine("Voltando ao menu principal..." + "Pressione ENTER para continuar.");
                    Console.ReadLine();
                    MostrarMenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção Inválida. " + "Pressione ENTER para continuar.");
                    Console.ReadLine();
                    MostrarMenuPesquisaDeDados();
                    break;
            }
        }
        static void MostrarMenuTabelaHash()
        {
            Console.WriteLine("=== TABELA HASH ===");
            Console.WriteLine("1 - Tabela Hash.");
            Console.WriteLine("0 - Voltar o Menu principal");
            var lista = Console.ReadLine();

            switch (lista)
            {
                case "1":
                    TabelaHash.Tabela();
                    break;
                case "0":
                    Console.WriteLine("Voltando ao menu principal..." + "Pressione ENTER para continuar.");
                    Console.ReadLine();
                    MostrarMenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção Inválida. " + "Pressione ENTER para continuar.");
                    Console.ReadLine();
                    MostrarMenuTabelaHash();
                    break;
            }
        }
        static void MostrarMenuFila()
        {
            Console.WriteLine("=== FILAS ===");
            Console.WriteLine("1 - Fila 01.");
            Console.WriteLine("0 - Voltar o Menu principal");
            var lista = Console.ReadLine();

            switch (lista)
            {
                case "1":
                    Queues.Fila01();
                    break;
                case "0":
                    Console.WriteLine("Voltando ao menu principal..." + "Pressione ENTER para continuar.");
                    Console.ReadLine();
                    MostrarMenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção Inválida. " + "Pressione ENTER para continuar.");
                    Console.ReadLine();
                    MostrarMenuFila();
                    break;
            }
        }
        static void MostrarMenuAlgoritmos()
        {
            Console.WriteLine("=== ALGORITMOS ===");
            Console.WriteLine("1 - Algoritmo 01.");
            Console.WriteLine("0 - Voltar o Menu principal");
            var lista = Console.ReadLine();

            switch (lista)
            {
                case "1":
                    Algoritmo.Algoritmo01();
                    break;
                case "0":
                    Console.WriteLine("Voltando ao menu principal..." + "Pressione ENTER para continuar.");
                    Console.ReadLine();
                    MostrarMenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção Inválida. " + "Pressione ENTER para continuar.");
                    Console.ReadLine();
                    MostrarMenuAlgoritmos();
                    break;
            }
        }
    }
}
