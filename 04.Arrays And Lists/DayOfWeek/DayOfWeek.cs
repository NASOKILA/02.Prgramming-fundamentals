using System;

namespace DayOfWeek
{
    public class DayOfWeek
    {
        public static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());            
            string[] daysOfTheWeek = new string[7]; 
            SetDaysOfWeek(daysOfTheWeek); 

            PrintDaysOfWeek(day, daysOfTheWeek); 
        }

        public static void SetDaysOfWeek(string[] daysOfWeek) {
            daysOfWeek[0] = "Monday";
            daysOfWeek[1] = "Tuesday";
            daysOfWeek[2] = "Wednesday";
            daysOfWeek[3] = "Thursday";
            daysOfWeek[4] = "Friday";
            daysOfWeek[5] = "Saturday";
            daysOfWeek[6] = "Sunday";
        }

        public static void PrintDaysOfWeek(int day, string[] daysOfTheWeek ) {

            SetDaysOfWeek(daysOfTheWeek);    

            if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5 || day == 6 || day == 7)
            {
                day--; 
                Console.WriteLine(daysOfTheWeek[day]);  
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
