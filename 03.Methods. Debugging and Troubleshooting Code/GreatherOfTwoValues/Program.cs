using System;

namespace GreatherOfTwoValues
{
    class Program
    {
        static int Print(int a, int b) {
            return Math.Max(a, b);
        }

        static string Print(string a, string b){
            string result = "";
            if (a.Length <= b.Length) { result = b; }
            else { result = a; }
            
            return result;
            
        }

        static char Print(char a, char b)
        {
            char result = a;
            if (a < b) { result = b; }
            return result;
        }

      
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            
            if (dataType == "int") {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int result = Print(a, b);
                Console.WriteLine(result);
            }
            else if (dataType == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string result = Print(a, b);
                Console.WriteLine(result);
            }
            else if (dataType == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                char result = Print(a, b);
                Console.WriteLine(result);
            }
        }
    }
}
