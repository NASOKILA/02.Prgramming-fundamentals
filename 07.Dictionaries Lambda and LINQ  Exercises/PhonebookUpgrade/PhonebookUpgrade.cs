using System;
using System.Collections.Generic;
using System.Linq;


namespace PhonebookUpgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            String commandLine = Console.ReadLine();

            Dictionary<string, string> phonebook =
                new Dictionary<string, string>();

            while (!commandLine.Equals("END"))
            {
                string[] commandArgs = commandLine.Split(' ');
                string command = commandArgs[0];

                if (command.Equals("A"))
                {
                    string name = commandArgs[1];
                    string number = commandArgs[2];

                    phonebook[name] = number;

                }
                else if (command.Equals("S"))
                {
                    string name = commandArgs[1];

                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine("{0} -> {1}", name, phonebook[name]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", name);
                    }
                }
                else if (command.Equals("ListAll"))
                {
                    var orderedPhonebook = phonebook.OrderBy(x => x.Key);

                    foreach (var pair in orderedPhonebook)
                    {
                        Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
                    }
                }

                commandLine = Console.ReadLine();
            }
        }
    }
}
