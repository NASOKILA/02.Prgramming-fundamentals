namespace ExtractSentencesByKeyword
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    class ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {
            char[] separator = { '.', '!', '?' };
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            string pattern = @"(?:[\s\-\,a-zA-Z0-9]+!|[\s\-\,a-zA-Z0-9]+\.|[\s\-\,a-zA-Z0-9]+\?)";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                if (match.ToString().Contains(" " + word))
                {
                    string result = match.ToString();
                    string lastEl = result[result.Length-1].ToString();
                    result = result.Replace(lastEl, "");
                    Console.WriteLine(result.Trim());
                }
            }
        }
    }
}
