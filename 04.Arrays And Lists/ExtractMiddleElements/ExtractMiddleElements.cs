using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] items = values.Split(' ');

            int[] Arr = new int[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                Arr[i] = int.Parse(items[i]);
            }

            if (Arr.Length == 1)
            {
                Console.WriteLine(Arr[0]);
            }
            else if (Arr.Length % 2 == 0)  
            {
                int[] Even = new int[2]; 
                Even[0] = Arr[Arr.Length / 2 - 1];
                Even[1] = Arr[Arr.Length / 2];
                Console.Write("{ " + Even[0] + ", " + Even[1] + " }");
            }
            else if (Arr.Length % 2 == 1)
            {
                int[] Odd = new int[3]; 
                Odd[0] = Arr[Arr.Length / 2 - 1];
                Odd[1] = Arr[Arr.Length / 2];
                Odd[2] = Arr[Arr.Length / 2 + 1];
                Console.WriteLine("{ " + Odd[0] + ", " + Odd[1] + ", " + Odd[2] + " }");
            }
        }
    }
}
