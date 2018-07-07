namespace RoundingNumbersAwayFromZero
{
    using System;

    public class RoundingNumbersAwayFromZero
    {
        public static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] items = numbers.Split(' ');
            double[] Arr = new double[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                Arr[i] = double.Parse(items[i]);              
            }

            double[] Arr2 = new double[Arr.Length]; 
            
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr2[i] = Arr[i]; 
                Arr[i] = Math.Abs(Arr[i]); 
                Arr[i] = Arr[i] + 0.5; 
                if (Arr2[i] < 0) { Console.WriteLine(Arr2[i] + " => " +  "-" + Math.Truncate(Arr[i])); }
                else { Console.WriteLine(Arr2[i] + " => " + Math.Truncate(Arr[i])); }               
            }
        }
    }
}
