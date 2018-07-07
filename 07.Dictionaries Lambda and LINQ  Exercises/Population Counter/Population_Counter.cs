using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class UserLogs
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, long>> populations = new Dictionary<string, Dictionary<string, long>>();

        string input = Console.ReadLine();
        while (!input.Equals( "report"))
        {
            List<string> data = input.Split('|').ToList(); 
            string city = data[0];     
            string country = data[1];
            long population = long.Parse(data[2]);

            Dictionary<string, long> cityPopulation = new Dictionary<string, long>();   


            if (!populations.ContainsKey(country))  
            {

                cityPopulation[city] = population; 

                populations[country] = cityPopulation; 
            }
            else     
            {

                cityPopulation = populations[country]; 
                if (cityPopulation.ContainsKey(city))  
                    cityPopulation[city] += population;        
                else                                      
                    cityPopulation.Add(city, population);


                populations[country] = cityPopulation;   
            }

            input = Console.ReadLine();
        }

        foreach (var state in populations.OrderByDescending(x => x.Value.Sum(y => y.Value))) 
        {
            List<long> cities = state.Value.Select(x => x.Value).ToList();
            long totalPolulation = cities.Sum();
            Console.WriteLine($"{state.Key} (total population: {totalPolulation})");

            Console.Write($"=>{string.Join("=>", state.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value}\r\n"))}");
        }
    }
}

