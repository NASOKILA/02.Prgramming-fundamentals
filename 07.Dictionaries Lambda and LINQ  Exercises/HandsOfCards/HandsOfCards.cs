namespace HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class HandsOfCards
    {
        private static void PrintPlayersScores(Dictionary<string, List<string>> PlayerCards)
        {
            foreach (var playerEntry in PlayerCards)
            {
                string playerName = playerEntry.Key;

                List<string> cards = playerEntry.Value.Distinct().ToList();

                int playerScore = 0;
                foreach (var card in cards)
                {
                    string rank = card.Substring(0, card.Length - 1);

                    string suite = card.Substring(card.Length - 1);

                    int rankPower = GetRank(rank);
                    int suitePower = GetSuite(suite);

                    playerScore = playerScore + (rankPower * suitePower);
                }

                Console.WriteLine("{0}: {1}", playerName, playerScore);
            }
        }

        private static int GetSuite(string suite)
        {
            switch (suite)
            {
                case "S":
                    return 4;
                case "H":
                    return 3;
                case "D":
                    return 2;
                case "C":
                    return 1;
                default:
                    return 1;
            }
        }


        private static int GetRank(string rank)
        {
            switch (rank)
            {

                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                case "7":
                    return 7;
                case "8":
                    return 8;
                case "9":
                    return 9;
                case "10":
                    return 10;
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return 1;

            }
        }


        static void Main(string[] args)
        {

            Dictionary<string, List<string>> PlayerCards
                = new Dictionary<string, List<string>>();

            string commandLine = Console.ReadLine();
            char[] separator = { ' ', ',', ':' };

            while (!commandLine.Equals("JOKER"))
            {
                string[] cards = commandLine.Split(separator);
                string player = cards[0];

                cards = cards
                    .Where(n => n != cards[0])
                    .Where(x => x != "")
                    .ToArray();


                if (!PlayerCards.ContainsKey(player))
                {
                    PlayerCards.Add(player, new List<string>());
                }

                PlayerCards[player].AddRange(cards);

                commandLine = Console.ReadLine();
            };

            PrintPlayersScores(PlayerCards);
        }
    }
}
