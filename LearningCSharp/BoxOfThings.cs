using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp
{
    public class BoxOfThings<T>
    {
        private T[] _stuff = new T[10];

        public T this[int t]
        {
            get { return _stuff[t]; }
            set { _stuff[t] = value; }
        }
    }
}
