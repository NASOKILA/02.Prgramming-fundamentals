using System;


namespace FastPrimeChecker_Refactor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            for (int number = 2; number <= n; number++)
            {

                bool isItPrime = true;

                for (int divider = 2; divider <= Math.Sqrt(number); divider++)   
                {
                    if (number % divider == 0) 
                    {
                        isItPrime = false;
                        break;
                    }
                }

                Console.WriteLine($"{number} -> {isItPrime}");
            }

        }
    }
}
