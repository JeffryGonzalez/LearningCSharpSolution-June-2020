using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Hr
{

    public class Employee : Person
    {


        public decimal Salary { get; private set; } = 50000;

        public override string GetInfo()
        {
            if (IsHighlyCompensated())
            {
                return $"{FirstName} {LastName} is a highly paid employee with a salary of {Salary:c}";

            }
            else
            {
                return $"{FirstName} {LastName} is an employee with a salary of {Salary:c}";
            }

            bool IsHighlyCompensated()
            {
                return Salary > 10000;
            }
        }

        public void GiveRaise(decimal amount)
        {
            if (amount > 5000)
            {
                throw new ArgumentException("That is too darned high! Get approval first");
            }
            Salary += amount;
        }
    }

   
}
