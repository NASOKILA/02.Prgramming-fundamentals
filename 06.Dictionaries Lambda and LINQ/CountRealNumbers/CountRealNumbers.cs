namespace CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CountRealNumbers
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            double[] numbers = input.Split(' ').Select(double.Parse).ToArray();

            
            var counts = new SortedDictionary<double, int>();
            foreach (var num in numbers)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++; 
                }
                else
                {
                    counts[num] = 1;
                }
            }

            foreach (var pair in counts)
            {
                Console.WriteLine("{0} -> {1}",pair.Key, pair.Value);
            }
        }
    }
}
