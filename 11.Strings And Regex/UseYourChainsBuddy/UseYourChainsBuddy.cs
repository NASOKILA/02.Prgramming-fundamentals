namespace UseYourChainsBuddy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    class UseYourChainsBuddy
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string pattern = @"<p>(.+?)</p>";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                string str = match.Groups[1].ToString().Trim();
                str = Regex.Replace(str, "\\s+", " "); 
                str = Regex.Replace(str, "\\W+", " "); 
                str = str.Trim();
                
              string result = string.Empty;
                foreach (Char element in str)
                {
                    if (element >= 'a' && element <= 'm')
                    {
                        int index = Convert.ToInt32(element) + 13;
                        char newElement = (char)index;
                        result += newElement;
                    }
                    else if (element >= 'n' && element <= 'z')
                    {
                        int index = Convert.ToInt32(element) - 13;
                        char newElement = (char)index;
                        result += newElement;
                    }
                    else
                        result += element;
                }

                Console.Write(result + " ");
            }
        }
    }
}
