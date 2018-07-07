namespace WordsCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Threading.Tasks;

    class WordsCount
    {
        static void Main(string[] args)
        {
            File.WriteAllText("Words.txt", "quick is fault");
            string words = File.ReadAllText("Words.txt");
            string[] wordsArr = words.ToLower().Split().ToArray();

            Dictionary<string, int> matchedWordsAndCount = new Dictionary<string, int>();

            string inputFile = File.ReadAllText("input.txt");
            string[] text = inputFile.ToLower().Split(' ', ',', '.', '-', '!', '?').ToArray();

            foreach (var word in text)
            {
                int counter = 0;
                foreach (var inputWord in wordsArr)
                {

                    if (word.Equals(inputWord))
                    {
                        counter++;
                        if (matchedWordsAndCount.ContainsKey(inputWord))
                            matchedWordsAndCount[inputWord] += counter;
                        else
                            matchedWordsAndCount[inputWord] = counter;
                    }
                }
            }

            File.WriteAllText("output.txt", "");

            foreach (var pair in matchedWordsAndCount.OrderByDescending(w => w.Value))
            {
                File.AppendAllText("output.txt", $"{pair.Key} - {pair.Value}" + "\r\n");
            }
        }
    }
}
