namespace LettersChangeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();  

           decimal totalSum = 0;
            for (int i = 0; i < input.Count; i++)
            {
                char firstLetter = input[i].First();
                char lastLetter = input[i].Last();
                string numStr = "";
                foreach (var ch in input[i])
                {
                    if (Char.IsDigit(ch))
                        numStr += ch;
                                            
                }
                decimal num = decimal.Parse(numStr);

                if (Char.IsUpper(firstLetter))
                    num = num / ((int)firstLetter - 64);
                else 
                    num = num * ((int)firstLetter - 96);

                if (Char.IsUpper(lastLetter))
                    num =  num - ((int)lastLetter - 64);
                else
                    num = num + ((int)lastLetter - 96);

                totalSum += num;    
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
