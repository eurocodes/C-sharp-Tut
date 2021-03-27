using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Constructor_Day2
{
    class TestSmallBox
    {
        static void Main()
        {
            SmallBox fedEx1 = new SmallBox();
            // fedEx1.length = 6;
            // fedEx1.width = 5;
            fedEx1.CalculatorArea();

            SmallBox fedEx2 = new SmallBox();
            fedEx2.length = 8;
            fedEx2.width = 4;
            fedEx2.CalculatorArea();

            Console.ReadKey();
        }
    }
}
