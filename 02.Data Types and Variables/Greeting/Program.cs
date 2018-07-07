using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string age = Console.ReadLine();

            int intAge = int.Parse(age); 
            Console.WriteLine("Hello, {0} {1}. You are {2} years old.",firstName,lastName,intAge);

        }
    }
}
