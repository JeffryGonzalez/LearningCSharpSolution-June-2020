using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class VariablesAndDataTypes
    {
        [Fact]
        public void SomeOfTheBuiltInTypes()
        {
            // Type Identifier;
            int age;
            age = 22;
            Int32 yourAge;
            yourAge = 23;
            string name;
            name = "Jeff";
            String yourName;
            yourName = "Sarah";

            // Initializing - assigning a value when declaring
            Double pay = 33.22;
            decimal yourPay = 33.22M;

            Boolean isAwake = true;
            bool over = 12 > 13;

            int x;

            x = 0;
            Assert.Equal(0, x);

        }
        string Thingy = "Tacos";
        [Fact]
        public void ImplicitlyTypedLocalVariables()
        {
            Assert.Equal("Tacos", Thingy);

            // C# 3.0
            var pay = 32.50M;
            // C# Is a strictly typed language. A variable
            // can never change its data type.
            // born an integer? you will ALWAYS be an integer.
            // born an Employee? You will NEVER be a retiree.
            // pay = "Too damned high";
            var myName = "Jeff";
            //string myName = "Jeff";

            //Employee bob = new Employee();
            //var sue = new Employee();
        }

        [Fact]
        public void ValueTypes()
        {
            // structs
            int age = 52;
            DateTime myBirthday = new DateTime(1969, 4, 20);
            string myName = "Jeff";

            DoubleIt(age);
            Assert.Equal(52, age);

            var rover = new Dog();
            rover.Name = "Rover";
            DoSomething(rover);
            Assert.Equal("Fido", rover.Name);
        }

        [Fact]
        public void UsingRefAndOut()
        {
            // comment: ctrl + k, ctrl + c 
            // uncomment ctrl +k, ctrl + u
            int y = 50;
            DoubleItRef(ref y);

            Assert.Equal(100, y);

            //int p;
            //GimmeSomething(out p);
            GimmeSomething(out int p);
            Assert.Equal(42, p);


        }

        public void DoubleItRef(ref int x)
        {
            x = x + x;
        }

        public void GimmeSomething(out int z)
        {
            z = 42;
        }

        public void DoubleIt(int x)
        {
            x = x + x;
        }

        public void DoSomething(Dog d)
        {
            d.Name = "Fido";
        }
    }


    public class Dog
    {
        public string Name;
    }
    
}
