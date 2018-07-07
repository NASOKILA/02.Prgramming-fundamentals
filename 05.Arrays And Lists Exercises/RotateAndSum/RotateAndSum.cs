namespace RotateAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> parsedNumbers = new List<int>(inputNumbers);
            int k = int.Parse(Console.ReadLine());                

            if (parsedNumbers.Count == 0 )
            {
                Console.WriteLine(string.Join(" ", inputNumbers));
            }
            else
            {
                int[] sum = new int[parsedNumbers.Count];
                for (int i = 0; i < parsedNumbers.Count; i++)
                {
                    sum[i] = 0;
                }
                
                for (int i = 0; i < k; i++)
                {
                    int last = parsedNumbers[parsedNumbers.Count - 1]; 
                    parsedNumbers.RemoveAt(parsedNumbers.Count - 1); 
                    parsedNumbers.Insert(0, last);  
              
                    for (int j = 0; j < parsedNumbers.Count; j++)
                    {
                        sum[j] = sum[j] + parsedNumbers[j];
                    }
                }
                Console.WriteLine(string.Join(" ", sum));
            }
        }
    }
}
 