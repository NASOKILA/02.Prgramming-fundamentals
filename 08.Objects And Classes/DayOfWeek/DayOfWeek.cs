namespace DayOfWeek
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;
    using System.Threading.Tasks;

    class DayOfWeek
    {
        static void Main(string[] args)
        {
            var dateAsString = Console.ReadLine();

            var date = DateTime.ParseExact(
                dateAsString,
                "d-M-yyyy",  
                CultureInfo.InvariantCulture 
                );

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
