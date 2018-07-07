using System;
using System.Linq;

namespace NumbersInReversedOrder
{
    public class NumbersInReversedOrder
    {
        static string PrintNumberInReversedOrder(string number)
        {
            string result = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                result = result + number[i]; 
            }         

            return result;
        }

        public static void Main(string[] args)
        {
           string n = Console.ReadLine();
           string result = PrintNumberInReversedOrder(n);
            Console.WriteLine(result);
        }
    }
}