﻿using System;
using System.Numerics;

namespace Factorial
{
   public class Factorial
    {
        public static void PrintFactoriel(short n) {

            BigInteger fact = 1;
            BigInteger counter = 1;
            do
            {
                fact = fact * counter;
                counter++;

            } while (counter <= n);

            Console.WriteLine(fact);
        }
        
        public static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());
            
            PrintFactoriel(n);
        }
    }
}
