using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors_09
{
    public class ProgramVectors_09
    {
        static void Main(string[] args)
        {
            Executa();
        }

        public static void Executa()
        {
            int N = int.Parse(Console.ReadLine());

            string[] names = new string[N];
            double[] purchasePrices = new double[N];
            double[] salePrices = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                names[i] = input[0];
                purchasePrices[i] = double.Parse(input[1]);
                salePrices[i] = double.Parse(input[2]);
            }

            int lowProfit = 0, mediumProfit = 0, highProfit = 0;
            double totalPurchase = 0, totalSale = 0;

            for (int i = 0; i < N; i++)
            {
                double profitPercentage = (salePrices[i] - purchasePrices[i]) / purchasePrices[i] * 100;
                totalPurchase += purchasePrices[i];
                totalSale += salePrices[i];

                if (profitPercentage < 10)
                    lowProfit++;
                else if (profitPercentage <= 20)
                    mediumProfit++;
                else
                    highProfit++;
            }

            double totalProfit = totalSale - totalPurchase;

            Console.WriteLine($"Lucro abaixo de 10%: {lowProfit}");
            Console.WriteLine($"Lucro entre 10% e 20%: {mediumProfit}");
            Console.WriteLine($"Lucro acima de 20%: {highProfit}");
            Console.WriteLine($"Valor total de compra: {totalPurchase:F2}");
            Console.WriteLine($"Valor total de venda: {totalSale:F2}");
            Console.WriteLine($"Lucro total: {totalProfit:F2}");
        }
    }
}