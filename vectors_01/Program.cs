using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors_01
{
    public class ProgramVectors_01
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

            double maxNumber = numbers[0];
            int maxPosition = 0;

            for (int i = 1; i < N; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                    maxPosition = i;
                }
            }

            Console.WriteLine(maxNumber.ToString("F1"));
            Console.WriteLine(maxPosition);
        }
    }
}