using System;

namespace PrintPartOfTheASCIITable
{
    public class PrintPartOfTheASCIITable
    {
        public static void Main(string[] args)
        {

            byte start = byte.Parse(Console.ReadLine());
            byte end = byte.Parse(Console.ReadLine());

            char startChr = (char)start;
            char endChr = (char)end;

            for (char i = startChr; i <= endChr; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
    }
}
