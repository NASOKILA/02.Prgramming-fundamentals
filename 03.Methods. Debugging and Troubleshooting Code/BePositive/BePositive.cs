using System;
using System.Collections.Generic;

public class BePositive_broken
{
    public static void Main()
    {
        byte countSequences = byte.Parse(Console.ReadLine());

        if (countSequences > 0 && countSequences <= 15)
        {

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');

                var numbers = new List<short>();

                for (int j = 0; j < input.Length; j++)
                {
                    if (!input[j].Equals(string.Empty))
                    {
                        short num = short.Parse(input[j]); 

                        if (num < -1000 || num > 1000) { break; }
                        numbers.Add(num); 
                    }
                }

                if (numbers.Count < 1 || numbers.Count > 20) { break; }
                else
                {

                    bool found = false;

                    for (int j = 0; j < numbers.Count; j++) 
                    {

                        int currentNum = numbers[j];

                        if (currentNum >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            if (j == numbers.Count - 1) { Console.WriteLine(currentNum); }
                            else { Console.Write(currentNum); }

                            found = true;
                        }
                        else
                        {
                            currentNum += numbers[j + 1]; 
                                                          
                            if (currentNum >= 0)
                            {
                                if (found)
                                {
                                    Console.Write(" ");
                                }

                                if (j == numbers.Count - 1) { Console.WriteLine(currentNum); } 
                                else { Console.Write(currentNum);
                                } 

                                found = true;
                            }
                            j++; 
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("(empty)");
                    }

                }

            }  

        } 
    }
}