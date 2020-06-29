namespace LearningCSharp.Hr
{
    public class PartTimeContractor : Contractor
    {
        public override string GetInfo()
        {
            return $"{FirstName} {LastName} is a PartTime contractor with an Hourly Rate of  {HourlyRate:c}";
        }
    }

    //public class SuperSneakyEncryptor : Encryptor
    //{

    //}
}
