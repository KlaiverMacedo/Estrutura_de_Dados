using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors_02
{
    public class ProgramVectors_02
    {
        static void Main(string[] args)
        {
            Executa();
        }

        public static void Executa()
        {
            int N = int.Parse(Console.ReadLine());

            int[] numbers = new int[N];
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            int evenCount = 0;
            List<int> evenNumbers = new List<int>();

            for (int i = 0; i < N; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                    evenCount++;
                }
            }

            Console.WriteLine(string.Join(" ", evenNumbers));

            Console.WriteLine(evenCount);
        }
    }
}