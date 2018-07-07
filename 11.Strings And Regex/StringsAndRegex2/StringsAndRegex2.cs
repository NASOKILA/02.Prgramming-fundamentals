
namespace StringsAndRegex2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Text;
    using System.Diagnostics;

    class StringsAndRegex2
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }
            Console.WriteLine(sb);


            Console.WriteLine(); Console.WriteLine();

            string result = "";
            Stopwatch st = new Stopwatch();
            st.Start();

            for (int i = 0; i < 35000; i++)
            {
                result += (Convert.ToString(i, 2) + "\n");
            }

            st.Stop();

            Console.WriteLine("Sus string:  " + st.Elapsed);

            StringBuilder result2 = new StringBuilder();

            Stopwatch st2 = new Stopwatch();

            st2.Start();
            for (int i = 0; i < 35000; i++)
            {
                result2.Append(Convert.ToString(i, 2) + "\n");
            }

            st2.Stop();

            Console.WriteLine("Sus StringBuilder:  " + st2.Elapsed);

        }
    }
}
