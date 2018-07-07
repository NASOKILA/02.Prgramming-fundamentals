namespace Replace_a_tag
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"<a.*?href.*?=.*?(""\S*"")>(.*?)<\/a>";

            string replaced = @"[URL href=$1]$2[/URL]";

            string text = "<ul> <li> <a href=\"http://softuni.bg\">SoftUni</a></ li ></ ul > ";

            text = Regex.Replace(text, pattern, replaced);

            Console.WriteLine(text);
        }
    }
}
