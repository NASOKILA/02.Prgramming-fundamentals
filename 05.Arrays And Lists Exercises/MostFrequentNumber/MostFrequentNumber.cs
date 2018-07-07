using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {

            ushort[] array = Console.ReadLine().Split(' ').Select(ushort.Parse).ToArray();

            var query = (from item in array
                         group item by item into g
                         orderby g.Count() descending
                         select g.Key).First();

            Console.WriteLine(query);
        }
    }
}
