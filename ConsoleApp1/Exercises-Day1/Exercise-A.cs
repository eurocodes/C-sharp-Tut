﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Exercises_Day1
{
    class Exercise_A
    {
        static void Main()
        {
            Console.WriteLine("Please enter salary");
            string input = Console.ReadLine();
            double salary = Convert.ToDouble(input);
            double tax;

            if (salary <= 8350)
            {
                tax = 8350 * .10;
            }
            else if (salary <= 33950)
            {
                tax = (8350 * .10) + ((salary - 8350) * .15);
            }
            else
            {
                tax = (8350 * .10) + ((salary - 8350) * .15) + ((salary - 33950) * .25);
            }

            Console.WriteLine("Tax payable is {0}", tax);
        }
    }
}
