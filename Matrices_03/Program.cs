using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices_03
{
    public class ProgramMatrices_03
    {
        static void Main(string[] args)
        {
            Executa();
        }

        public static void Executa()
        {
            int N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(linha[j]);
                }
            }

            for (int i = 0; i < N; i++)
            {
                int maior = matriz[i, 0]; 
                for (int j = 1; j < N; j++)
                {
                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                    }
                }
                Console.WriteLine(maior);
            }
        }
    }
}