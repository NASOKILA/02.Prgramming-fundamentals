namespace Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Events
    {
        static void Main(string[] args)
        {
            var events = new SortedDictionary<DateTime, string>();

            events[new DateTime(1998, 9, 4)] = "Google's birthday.";
            events[new DateTime(2014, 11, 5)] = "SoftUni's birthday.";
            events[new DateTime(1975, 4, 4)] = "Microsoft's birthday.";
            events[new DateTime(2004, 2, 4)] = "Facebook's birthday.";
            events[new DateTime(2014, 11, 5)] = "SoftUni was found.";

            foreach (var item in events)
            {
                Console.WriteLine("{0: dd-MM-yyyy}: {1}", item.Key, item.Value);
            }
        }
    }
}
