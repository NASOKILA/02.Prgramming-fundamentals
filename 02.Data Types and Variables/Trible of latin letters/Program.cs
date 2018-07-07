using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trible_of_latin_letters
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            char sinbols = (char)97;  

            for (char i = sinbols; i < sinbols + n; i++)
            { 
                for (char j = sinbols; j < sinbols + n; j++)
                {
                    for (char h = sinbols; h < sinbols + n; h++) 
                    {
                        Console.WriteLine("{0}{1}{2}",i,j,h);
                    }
                }
            }
        }
    }
}
