using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exact_sum_of_real_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int aa = int.Parse(Console.ReadLine());
            decimal sum2 = 0;
            
            for (int i = 0; i < aa; i++)
            {
                sum2 += decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum2); 
        }
    }
}
