namespace MagicExchangeableWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<char, char> map = new Dictionary<char, char>();

            string firstWord = words[0];
            string secondWord = words[1];

            int minLen = Math.Min(firstWord.Length, secondWord.Length);
            int maxLen = Math.Max(firstWord.Length, secondWord.Length);

            for (int i = 0; i < minLen; i++)
            {
                if (!map.ContainsKey(firstWord[i]))
                {
                    if (map.ContainsValue(secondWord[i]))
                    {
                        Console.WriteLine("false");
                        return;
                    }
                    map.Add(firstWord[i], secondWord[i]);
                }
                else
                {
                    if (map[firstWord[i]] != secondWord[i])
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
            }

            if (firstWord.Length == secondWord.Length)
            {
                Console.WriteLine("true");
                return;
            }

            string substring = string.Empty;

            if (firstWord.Length > secondWord.Length)
            {
                substring = firstWord.Substring(minLen);
            }
            else
            {
                substring = secondWord.Substring(minLen);
            }


            foreach (char c in substring)
            {
                if (!map.Keys.Contains(c) && !map.Values.Contains(c))
                {
                    Console.WriteLine("false");
                    return;
                }
            }

            Console.WriteLine("true");
        }
    }
}
