using Dynamic_List;
using PointerList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MainMenu
{
    public class Lists
    {
            public static void Dynamic()
            {
                Console.WriteLine("Projeto Lista Dinâmica executado com sucesso!");
                ProgramDynamic_List.Executa();

            }
        public static void PointerList()
        {
            Console.WriteLine("Projeto Lista de Ponteiros executado com sucesso!");
            PointerListExecutavel.Executa();

        }
    }
}
