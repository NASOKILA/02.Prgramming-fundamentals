namespace RandomizeWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RandomizeWords
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] words = input.Split(' ').ToArray();

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var randomIndex = rnd.Next(0, words.Length);

                var tempWord = words[randomIndex];
                words[i] = tempWord;
                words[randomIndex] = currentWord;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
