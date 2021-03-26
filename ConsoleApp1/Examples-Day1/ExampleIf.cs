using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Examples_Day1
{
    class ExampleIf
    {
        static void Main()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine("Yey!! It's a {0}", DateTime.Now.DayOfWeek);
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
            {
                Console.WriteLine("Yey!! It's a {0}", DateTime.Now.DayOfWeek);
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                Console.WriteLine("Yey!! It's a {0}", DateTime.Now.DayOfWeek);
            }
            else
            {
                Console.WriteLine("Its {0}", DateTime.Now.DayOfWeek);
            }

            Console.ReadKey();
        }
    }
}
