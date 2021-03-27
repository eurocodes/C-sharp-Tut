using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Examples_Day1
{
    class SwitchCase
    {
        static void Main()
        {
            string number = "two";

            switch (number)
            {
                case "zero":
                    Console.WriteLine("Value is 0");
                    break;
                case "one":
                    Console.WriteLine("Value is 1");
                    break;
                case "two":
                    Console.WriteLine("Value is 2");
                    break;
                case "three":
                    Console.WriteLine("Value is 3");
                    break;
                default:
                    Console.WriteLine("Value not in case");
                    break;
            }

            Console.ReadKey();
        }
    }
}
