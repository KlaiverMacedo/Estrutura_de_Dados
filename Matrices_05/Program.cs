using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices_05
{
    public class ProgramMatrices_05
    {
        static void Main(string[] args)
        {
            Executa();
        }

        public static void Executa()
        {
            string[] dimensoes = Console.ReadLine().Split(' ');
            int M = int.Parse(dimensoes[0]);
            int N = int.Parse(dimensoes[1]);

            int[,] A = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(linha[j]);
                }
            }

            int[,] B = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    B[i, j] = int.Parse(linha[j]);
                }
            }

            int[,] C = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}