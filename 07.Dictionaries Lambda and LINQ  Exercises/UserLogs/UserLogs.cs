namespace UserLogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class UserLogs
    {
        static void Main(string[] args)
        {
            char[] separator = { ' ', '=' };
            string input = Console.ReadLine();

            List<string> IPs = new List<string>();
            
            SortedDictionary<string, Dictionary<string, int>> UserIp = new SortedDictionary<string, Dictionary<string, int>>();

            while (!input.Equals("end"))
            {
                List<string> inputStr = input
                    .Split(separator)
                    .ToList();

                string IP = inputStr[1];
                string message = inputStr[3];
                string user = inputStr[5];
                
                Dictionary<string, int> IpCount = new Dictionary<string, int>(); 
                
                if (!UserIp.ContainsKey(user)) 
                {

                    IpCount[IP] = 1;      
                    UserIp.Add(user, IpCount);
                }
                else   
                {
                    if (!UserIp[user].ContainsKey(IP))
                    {

                        IpCount = UserIp[user];   
                        IpCount[IP] = 1;          
                        UserIp[user] = IpCount; 
                    }
                    else  
                    {
                        IpCount = UserIp[user];
                        if (IpCount.ContainsKey(IP))
                        {
                            IpCount[IP]++;
                            UserIp[user] = IpCount;
                        }
                    }
                }

                input = Console.ReadLine();
            }
            
            PrintResult(UserIp);
        }
        
        private static void PrintResult(SortedDictionary<string, Dictionary<string, int>> UserIp)
        {
            foreach (var user in UserIp)
            {
                string userName = user.Key;
                
                Dictionary<string, int> IPCount2 = UserIp[user.Key];

                Console.WriteLine("{0}: ", userName);
                
                int counter = 0;
                List<string> allUserIpsAndCountsToList = new List<string>(); 
                foreach (var  item in IPCount2)
                {
                    List<string> allUserIps = UserIp[user.Key].Keys.ToList();
                    List<int> allUserIpsCount = UserIp[user.Key].Values.ToList();
                    string allUserIpsAndCounts = allUserIps[counter] + " => " + allUserIpsCount[counter];
                    allUserIpsAndCountsToList.Add(allUserIpsAndCounts);
                    counter++;              
                }
                Console.WriteLine("{0}.", string.Join(", ", allUserIpsAndCountsToList));

            }  
        }
    }
}