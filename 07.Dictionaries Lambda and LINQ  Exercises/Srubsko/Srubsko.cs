namespace Srubsko
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Srubsko
    {
        static void Main(string[] args)
        {


            Dictionary<string, Dictionary<string, long>> VenueSingherAndTotalMoneyMade = new Dictionary<string, Dictionary<string, long>>();  // golemiq rechnik
            Dictionary<string, long> SingherAndTotalMoneyMade = new Dictionary<string, long>();
            
            string input = Console.ReadLine();


            while (!input.Equals("End"))
            {
                char[] skipInvalidInput = input.ToCharArray();    
                List<char> skipInvalidInputList = skipInvalidInput.ToList();
                

                if ((input.Split(' ').ToArray().Length <= 3))
                    input = Console.ReadLine();
                else
                {
                    List<string> singer = new List<string>();
                    List<long> totalPrice = new List<long>();
                    List<string> venue = new List<string>();
                    GetSingerTotalPriceVenue(input, venue, singer, totalPrice);

                 
                    SortDictionaries(VenueSingherAndTotalMoneyMade, SingherAndTotalMoneyMade, singer[0], totalPrice[0], venue[0]);


                    SingherAndTotalMoneyMade = new Dictionary<string, long>();  


                    input = Console.ReadLine();
                }

            }

            
            PrintResult(VenueSingherAndTotalMoneyMade);
        }

        private static void GetSingerTotalPriceVenue(string input, List<string> venue, List<string> singer, List<long> totalPrice)
        {
            List<string> input2 = input.Split('@').ToList();

            singer.Add(input2.First().Trim());
            input2.Remove(input2[0]);
            List<string> input3 = input2[0].Split(' ').ToList();

            int ticketsCount = int.Parse(input3.Last());
            input3.Remove(input3.Last());

            byte ticketsPrice = byte.Parse(input3.Last());
            input3.Remove(input3.Last());

            totalPrice.Add(ticketsPrice * ticketsCount);
            
            if (input3.Count.Equals(2))
                venue.Add(input3[0] + " " + input3[1]);
            else
                venue.Add(input3[0]);
        }

        private static void SortDictionaries(Dictionary<string, Dictionary<string, long>> VenueSingherAndTotalMoneyMade,
            Dictionary<string, long> SingherAndTotalMoneyMade, string singer, long totalPrice, string venue)
        {
            if (!VenueSingherAndTotalMoneyMade.ContainsKey(venue)) 
            {
                SingherAndTotalMoneyMade[singer] = totalPrice;
                VenueSingherAndTotalMoneyMade.Add(venue, SingherAndTotalMoneyMade);
            }
            else
            {
                if (!VenueSingherAndTotalMoneyMade[venue].ContainsKey(singer))   
                {
                    SingherAndTotalMoneyMade = VenueSingherAndTotalMoneyMade[venue];
                    SingherAndTotalMoneyMade.Add(singer, totalPrice);
                    VenueSingherAndTotalMoneyMade[venue] = SingherAndTotalMoneyMade;        
                }
                else
                {
                    SingherAndTotalMoneyMade = VenueSingherAndTotalMoneyMade[venue];
                    if (SingherAndTotalMoneyMade.ContainsKey(singer))
                    {
                        SingherAndTotalMoneyMade[singer] += totalPrice;      
                    }
                }
                
            }
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, long>> venueSingherAndTotalMoneyMade)
        {
            foreach (var venue in venueSingherAndTotalMoneyMade)    
            {
                Console.WriteLine("{0}", venue.Key);

                foreach (var singer in venue.Value.OrderByDescending(x => x.Value))          
                {
                    Console.WriteLine("#  {0} -> {1}", singer.Key.Trim(), singer.Value); 
                }
            }
        }
    }
}
