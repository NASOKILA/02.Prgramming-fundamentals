using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().
                Split(' ').Select(int.Parse).ToList();

            var result = new List<int>();
            for (var i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
                {
                    result.Add(numbers[i]);
                }
            }
            result.Sort((a, b) => b.CompareTo(a));  
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
