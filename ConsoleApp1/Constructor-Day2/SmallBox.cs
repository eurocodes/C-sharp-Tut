using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Constructor_Day2
{
    class SmallBox
    {
        public int length;
        public int width;

        public SmallBox()
        {
            length = 6;
            width = 5;
            Console.WriteLine("Constructor fired");
        }

        public void CalculatorArea()
        {
            Console.WriteLine("Area is " + (length * width));
        }
    }
}
