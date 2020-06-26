using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp
{
    public class Indexable
    {
        // "this" 
        public int this[string name]
        {
            get
            {
                switch (name)
                {
                    case "first":
                        {
                            return 1;
                        }
                    case "second":
                        {
                            return 2;
                        }
                    case "third":
                        {
                            return 3;
                        }
                    default:
                        {
                            throw new IndexOutOfRangeException();
                        }
                }
            }
        }
    }
}
