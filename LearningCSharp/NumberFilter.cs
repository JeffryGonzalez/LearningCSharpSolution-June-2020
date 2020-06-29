using LearningCSharp.Utilities;
using System;
using System.Collections.Generic;

namespace LearningCSharp
{
    // Ask C# Compiler to create a class that extends System.MultiCastDelegate
    // that can refer to any method that takes and int and returns a bool
    public delegate bool FilterMethod(int num);
    public delegate int MathOp(int a, int b);

    public class NumberFilter
    {
        public List<int> FilterOutEvens(List<int> numbers)
        {
            //return Filter(numbers, IsOdd); // "Method Group" (C# 2)
            // C# 1.0 Create an instance of the delegate manually
            //var op = new FilterMethod(IsOdd);
            //return Filter(numbers, op);
            // C# 2.0 Anonymous Method
            //return Filter(numbers, delegate (int x)
            //{
            //     return x % 2 != 0;

            //});
            // C# 3.0 Lambdas
            return Filter(numbers, n =>
            {
                // do your other stuff
                return n % 2 != 0;
            });
        }

        public List<int> FilterOutOdds(List<int> numbers)
        {
            return Filter(numbers, IsEven);
        }
        public List<int> Filter(List<int> numbers, Predicate<int> op)
        {
            var result = new List<int>();
            foreach (var num in numbers)
            {
                if (op(num))
                {
                    result.Add(num);
                }
            }
            return result;
        }

        //private bool IsOdd(int num)
        //{
        //    return num % 2 != 0;
        //}
        private bool IsEven(int num)
        {
            return num % 2 == 0;
        }

       
    }
}