using System;

namespace Demo8
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "John";
            var lastName = "Rambo";

            static string GetFullName(string first, string last) => first + " " + last;

            Console.WriteLine($"The name is {GetFullName(firstName, lastName)}");

        }
    }
}


/*
            Console.WriteLine($"The name is {GetFullName()}");

            string GetFullName() => firstName + " " + lastName;
 */