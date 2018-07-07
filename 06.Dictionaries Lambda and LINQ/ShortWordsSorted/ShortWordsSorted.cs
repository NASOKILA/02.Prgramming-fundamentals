namespace ShortWordsSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            char[] separators = { ' ', '.', ',', ';', ':', '(', ')', '[', ']', '"', '/', '\\', '!', '?' };

            string[] text = Console.ReadLine()
                .ToLower()
                .Split(separators)
                .ToArray();

            text = text
            .Where(f => f.Length < 5)
            .OrderBy(x => x)
            .Distinct()
            .ToArray();

            Console.WriteLine(string.Join(" ", text));
        }
    }
}
