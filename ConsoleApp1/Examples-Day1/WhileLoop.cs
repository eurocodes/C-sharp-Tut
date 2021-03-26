using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Examples_Day1
{
    class WhileLoop
    {
        static void Main()
        {
            int num = 10;

            /*
            while (num >= 0)
            {
                Console.WriteLine("number = " + num);
                num--;
            }
            */

            // Do while Loop
            do
            {
                Console.WriteLine("Number = " + num);
                num--;
            } while (num > 0);

            // For Each Loop

            int[] arr = { 10, 30, 90, 76, 100 };

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
    {

            }
        }
    }
}
