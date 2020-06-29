using System;

namespace LearningCSharp.Hr
{
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

    //public class SuperSneakyEncryptor : Encryptor
    //{

    //}
}
