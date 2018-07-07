namespace SalesReport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SalesReport
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, double> TownTotalSales = new SortedDictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                string saleInput = Console.ReadLine();

                Sales Sale = ReadSale(saleInput);
                CalculateSale(Sale, TownTotalSales);
            }

            PrintTownAndTotalSales(TownTotalSales);
        }

        private static Sales ReadSale(string saleInput)
        {
            string[] saleInputArray = saleInput.Split(' ').ToArray();

            Sales Sale = new Sales
            {
                Town = saleInputArray[0],
                Product = saleInputArray[1],
                Price = double.Parse(saleInputArray[2]),
                Quantity = double.Parse(saleInputArray[3])
            };

            return Sale;
        }

        private static void CalculateSale(Sales Sale, SortedDictionary<string, double> TownTotalSales)
        {

            if (!TownTotalSales.ContainsKey(Sale.Town))
                TownTotalSales[Sale.Town] = Sale.Price * Sale.Quantity;
            else
                TownTotalSales[Sale.Town] += Sale.Price * Sale.Quantity;
        }

        private static void PrintTownAndTotalSales(SortedDictionary<string, double> TownTotalSales)
        {

            foreach (var item in TownTotalSales)
            {
                Console.WriteLine("{0} -> {1:f2}", item.Key, item.Value / 100);
            }
        }
    }

}
