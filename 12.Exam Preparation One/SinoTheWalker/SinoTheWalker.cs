namespace SinoTheWalker
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SinoTheWalker
    {
        static void Main(string[] args)
        {
         
            DateTime startTime = DateTime.ParseExact(
                Console.ReadLine(),
                "HH:mm:ss",
                CultureInfo.InvariantCulture);

            int numberOfSteps = int.Parse(Console.ReadLine());
            int secondsPerStep = int.Parse(Console.ReadLine());
            long initialSeconds = startTime.Hour*60*60
                +startTime.Minute*60 + startTime.Second;


            ulong secondsToAdd = (ulong)numberOfSteps * (ulong)secondsPerStep;
            ulong totalSeconds = (ulong)initialSeconds + secondsToAdd;
            var seconds = totalSeconds % 60;
            var totalMinutes = totalSeconds / 60;
            var minutes = totalMinutes % 60;
            var totalHours = totalMinutes / 60;
            var hours = totalHours % 24;
            
            Console.WriteLine($"Time Arrival: {hours:00}:{minutes:00}:{seconds:00}");
        }
    }
}
