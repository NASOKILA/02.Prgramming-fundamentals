namespace LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class LogsAggregator
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, int> userDuration = new SortedDictionary<string, int>();
            SortedDictionary<string, List<string>> userIps = new SortedDictionary<string, List<string>>();

            int oldDuration = 0;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] inputArr = input.Split(' ');

                string ip = inputArr[0];
                string name = inputArr[1];
                int duration = int.Parse(inputArr[2]);


                if (!userDuration.ContainsKey(name))
                {
                    userDuration[name] = duration;
                    oldDuration = duration;

                    userIps[name] = new List<string>();
                    userIps[name].Add(ip);
                }
                else
                {
                    if (!userIps[name].Contains(ip))
                    {
                        userIps[name].Add(ip);
                    }

                    duration += userDuration[name];
                    userDuration[name] = duration;
                }
            }

            PrintNameDurationIp(userDuration, userIps);
        }

        private static void PrintNameDurationIp(SortedDictionary<string, int> userDuration,
            SortedDictionary<string, List<string>> userIps)
        {
            foreach (var user in userDuration)
            {
                string userName = user.Key;
                int totalDuration = userDuration[user.Key];
                List<string> allIps = userIps[user.Key].ToList();

                Console.WriteLine("{0}: {1} [{2}]", userName, totalDuration, string.Join(", ", allIps));
            }
        }
    }
}
