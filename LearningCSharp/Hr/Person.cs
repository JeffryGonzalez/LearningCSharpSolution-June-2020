namespace LearningCSharp.Hr
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

    //public class SuperSneakyEncryptor : Encryptor
    //{

    //}
}
