namespace LearningCSharp.Hr
{
    public class FullTimeContractor : Contractor
    {
        public override string GetInfo()
        {
            return $"{FirstName} {LastName} is a FullTime contractor with an Hourly Rate of  {HourlyRate:c}";
        }
    }

    //public class SuperSneakyEncryptor : Encryptor
    //{

    //}
}
