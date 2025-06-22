using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors_07
{
    public class ProgramVectors_07
    {
        static void Main(string[] args)
        {
            Executa();
        }

        public static void Executa()
        {
            int N = int.Parse(Console.ReadLine());

            string[] names = new string[N];
            double[] firstSemester = new double[N];
            double[] secondSemester = new double[N];

            for (int i = 0; i < N; i++)
            {
                names[i] = Console.ReadLine();
                firstSemester[i] = double.Parse(Console.ReadLine());
                secondSemester[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Alunos aprovados:");
            for (int i = 0; i < N; i++)
            {
                double average = (firstSemester[i] + secondSemester[i]) / 2.0;
                if (average >= 6.0)
                {
                    Console.WriteLine(names[i]);
                }
            }
        }
    }
}