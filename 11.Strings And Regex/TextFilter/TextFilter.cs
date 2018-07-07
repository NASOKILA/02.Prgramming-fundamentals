namespace TextFilter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class TextFilter
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string text = Console.ReadLine();
            foreach (var banword in bannedWords)
            {
                if (text.Contains(banword))
                {
                    text = text.Replace(banword, new string('*', banword.Length));

                }
            }

            Console.WriteLine(text);
        }
    }
}
