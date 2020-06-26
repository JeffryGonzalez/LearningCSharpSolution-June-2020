using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace LearningCSharp
{
    public class VariousOopStuff 
    {

        private ITestOutputHelper _output;

        public VariousOopStuff(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void MakingARetiree()
        {
            var earl = new Retiree()
            {
                FirstName = "Earl",
                LastName = "Jones"
            };

            Assert.Equal("Earl", earl.FirstName);
            Assert.Equal("Jones", earl.LastName);
            Assert.Equal(38000M, earl.Pension);

            // var jay = new Person();

            var sue = new Employee()
            {
                FirstName = "Sue",
                LastName = "Smith"
            };
            

            var folks = new List<Person>
            {
                earl, sue
            };

            foreach(var p in folks)
            {
                _output.WriteLine(p.GetInfo());
            }


        }
    }
}

