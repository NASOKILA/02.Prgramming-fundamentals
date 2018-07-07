namespace MatchFullName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    class MatchFullName
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            
            Regex regex = new Regex(pattern); 

            string text = "ivan ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Ivan IvAnov, Ivan Ivanov";

            bool isTextMatch = regex.IsMatch(text);

            Console.WriteLine(isTextMatch); 
        }
    }
}
