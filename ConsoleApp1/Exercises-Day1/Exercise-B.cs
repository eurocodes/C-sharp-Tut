using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Exercises_Day1
{
    class Exercise_B
    {
        static void Main()
        {
            string[] numArr = { "3.45", "3.87", "87.98", "56.7" };

            double total = 0.0;

            foreach (string item in numArr)
            {
                total += Convert.ToDouble(item);
            }

            Console.WriteLine("Sum of Array is {0}", total);
        }
    }
}
