namespace Dictionaries_Lambda_and_LINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Dictionaries_Lambda_and_LINQ
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> name = new Dictionary<string, int>();
            foreach (var key in name.Keys) 
            {
                Console.WriteLine(key);
            }
            
            var phonebook = new Dictionary<string, string>();
            phonebook["John Smith"] = "0889094323";  
            phonebook["Lisa Smith"] = "0886745521";
            phonebook["Sam Doe"] = "0887034456";
            phonebook["Nakov"] = "0998123634";
            phonebook["Nakov"] = "0886223564"; 
            phonebook.Remove("John Smith"); 

            foreach (var show in phonebook) {
                Console.WriteLine("{0} --> {1}", show.Key, show.Value);
            }

            Console.WriteLine(); Console.WriteLine();
            foreach (var value in phonebook.Values)
            {
                Console.WriteLine(value);
            }
            
            double[] nums = Console.ReadLine()
               .Split(' ')
               .Select(number => double.Parse(number))
               .Select(number => number + Math.PI) 
               .ToArray();
            
            foreach (var num in nums)
            {
                Console.WriteLine(num); 
            }
            
            Console.WriteLine(); Console.WriteLine();
            
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            int[] nums1 = numbers.Take(3).ToArray(); 
            Console.WriteLine(string.Join(" ", nums1));
            int[] nums2 = numbers.Skip(3).ToArray();
            Console.WriteLine(string.Join(" ", nums2)); 
            
            int[] nums3 = numbers.Skip(2).Take(2).ToArray();
            Console.WriteLine(string.Join(" ", nums3));
            
            Console.WriteLine(); Console.WriteLine();
            
            int[] nnn = { 4, 6, 7, 89, 56 };

            var even = nnn.Where(x => x % 2 == 0); 
            var odd = nnn.Where(x => x % 2 == 1);

            var evenCount = nnn.Count(x => x % 2 == 0);
            var oddCount = nnn.Count(x => x % 2 == 1); 

            Console.WriteLine(string.Join(" ", even)); 
            Console.WriteLine(string.Join(" ", odd));

            Console.WriteLine("Samo broikata chetni " + string.Join(" ", evenCount));
            Console.WriteLine("Samo broikata nechetni " + string.Join(" ", oddCount));
            
            Console.WriteLine(); Console.WriteLine();
            
            int[] jjj = { 1, 2, 3, 4, 2, 5, 3, 7, 8, 9, 8, 7, 6 };
            jjj = jjj
                .Distinct()
                .ToArray();

            Console.WriteLine(string.Join(" ", jjj));
            
            Console.WriteLine(); Console.WriteLine();
            
            int[] jj = { 1, 2, 3, 4, };

            int first = jj
                .First(x => x % 2 == 0);

            int last = jj
                .Last(x => x % 2 ==0); 

            int single = jj
                .Single(x => x == 4); 
            
            Console.WriteLine("first  "+string.Join(" ", first));
            Console.WriteLine("last  " + string.Join(" ", last));
            Console.WriteLine("single  " + string.Join(" ", single)); 

            Console.WriteLine(); Console.WriteLine();
            
            int[] rev = { 1, 2, 3, 4, };
            rev = rev
                .Reverse()
                .ToArray();

            Console.WriteLine("reverse   "+string.Join(" ", rev));
            
            Console.WriteLine(); Console.WriteLine();
            
            int[] one = { 1, 2, 3, 4, };
            int[] two = { 5, 6, 7, 8, };

            one = one
                .Concat(two) 
                .ToArray();
            
            Console.WriteLine("Concat  " + string.Join(" ", one));
        }
    }
}
