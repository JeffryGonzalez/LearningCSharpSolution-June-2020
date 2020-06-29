using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class BuiltInDelegateTypes
    {
        [Fact]
        public void TheActionDelegateType()
        {
            // an action can refer to a void method that takes zero-sixteen arguments.

            Action doIt = () => Console.Write("Doing it");
            doIt();

            Action<string, int> doItWithParams = (string name, int numberOftimes) =>
             {
                 for (var t = 0; t < numberOftimes; t++)
                 {
                     Console.WriteLine(name);
                 }
             };

            doItWithParams = SomeOtherMethod;

            doItWithParams("Red", 5);

        }

        [Fact]
        public void Predicates()
        {
            // a predicate is a function that returns a bool and takes a single argument

            Predicate<string> likesPizzaTopping = (topping) =>
            {
                return topping == "cheese";
            };

            Assert.True(likesPizzaTopping("cheese"));
            Assert.False(likesPizzaTopping("anything else"));
        }

        [Fact]
        public void GettingFuncy()
        {
            Func<int, int, int> mathOp;

            mathOp = (a, b) => a + b;
            Assert.Equal(12, mathOp(10, 2));

            mathOp = (a, b) => a - b;

            Assert.Equal(8, mathOp(10, 2));

            Func<int, int, string> concatenateNumbersAsString = (a, b) => a.ToString() + b.ToString();

            Assert.Equal("105", concatenateNumbersAsString(10, 5));

            var friends = new List<string> { "David", "Tim", "Sue", "Billy" };

            var shortNamedFriends = friends.Where(n => n.Length <= 3).ToList();

            Assert.Equal("Tim", shortNamedFriends[0]);
            Assert.Equal("Sue", shortNamedFriends[1]);
        }


        public void SomeOtherMethod(string color, int size)
        {
            // do something...
        }
    }
}
