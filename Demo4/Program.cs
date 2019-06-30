using System;
namespace Demo4 {
    class Customer {
        public string Name { get; set; }
        public string Country { get; set; }
    }

    class Program {
        static void Main (string[] args) {
            Customer jack = new Customer { Name = "Jack", Country = "USA" };
            Customer liza = new Customer { Name = "Liza", Country = "ESP" };
            Customer ravi = new Customer { Name = "Ravi", Country = "IND" };
            Console.WriteLine (Greet (jack));
            Console.WriteLine (Greet (liza));
            Console.WriteLine (Greet (ravi));
        }
        static string Greet (Customer customer) =>
            customer switch { 
                { Country: "USA" } => "Hello " + customer.Name, 
                { Country: "ESP" } => "Hola " + customer.Name, 
                { Country: "IND" } => "Namaste " + customer.Name,
                _ => "Greetings! " + customer.Name
        };
    }
}