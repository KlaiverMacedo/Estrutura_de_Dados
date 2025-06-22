using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors_08
{
    public class ProgramVectors_08
    {
        static void Main(string[] args)
        {
            Executa();
        }

        public static void Executa()
        {
            int N = int.Parse(Console.ReadLine());

            double[] heights = new double[N];
            char[] genders = new char[N];

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                heights[i] = double.Parse(input[0]);
                genders[i] = char.Parse(input[1].ToUpper());
            }

            double maxHeight = heights.Max();
            double minHeight = heights.Min();

            double womenHeightSum = 0;
            int womenCount = 0;
            int menCount = 0;

            for (int i = 0; i < N; i++)
            {
                if (genders[i] == 'F')
                {
                    womenHeightSum += heights[i];
                    womenCount++;
                }
                else if (genders[i] == 'M')
                {
                    menCount++;
                }
            }

            double womenAvgHeight = womenCount > 0 ? womenHeightSum / womenCount : 0;

            Console.WriteLine($"Menor altura = {minHeight:F2}");
            Console.WriteLine($"Maior altura = {maxHeight:F2}");
            Console.WriteLine($"Media das alturas das mulheres = {womenAvgHeight:F2}");
            Console.WriteLine($"Numero de homens = {menCount}");
        }
    }
}