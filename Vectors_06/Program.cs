using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors_06
{
    public class ProgramVectors_06
    {
        static void Main(string[] args)
        {
            Executa();
        }

        public static void Executa()
        {
            int N = int.Parse(Console.ReadLine());

            string[] names = new string[N];
            int[] ages = new int[N];

            for (int i = 0; i < N; i++)
            {
                names[i] = Console.ReadLine();
                ages[i] = int.Parse(Console.ReadLine());
            }

            int maxAge = ages[0];
            string oldestPerson = names[0];

            for (int i = 1; i < N; i++)
            {
                if (ages[i] > maxAge)
                {
                    maxAge = ages[i];
                    oldestPerson = names[i];
                }
            }

            Console.WriteLine("Pessoa mais velha: " + oldestPerson);
        }
    }
}