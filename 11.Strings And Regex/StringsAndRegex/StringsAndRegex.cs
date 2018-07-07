namespace StringsAndRegex
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class StringsAndRegex
    {
        static void Main(string[] args)
        {
            string str2 = "angel";
            string str1 = "Angel";

            int resultCaseInsensative = string.Compare(str1, str2, true);
            Console.WriteLine(resultCaseInsensative);

            int resultCaseSensative = string.Compare(str1, str2, false);
            Console.WriteLine(resultCaseSensative);

            Console.WriteLine(str1 == str2);

            Console.WriteLine(str1.Equals(str2));


            string aa = "Naso";

            string bb = "naso";

            Console.WriteLine(aa == bb);

            Console.WriteLine(); Console.WriteLine();

            string a = "a";
            string b = "b";
            string c = string.Concat(a, b);
            Console.WriteLine(c);

            string d = a + b;
            Console.WriteLine(d);

            Console.WriteLine(); Console.WriteLine();

            string name = "Atanas";
            int age = 24;
            string nameAge = name + " " + age;
            Console.WriteLine(nameAge);

            string nameAge2 = string.Concat(name, " ", age);
            Console.WriteLine(nameAge2);


            string email = "atanasskambitovv@gmail.com";
            int pos1 = email.IndexOf("t");
            int pos2 = email.IndexOf("k");
            int positionOfSeveralLetters = email.IndexOf("nas");
            int nonExistingLetter = email.IndexOf("j");

            Console.WriteLine(pos1);
            Console.WriteLine(pos2);
            Console.WriteLine(positionOfSeveralLetters);
            Console.WriteLine(nonExistingLetter);

            int LastEqualLetter = email.LastIndexOf("o");
            Console.WriteLine(LastEqualLetter);

            Console.WriteLine(); Console.WriteLine();
            string fullName = "Atanas Kambitov";

            string firstName = fullName.Substring(0, 6);
            Console.WriteLine(firstName);

            string lastName = fullName.Substring(7);
            Console.WriteLine(lastName);

            Console.WriteLine(); Console.WriteLine();

            string listOfCars = "Ford, Reno, BMW, Mercedes.";
            string[] cars = listOfCars.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine(); Console.WriteLine();

            string cocktail = "Vodka + Martini + Cherry";
            string replaced = cocktail.Replace("+", "and");
            Console.WriteLine(replaced);

            Console.WriteLine(); Console.WriteLine();

            string price = "1234567 $";
            string newPrice = price.Remove(2, 3);
            Console.WriteLine(newPrice);


            Console.WriteLine(); Console.WriteLine();
            string s = "     nasokila    ";
            s = s.Trim();
            Console.WriteLine(s);

            string n = "  /!,.?Nasokila..,!!  ";
            n = n.Trim(' ', '?', '/', '.', ',', '!');
            Console.WriteLine(n);

            string AA = "     C#     ";
            AA = AA.TrimEnd();
            Console.WriteLine(AA);
        }
    }
}




