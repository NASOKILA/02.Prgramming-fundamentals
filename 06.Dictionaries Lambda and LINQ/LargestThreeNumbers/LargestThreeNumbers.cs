namespace LargestThreeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class LargestThreeNumbers
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(n => int.Parse(n))
                .OrderByDescending(x => x)
                .ToArray();

            byte nTimes = 3;
            if (nums.Length < nTimes) { nTimes = (byte)nums.Length; }

           var result = nums.Take(nTimes);
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
