﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //convert centuries into years days, hours and minutes

            Console.Write("Centuries = ");
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24; 
            int minutes = hours * 60;
            
              
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes ",
            centuries, years, days, hours, minutes);

        }
    }
}
