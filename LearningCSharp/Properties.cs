using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class Properties
    {
        [Fact]
        public void AssigningDataToAnObject()
        {
            var emp = new Employee();

            emp.FirstName = "Robert";

            Assert.Equal("Robert", emp.FirstName);
            Assert.Equal(50000, emp.Salary);

            emp.GiveRaise(5000);
            Assert.Equal(55000, emp.Salary);
        }

        [Fact]
        public void UsingObjectInitializers()
        {
            var sue = new Employee();
            sue.FirstName = "Susan";
            sue.LastName = "Smith";
           // sue.Salary = 90;

            var sean = new Employee
            {
                FirstName = "Sean",
                LastName = "Carlin"
            };


        }

        [Fact]
        public void UsingAnIndexer()
        {
            var indexer = new Indexable();

            Assert.Equal(1, indexer["first"]);
            Assert.Equal(3, indexer["third"]);
            Assert.Throws<IndexOutOfRangeException>(
                () => indexer["tenth"]
                );
        }

        [Fact]
        public void MyStuff()
        {
            var things = new BoxOfThings<string>();
            things[0] = "Bread";
            things[1] = "Milk";
            things[2] = "Shampoo";
            // etc. etc.

            Assert.Equal("Milk", things[1]);

            var favoriteNumbers = new BoxOfThings<int>();
            favoriteNumbers[0] = 9;
            favoriteNumbers[1] = 20;

            var answer = favoriteNumbers[0] + favoriteNumbers[1];

            
        }

        [Fact]
        public void SwappingVariableValues()
        {
            //var helpers = new Helpers();
            
            int x = 10;
            int y = 20;
            Helpers.Swap<int>(ref x, ref y);
            Assert.Equal(20, x);
            Assert.Equal(10, y);

            string f1 = "David";
            string f2 = "Sarah";

            Helpers.Swap<string>(ref f1, ref f2);

            Assert.Equal("Sarah", f1);
            Assert.Equal("David", f2);
        }

       


    }
}
