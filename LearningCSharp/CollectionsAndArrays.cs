using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class CollectionsAndArrays
    {
        [Fact] // Note this was to show you what NOT to do.
        public void UsingAnOldSkoolArrayList()
        {
            var favoriteNumbers = new ArrayList();
            favoriteNumbers.Add(9);
            favoriteNumbers.Add(20);
            favoriteNumbers.Add(42);
            favoriteNumbers.Add(108);

            Assert.Equal(9, favoriteNumbers[0]);
            Assert.Equal(108, favoriteNumbers[3]);
            favoriteNumbers[0] = 10;
            Assert.Equal(10, favoriteNumbers[0]);

            Assert.Throws<ArgumentOutOfRangeException>(
                () => favoriteNumbers[99]);


            favoriteNumbers.Add("Tacos");
            //favoriteNumbers[0] = "three";
            var firstTwo = (int) favoriteNumbers[0] 
                + (int) favoriteNumbers[1];
            Assert.Equal(30, firstTwo);
        }

        [Fact]
        public void UsingAGenericList()
        {
            // List of int - generics provide parametric polymorphism.
            var favoriteNumbers = new List<int>();
            favoriteNumbers.Add(9);
            favoriteNumbers.Add(10);

            var firstTwo = favoriteNumbers[0] + favoriteNumbers[1];
            Assert.Equal(19, firstTwo);
            favoriteNumbers.Add(9);
            favoriteNumbers.Add(10);
            Assert.Equal(19, firstTwo);

        }

        [Fact]
        public void InitializingAndEnumeratingAList()
        {

        }
    }
}
