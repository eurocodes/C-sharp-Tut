using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Example_Day2
{
    class TestEmployee
    {
        static void Main()
        {
            Employee alex = new Employee();
            Employee linda = new Employee();

            alex.salary = 90000;
            alex.bonus = 20000;
            double alexTotalPay = alex.CalculateTotalPay();
            Console.WriteLine("Alex Total Pay is {0}", alexTotalPay);

            linda.salary = 10000;
            linda.bonus = 20000;
            double lindaTotalPay = linda.CalculateTotalPay();
            Console.WriteLine("Linda Total Pay is {0}", lindaTotalPay);

            Console.ReadKey();
        }
    }
}
