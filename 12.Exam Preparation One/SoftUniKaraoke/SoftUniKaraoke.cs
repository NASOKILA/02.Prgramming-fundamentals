namespace SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SoftUniKaraoke
    {
        static void Main(string[] args)
        {
         
            List<string> partecipants = Console.ReadLine().Split(new char[] {',',' '},
                StringSplitOptions.RemoveEmptyEntries).ToList();


            List<string> allSongs = Console.ReadLine().Split(new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries).Select(p => p.Trim()).ToList();

           
            Dictionary<string, List<string> > SingerAndRewards 
                = new Dictionary<string, List<string>>();
                

            string command = Console.ReadLine();
            while (!command.Equals("dawn"))
            {

                string[] commandArr = command.Split(new char[] {','},StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => p.Trim()).ToArray();

                string singer = commandArr[0]; 
                string song = commandArr[1];
                string reward = commandArr[2]; 

                if (partecipants.Contains(singer) && allSongs.Contains(song)) 
                {
                    List<string> Rewards = new List<string>();


                    if (!SingerAndRewards.Keys.Contains(singer))
                    {
                        Rewards.Add(reward); 
                        SingerAndRewards[singer] = Rewards; 
                    }
                    else
                    {

                        if (!SingerAndRewards[singer].Contains(reward))  
                        {

                            foreach (var rewardd in SingerAndRewards[singer])
                            {
                                Rewards.Add(rewardd);  
                            }

                            Rewards.Add(reward); 
     
                            SingerAndRewards[singer] = Rewards;
                        }                       
                    }
                }

                
                command = Console.ReadLine();
            }

            
            foreach (var singeer in SingerAndRewards
                .OrderByDescending(r => r.Value.Count)
                .ThenBy(p => p.Key))
            {
                var awards = singeer.Value;
                var partecipant = singeer.Key;
                Console.WriteLine($"{partecipant}: {awards.Count} awards");
                foreach (var award in singeer.Value.OrderBy(a => a))
                {
                    Console.WriteLine($"--{award}");
                }
            }

            if(!SingerAndRewards.Any())   
                Console.WriteLine("No awards");
            
        }
    }
}
