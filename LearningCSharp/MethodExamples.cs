using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningCSharp
{
    public class MethodExamples
    {
        public string FormatName(string first, string last)
        {
            return $"{last}, {first}";
        }

        public string FormatName(string first, string last, string mi)
        {
            //var fullName = string.Format("{0}, {1} {2}.", last, first, mi);
            //return fullName;
            //var fullName = string.Format("Hello {0} {1} {2}", "Bob", "How Are you", "Tacos")
            return $"{FormatName(first, last)} {mi}.";
        }

        public int Add(int a = 2, int b = 10)
        {
            return a + b;
        }

        public int Add(int a, int b, params int[] rest)
        {
            //int sum = a + b;
            //foreach(var num in rest) {
            //    sum += num;
            //}
            //return sum;
            //return a + b + rest.Aggregate((s, n) => s + n);
            return a + b + rest.Sum();
        }
    }
}
