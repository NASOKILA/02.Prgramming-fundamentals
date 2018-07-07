using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
   public class ComparingFloats
    {
      public static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool isItEqual = false;
            double diff = Math.Abs(a - b);

            if (diff < eps) {

                isItEqual = true;
            }

            Console.WriteLine(isItEqual);
        }
    }
}
