using LearningCSharp.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;

namespace LearningCSharp
{
    public class ExtensionMethods
    {
        [Fact]
        public void UsingThem()
        {
           
            int x = 13;
            //if (Utils.IsEven(x))
            
            if(x.IsEven())
            {
                // it is even
            }
            else
            {
                // it is not even
            }

            var monday = 3.DaysFromToday();

            string message = "Hello!";
            Assert.Equal(2, message.CountVowels());
        }

      
    }
}
