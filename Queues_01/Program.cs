using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Queues_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, queue, LastInLine;
            int[,] mat;
            string[] values;

            Console.WriteLine("Digite a quntidade de filas: ");
            m = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de soldados");
            n = int.Parse(Console.ReadLine());

            mat = new int[m, n];


            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Fila {i + 1} :");
                values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);

                }
            }

            Console.WriteLine("Fila a ser movimentada: ");
            queue = int.Parse(Console.ReadLine());

            //decrementar o valor da fila visto que a posição inicial e (0)
            //decrement the queue value since the starting position is (0)
            queue--;  

            LastInLine = mat[queue, n - 1];

            for (int i = n - 1; i > 0; i--)
            {
                mat[queue, i] = mat[queue, i - 1];
            }
            mat[queue, 0] = LastInLine;

            for (int i = 0; i < m; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
