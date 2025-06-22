using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors_04
{
    public class ProgramVectors_04
    {
        static void Main(string[] args)
        {
            Executa();
        }

        public static void Executa()
        {
            int N = int.Parse(Console.ReadLine());

            double[] numbers = new double[N];
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                numbers[i] = double.Parse(input[i]);
            }

            double sum = 0.0;
            for (int i = 0; i < N; i++)
            {
                sum += numbers[i];
            }
            double average = sum / N;

            Console.WriteLine(average.ToString("F3"));

            for (int i = 0; i < N; i++)
            {
                if (numbers[i] < average)
                {
                    Console.WriteLine(numbers[i].ToString("F1"));
                }
            }
        }
    }
}