using System;

namespace Demo9 {

    ref struct Book {
        public void Dispose () {

        }
    }
    class Program {
        static void Main (string[] args) {
            using var book = new Book ();
            Console.WriteLine ("Hello World!");
        }
    }
}