﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class LeapYear
    {
        public static void leapYear()
        {
             int y;
             Console.WriteLine("Enter the Year in Four Digits : ");
                y = Convert.ToInt32(Console.ReadLine());
               if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
                {
                    Console.WriteLine("{0} is a Leap Year", y);
                }
                else
                {
                    Console.WriteLine("{0} is not a Leap Year", y);
                }
                Console.ReadLine();
            }
            

        }
}
