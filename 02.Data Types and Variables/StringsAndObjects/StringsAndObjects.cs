using System;


namespace StringsAndObjects
{
   public class StringsAndObjects
    {
       public static void Main(string[] args)  
        {

            string stringOne = "Hello";
            string stringTwo = "World";
            object objOne = stringOne + " " + stringTwo; 
            string result = (string)objOne;   
            Console.WriteLine(result);

        }
    }
}
