namespace HelloName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static string PrintHelloName(string getName) {
            return "Hello, " + getName + "!";
        }
        
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string result = PrintHelloName(name);
            Console.WriteLine(result);
        }
    }
}
