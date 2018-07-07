namespace CharacterMultiplier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArr = input.Split().ToArray();
            string str1 = inputArr[0];
            string str2 = inputArr[1];

            int sum = 0;

            int maxLen = Math.Max(str1.Length, str2.Length);
            int minLen = Math.Min(str1.Length, str2.Length);

            for (int i = 0; i < minLen; i++)
            {
                sum += str1[i] * str2[i];
            }

            if (str1.Length != str2.Length)
            {
                string longerInput = str1.Length > str2.Length
                    ? longerInput = str1
                    : longerInput = str2;

                for (int i = minLen; i < maxLen; i++)
                {
                    sum += longerInput[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
