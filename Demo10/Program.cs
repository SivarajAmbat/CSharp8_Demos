using System;

namespace Demo10 {
    class Customer {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
    }

    class Program {
        #nullable enable
        static void Main (string[] args) {
            Customer c = new Customer { FirstName = "John", LastName = "Rambo" };
            Console.WriteLine (GetLength (c.MiddleName));
        }

        static int GetLength (string s) {
            return (s != null)? s.Length: 0;
            //return s.Length;
        }
        #nullable restore
    }
}
