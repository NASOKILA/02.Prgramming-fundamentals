using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {

            string variableInHex = Console.ReadLine();   

            int variableInHexInNum = Convert.ToInt32(variableInHex, 16);
            Console.WriteLine(variableInHexInNum);

        }
    }
}
