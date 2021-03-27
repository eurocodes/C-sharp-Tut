using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day_2_Encapsulation
{
    class Employee
    {
        private double salary;
        private double bonus;

        public void SetSalary(double salary)
        {
            if(salary < 40000 || salary > 150000)
            {
                Console.WriteLine("Please check salary");
                this.salary = 0;
                this.bonus = 0;
            }
            else
            {
                this.salary = salary;
                this.bonus = .20 * salary;
            }
        }

        public double CalculateTotalPay()
        {
            double totalPay = salary + bonus;
            Console.WriteLine("Total Pay = " + totalPay);
            return totalPay;
        }
    }
}
