using System;

namespace Demo2 {
    interface IPerson {
        string FirstName { get; set; }
        string LastName { get; set; }
        string GetFullName() => $"The full name is {FirstName} {LastName}";
    }

    class Customer : IPerson {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Program {
        static void Main (string[] args) {
            IPerson  c = new Customer {FirstName = "John", LastName = "Rambo"};
            Console.WriteLine(c.GetFullName());
        }
    }
}
