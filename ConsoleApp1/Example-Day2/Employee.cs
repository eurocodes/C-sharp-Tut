using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Example_Day2
{
    class Employee
    {
        public double salary;
        public double bonus;

        public double CalculateTotalPay()
        {
            double totalPay = salary + bonus;
            return totalPay;
        }
    }
}
