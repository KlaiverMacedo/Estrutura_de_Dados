using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices_06
{
    public class ProgramMatrices_06
    {
        static void Main(string[] args)
        {
            Executa();
        }

        public static void Executa()
        {
            int N = int.Parse(Console.ReadLine());

            double[,] matrix = new double[N, N];
            for (int i = 0; i < N; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = double.Parse(line[j]);
                }
            }

            double sumPositives = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        sumPositives += matrix[i, j];
                    }
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS: " + sumPositives.ToString("F1"));

            int chosenLine = int.Parse(Console.ReadLine());
            Console.Write("LINHA ESCOLHIDA: ");
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[chosenLine, j].ToString("F1") + " ");
            }
            Console.WriteLine();

            int chosenColumn = int.Parse(Console.ReadLine());
            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(matrix[i, chosenColumn].ToString("F1") + " ");
            }
            Console.WriteLine();

            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(matrix[i, i].ToString("F1") + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = matrix[i, j] * matrix[i, j];
                    }
                }
            }

            Console.WriteLine("MATRIZ ALTERADA:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j].ToString("F1") + " ");
                }
                Console.WriteLine();
            }
        }
    }
}