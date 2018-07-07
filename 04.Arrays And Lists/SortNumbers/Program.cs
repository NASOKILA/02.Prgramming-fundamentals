namespace SortNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').
                Select(decimal.Parse).ToList();

            var spisuk = new List<decimal>(numbers); 
            spisuk.Sort(); 
            Console.WriteLine(string.Join(" <= ", spisuk)); 
        }
    }
}
