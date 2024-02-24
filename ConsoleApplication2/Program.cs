using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person tom = new Person();
        }

        class Person
        {
            public string name = "Underfined";
            public int age;

            public void Print()
            {
                Console.WriteLine($"Name : {name} Age : {age}");
            }
            
            //Add commit in master branch
        }
    }
}