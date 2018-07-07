using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {


            byte counter = 0;
            for (int i = 0; i <= 260; i++)
            {

                Console.WriteLine(counter);
                counter++;
            }

            Console.WriteLine(); Console.WriteLine();

            Console.Write("Centuries = ");
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes",
            centuries, years, days, hours, minutes);


            Console.WriteLine(); Console.WriteLine();

            long nula = 0U;
            Console.WriteLine(nula);



            float floatPI = 3.141592653589793238F;
            double doublePI = 3.141592653589793238;
            Console.WriteLine("float :" + floatPI);
            Console.WriteLine("double :" + doublePI);


            Console.WriteLine(); Console.WriteLine();


            Console.WriteLine(Math.Round(2.5));
            Console.WriteLine(Math.Round(2.49));
            Console.WriteLine(Math.Round(2.12345600000000, 3));
            Console.WriteLine(); Console.WriteLine();


            double radius = double.Parse(Console.ReadLine());
            radius = Math.PI * radius * radius;
            Console.WriteLine("{0:f12}", radius);

            Console.WriteLine(); Console.WriteLine();

            double d = 10000000000000000000000000000000000.0;
            Console.WriteLine(d);
            double d2 = 20e-3;
            Console.WriteLine(d2);// 0.02

            int maxint = int.MaxValue;
            Console.WriteLine("int max = " + maxint);
            int minint = int.MinValue;
            Console.WriteLine("int min = " + minint);

            Console.WriteLine();

            float maxfloat = float.MaxValue;
            Console.WriteLine("float max = " + maxfloat);
            float minfloat = float.MinValue;
            Console.WriteLine("float min = " + minfloat);

            Console.WriteLine();

            double maxdouble = double.MaxValue;
            Console.WriteLine("double max = " + maxdouble);
            double mindouble = double.MinValue;
            Console.WriteLine("double min = " + mindouble);


            Console.WriteLine(); Console.WriteLine();



            double a = 1.0f, b = 0.33f, sum = 1.33;
            Console.WriteLine("a + b = {0}, sum = {1}, equals = {2}", a + b, sum, (a + b == sum));
            int aa = int.Parse(Console.ReadLine());
            decimal sum2 = 0;


            for (int i = 0; i < aa; i++)
            {
                sum2 += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum2);


            Console.WriteLine(); Console.WriteLine();

            int aaa = 1;
            int bbb = 2;

            bool aaaIsGreatherThanBbb = (aaa > bbb);
            Console.WriteLine(aaaIsGreatherThanBbb);

            bool aaaIsLessThanBbb = (aaa < bbb);
            Console.WriteLine(aaaIsLessThanBbb);



            Console.WriteLine(); Console.WriteLine();



            char obratnoUdivitelnoOtUnicodeTablicata = (char)161;
            Console.WriteLine("Znak : " + obratnoUdivitelnoOtUnicodeTablicata);
            Console.WriteLine(("Chislo zad znaka : " + (int)obratnoUdivitelnoOtUnicodeTablicata));

            Console.WriteLine();
            Console.WriteLine("Atanas");
            Console.WriteLine("\"Atanas\"");


            Console.WriteLine(); Console.WriteLine();

            string file = "C: \\Windows\\win.ini";
            string file2 = @"C: \Windows\win.ini";

            Console.WriteLine("Standart : " + file); Console.WriteLine("Verbatim : " + file2);


            string FIRSTNAME = "Asen";
            string LASTNAME = "Kambitov";
            string FULLNAME = $"{FIRSTNAME} {LASTNAME}";
            Console.WriteLine("Interpolated : " + FULLNAME);

            Console.WriteLine(); Console.WriteLine();

            var outer = "I am outside !";
            // 1
            for (int i = 0; i < 5; i++)                         // 2
            {                                                   // 3
                var inner = "I am insade the loop !";          // 4
            }                                                   // 5
                                                                // 6
            Console.WriteLine(outer);

            double num3 = 1.123456789;
            double num4 = 1.123456789;
            Console.WriteLine("{0:f4}", num3);
            Console.WriteLine("{0:f7}", num3);

            num4 = Math.Round(num4, 4);
            Console.WriteLine(Math.Round(num4, 4));
            Console.WriteLine(Math.Round(num4, 7));

        }
    }
}
