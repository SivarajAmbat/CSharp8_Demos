using System;

namespace Demo3 {
    enum MenuOptions {
        Inc, 
        Dec
    }
    class Program {
        static void Main (string[] args) {
            int num = 5, choice = 1;
            int result = Calculate ((MenuOptions) choice, num);
            Console.WriteLine ($"The value is {result}");
        }
/*
        static int Calculate (MenuOptions choice, int num) {
            switch (choice) {
                case MenuOptions.Inc: return ++num; break;
                case MenuOptions.Dec: return --num; break;
                default: throw new Exception (message: "Invalid choice"); break;
            };
        }
*/

        static int Calculate (MenuOptions choice, int num) =>
            choice switch {
                MenuOptions.Inc => ++num,
                MenuOptions.Dec => --num,
                _               => throw new Exception (message: "Invalid choice")
            };

    }
}
