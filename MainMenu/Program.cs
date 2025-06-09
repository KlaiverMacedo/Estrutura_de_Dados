using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dynamic_List;
using PointerList;


namespace MainMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MENU ===");
            Console.WriteLine("1 - Executar projeto de Listas: ");

            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
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
                    }

                    break;
                case "0":
                    Console.WriteLine("Encerrando...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
