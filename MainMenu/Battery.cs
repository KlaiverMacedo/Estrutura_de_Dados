using Battery_01;
using Battery_02;
using Battery_03;
using Dynamic_List;
using PointerList;
using StaticList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenu
{
    class Battery
    {
            public static void Battery_01()
            {
                Console.WriteLine("Projeto Bateria 01 executado com sucesso!");
            ProgramBattery_01.Execute();

            }
            public static void Battery_02()
            {
                Console.WriteLine("Projeto Bateria 02 executado com sucesso!");
            ProgramBattery_02.Execute();

        }
            public static void Battery_03()
            {
                Console.WriteLine("Projeto Bateria 03 executado com sucesso!");
                ProgramBattery_03.Execute();

        }
        }
}
