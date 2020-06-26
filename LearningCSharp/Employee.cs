using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp
{
    public abstract class Person
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName { get; set; }

        // in VM the keyword for abstract is MustOverride
        public abstract string GetInfo();

        // in VB the keyword virtual is "Overridable"
        public virtual void DoSomething()
        {
            // default implementaion.
        }
    }

    public abstract class Contractor : Person
    {
        public decimal HourlyRate { get; set; }

    }
    public class FullTimeContractor : Contractor
    {
        public override string GetInfo()
        {
            return $"{FirstName} {LastName} is a FullTime contractor with an Hourly Rate of  {HourlyRate:c}";
        }
    }

    public class PartTimeContractor : Contractor
    {
        public override string GetInfo()
        {
            return $"{FirstName} {LastName} is a PartTime contractor with an Hourly Rate of  {HourlyRate:c}";
        }
    }

    public class Employee : Person
    {
      

        public decimal Salary { get;  private set; } = 50000;

        public override string GetInfo()
        {
            return $"{FirstName} {LastName} is an employee with a salary of {Salary:c}";
        }

        public void GiveRaise(decimal amount)
        { 
            if(amount > 5000)
            {
                throw new ArgumentException("That is too darned high! Get approval first");
            }
            Salary += amount;
        }
    }

    public class Retiree : Person
    {
        public decimal Pension { get; private set; } = 38000;

        public override string GetInfo()
        {
            return $"{FirstName} {LastName} is an retiree with a pension of {Pension:c}";
        }

        public override void DoSomething()
        {
            throw new ArgumentOutOfRangeException("I'm retired you jerk!");
        }
    }

    public sealed class Encryptor
    {
        public bool IsGoodPassword(string password)
        {
            return password == "super_secret"; // put your super encrypted code here.
        }
    }

    //public class SuperSneakyEncryptor : Encryptor
    //{

    //}
}
