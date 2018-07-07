using System;

namespace LastKNumbersSums
{
    public class LastKNumbersSums
    {
        public static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            long[] seq = new long[n];
               
            seq[0] = 1; 

            for (long i = 1; i < n; i++)  
            {
                long sum = 0; 

                for (long j = i-k; j <= i-1; j++) 
                {
                    if (j >= 0) 
                    {
                        sum += seq[j];
                    }
                }
                seq[i] = sum;  
            }
            
            for (int i = 0; i < n; i++)
            {
                Console.Write(seq[i] + " ");
                Console.WriteLine();
            }

        }
    }
}
