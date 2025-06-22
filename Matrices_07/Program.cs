using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices_07
{
    public class ProgramMatrices_07
    {
        static void Main(string[] args)
        {
            Executa();
        }

        public static void Executa()
        {
            string[] dimensions = Console.ReadLine().Split(' ');
            int M = int.Parse(dimensions[0]);
            int N = int.Parse(dimensions[1]);

            int[,] formation = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                string[] soldiers = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    formation[i, j] = int.Parse(soldiers[j]);
                }
            }

            int rowToRotate = int.Parse(Console.ReadLine());

            int rowIndex = rowToRotate - 1;

            int lastSoldier = formation[rowIndex, N - 1];
            for (int j = N - 1; j > 0; j--)
            {
                formation[rowIndex, j] = formation[rowIndex, j - 1];
            }
            formation[rowIndex, 0] = lastSoldier;

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(formation[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}