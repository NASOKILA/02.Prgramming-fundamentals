namespace FixMails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class FixMails
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            var dict = new Dictionary<string, string>();

            while (!name.Equals("stop"))
            {
                string email = Console.ReadLine();

                dict[name] = email;

                string[] value = dict[name].Split('.');

                if (value[1] == "uk" || value[1] == "us")
                {
                    dict.Remove(name);
                }

                name = Console.ReadLine();
            }

            foreach (var pair in dict)
            {
                Console.WriteLine("{0} -> {1}",pair.Key, pair.Value);
            }
        }
    }
}
