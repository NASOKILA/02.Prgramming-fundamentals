using System;

namespace FibonacciNumbers
{
    public class FibonacciNumbers
    {
        
        static void GetFibonacciNumbers(long num) {

            long fib0 = 1;
            long fib1 = 1;
            long fibCurrent = 1;
            for (int i = 2; i <= num; i++)   
            {
                
                fib0 = fib1;
                fib1 = fibCurrent ;
                fibCurrent = fib0 + fib1;
            }
            Console.WriteLine(fibCurrent);

        }

        public static void Main(string[] args)
        {

            long n = long.Parse(Console.ReadLine());
            GetFibonacciNumbers(n);
            
        }
    }
}
