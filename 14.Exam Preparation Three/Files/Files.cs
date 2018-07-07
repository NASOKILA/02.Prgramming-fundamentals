namespace Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Files
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, long>> inputData = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, long> NameSize = new Dictionary<string, long>();
            for (int i = 0; i < n; i++)
            {
                List<string> file = Console.ReadLine().Split(new char[] { '\\', ';' }
                , StringSplitOptions.RemoveEmptyEntries).ToList();

                string root = file[0];
                file.Remove(file[0]);
                long size = long.Parse(file.Last());
                file.Remove(file.Last());
                string name = file.Last();
                file.Remove(file.Last());



                if (inputData.ContainsKey(root))
                {

                    inputData[root][name] = size;
                }
                else
                {

                    NameSize = new Dictionary<string, long>();
                    NameSize[name] = size;

                    inputData[root] = NameSize;
                }

            }


            string[] command = Console.ReadLine().Split().ToArray();

            string type = command[0];
            string searchRoot = command[2];
            bool printed = false;

            if (inputData.Keys.Contains(searchRoot))
            {
                NameSize = inputData[searchRoot]
                     .OrderByDescending(id => id.Value)
                     .ThenBy(p => p.Key)
                     .ToDictionary(id => id.Key, id => id.Value);



                foreach (var pair in NameSize)
                {
                    if (pair.Key.Contains(type))
                    {
                        Console.WriteLine($"{pair.Key} - {pair.Value} KB");
                        printed = true;
                    }
                }
            }

            if (!printed)
                Console.WriteLine("No");

        }
    }
}
