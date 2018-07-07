namespace TripleSum
{
    using System;

    public class TripleSum
    {
        public static void Main(string[] args)
        {

            string numbers = Console.ReadLine();

            string[] items = numbers.Split(' ');

            int[] Array = new int[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                Array[i] = int.Parse(items[i]);

            }
            
            int sum = 0;
            bool check = false;

            for (int firtsDigit = 0; firtsDigit < Array.Length; firtsDigit++)  
            {
                for (int secondDigit = firtsDigit+1; secondDigit < Array.Length; secondDigit++) 
                {                   
                    sum = Array[firtsDigit] + Array[secondDigit];

                     for (int k = 0; k < Array.Length; k++)
                     {              
                        if (sum == Array[k]) 
                        {
                            Console.WriteLine("{0} + {1} == {2}", 
                            Array[firtsDigit],
                            Array[secondDigit],
                            sum);
                            check = true;

                            break; 
                        }
                    }  
                }
            }

            if (check == false) 
            {
                Console.WriteLine("No");
            }
        }
    }
}
