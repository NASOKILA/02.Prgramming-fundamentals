namespace RageQuit2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    class RageQuit2
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();

            string pattern = "(\\D+)(\\d+)";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            int sinbolsCount = 0;

            StringBuilder output = new StringBuilder();

            foreach (Match match in matches)
            {

                for (int i = 0; i < int.Parse(match.Groups[2].ToString()); i++)
                {
                    output.Append(match.Groups[1]);
                }
            }


            sinbolsCount = output.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {sinbolsCount}");

            Console.WriteLine(output);
        }
    }
}
