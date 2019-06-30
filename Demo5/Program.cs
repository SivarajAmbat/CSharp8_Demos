using System;

namespace Demo5 {
    class Customer {
        public string Name { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
    }
    class Program {
        static void Main (string[] args) {
            Customer anil = new Customer { Name = "Anil", Country = "IND", State = "KA" };
            Customer siva = new Customer { Name = "Siva", Country = "IND", State = "TN" };
            Customer rani = new Customer { Name = "Rani", Country = "IND", State = "WB" };

            Console.WriteLine(Greet(anil));
            Console.WriteLine(Greet(siva));
            Console.WriteLine(Greet(rani));
        }
        static string Greet (Customer c) => (c.Country, c.State) switch 
        { 
            ("IND", "KA") => "Namsakara " + c.Name,
            ("IND", "TN") => "Vanakkam " + c.Name,
            (_,_)         => "Namaste " + c.Name
        };
    }
}

