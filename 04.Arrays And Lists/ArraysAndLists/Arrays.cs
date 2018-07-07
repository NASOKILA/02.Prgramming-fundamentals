using System;


namespace ArraysAndLists
{
    public class Arrays
    {

        public static void Increment(int num, int n) {
            num += n;
        }
        public static void IncrementArray(int[] num2, int n)
        {
            num2[0] += n;
        }
        public static void Main(string[] args)
        {
            int num = 5;
            Increment(num, 15);  
            Console.WriteLine(num);  

            int[] num2 = { 5 };  
            IncrementArray(num2, 15);
            Console.WriteLine(num2[0]);  
            
            int[] numbers = new int[10]; 
            Console.WriteLine(numbers[5]); 
            for (int i = 0; i < numbers.Length; i++) 
            {
                numbers[i] = i; 
            }
            Console.WriteLine(numbers[5]);
            
            Console.WriteLine(); Console.WriteLine();

            string[] daysOfWeek = new string[7];
            daysOfWeek[0] = "Monday";
            daysOfWeek[1] = "Tuesday";
            daysOfWeek[2] = "Wednesday";
            daysOfWeek[3] = "Thursday";
            daysOfWeek[4] = "Friday";
            daysOfWeek[5] = "Saturday";
            daysOfWeek[6] = "Sunday";

            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                Console.WriteLine(daysOfWeek[i]);
            }

            Console.WriteLine(); Console.WriteLine();
            
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n]; 

            for (int i = 0; i < n; i++) 
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("arr[3] = " + arr[1]);


            Console.WriteLine(); Console.WriteLine();

            
            string values = Console.ReadLine();

            string[] items = values.Split(' ');
            
            int[] Arr3 = new int[items.Length]; 
            
            for (int i = 0; i < items.Length; i++)
            {
                Arr3[i] = int.Parse(items[i]);
            }
            
            Console.WriteLine(); Console.WriteLine();

            string[] Arr2 = { "one", "two", "three", "four", "five" }; 

            for (int i = 0; i < Arr2.Length; i++)
            {
                Console.WriteLine(Arr2[i]); 
            }
            
            Console.WriteLine(); Console.WriteLine();
            
            int[] arr4 = { 10, 20, 30, 40 };
            
            foreach (var element in arr4) { 
                Console.WriteLine(element);
            }
            
            Console.WriteLine(string.Join(", ", arr4));  
        }
    }
}
