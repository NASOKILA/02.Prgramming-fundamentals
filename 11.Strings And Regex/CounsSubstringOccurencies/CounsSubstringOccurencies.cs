namespace CounsSubstringOccurencies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CounsSubstringOccurencies
    {
        static void Main(string[] args)
        {
            
            string text = Console.ReadLine().ToLower();
            string searchString = Console.ReadLine().ToLower();

            int counter = 0;

            int index = text.IndexOf(searchString); 

            while (index != -1) 
            {
                counter++; 
                index = text.IndexOf(searchString, index + 1); 
            }

            Console.WriteLine(counter);
        }
    }
}