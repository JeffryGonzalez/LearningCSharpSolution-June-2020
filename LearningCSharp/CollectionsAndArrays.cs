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
           // favoriteNumbers.Add("tacos");

            var firstTwo = favoriteNumbers[0] + favoriteNumbers[1];
            Assert.Equal(19, firstTwo);
            favoriteNumbers.Add(9);
            favoriteNumbers.Add(10);
            Assert.Equal(19, firstTwo);

        }

        [Fact]
        public void InitializingAndEnumeratingAList()
        {
            var friends = new List<string>
            {
                "Sean",
                "Amy",
                "Jessika",
                "Tim"
            };

            Assert.Equal("Sean", friends[0]);

            var friendString = "";
            foreach(string friend in friends)
            {
                friendString += friend;
            }
            Assert.Equal("SeanAmyJessikaTim", friendString);
        }

        [Fact]
        public void UsingADictionary()
        {
            var friends = new Dictionary<char, string>();
            friends.Add('s', "Sean");
            friends.Add('d', "David");
            friends.Add('b', "Sean");

            Assert.Equal("David", friends['d']);


        }

        [Fact]
        public void InitializingAndEnumeratingADictionary()
        {
            var friends = new Dictionary<char, string>
            {
                { 's', "Sean" },
                { 'd', "David" },
                { 'b', "Sean" }
            };

            Assert.Equal("David", friends['d']);

            Assert.True(friends.ContainsKey('d'));
            Assert.False(friends.ContainsValue("Billy"));

            // enumerating just the keys
            foreach(char c in friends.Keys)
            {
                // you have the key here... 's', 'd', 'b'
            }

            foreach(string f in friends.Values)
            {
                // you have the values here... "Sean", "David", "Sean"
            }

            foreach(KeyValuePair<char, string> kvp in friends)
            {
                // you have the keyvalue pair 
                // kvp.Key = 's', 'd', 'b'
                // kvp.Value = "Sean", "David", "Sean"
            }
        }

        [Fact]
        public void ArraysAreCoolButLimited()
        {
            string[] friends = new string[] { "Joe", "Bill", "Sue", "Mary" };
            Assert.Equal("Joe", friends[0]);

            // but you can't add elements to the array. This array will _always_
            // have four elements in it.

            var luckyNumbers = new int[3];
            luckyNumbers[0] = 9;
            luckyNumbers[1] = 20;
            luckyNumbers[2] = 108;
            // luckyNumbers[3] = 99;

        }
    }
}
