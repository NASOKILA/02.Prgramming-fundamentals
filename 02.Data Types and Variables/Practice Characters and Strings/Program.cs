using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Characters_and_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string s1 = "Software";
            string s11 = "University";

            char ch1 = (char)66;  
            char ch2 = (char)121;  
            char ch3 = (char)101;  

            string s21 = "I";
            string s22 = "love";
            string s23 = "programming";

            Console.WriteLine($"{s1} {s11}");  
            Console.WriteLine(ch1);
            Console.WriteLine(ch2);
            Console.WriteLine(ch3);
            Console.WriteLine("{0} {1} {2}",s21,s22,s23);  

        }
    }
}
