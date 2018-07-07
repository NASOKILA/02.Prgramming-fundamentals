namespace AMinerTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string resourse = Console.ReadLine();

            Dictionary<string, long> miner = new Dictionary<string, long>();

            while (!resourse.Equals("stop"))
            {
                long quantity = long.Parse(Console.ReadLine());

                if (miner.ContainsKey(resourse))
                {
                    miner[resourse] += quantity;
                }
                else
                {
                    miner[resourse] = quantity;
                }

                resourse = Console.ReadLine();
            }

            foreach (var pair in miner)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
