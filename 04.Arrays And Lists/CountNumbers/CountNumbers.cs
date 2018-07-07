namespace CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CountNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var nums= new List<int>(input);
            nums.Sort(); 

            var position = 0;
            while (position < nums.Count)
            {
                int n = nums[position];
                int count = 0;
                while (position + count < nums.Count && nums[position + count] == n)
                {
                    count++;
                }

                position = position + count;
                Console.WriteLine("{0} -> {1}",n,count );
            }
        }
    }
}
