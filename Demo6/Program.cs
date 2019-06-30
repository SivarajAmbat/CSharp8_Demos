using System;

namespace Demo6 {
    class Point {
        public int X { get; set; }
        public int Y { get; set; }
        public Point (int x, int y) => (X, Y) = (x, y);
        public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
    }

    class Program {
        static void Main (string[] args) {
            Point point = new Point (2, 3);
            Console.WriteLine(Display (point));
        }
        static string Display (Point o) => o switch {
                Point (0, 0)                        => "origin",            
                Point (var x, var y)                => $"({x}, {y})",   
                _                                   => "Unknown"           
            };
    }
}


/*
        static string Display (Point o) {
            switch (o) {
                case Point p when p.X == 0 && p.Y == 0: return "origin";            
                case Point p:                           return $"({p.X}, {p.Y})";   
                default:                                return "Unknown";           
            }
        }
 */

 /*
         static string Display (Point o) => o switch {
                Point p when p.X == 0 && p.Y == 0   => "origin",            
                Point p                             => $"({p.X}, {p.Y})",   
                _                                   => "Unknown"           
            };
 
  */

  /*
          static string Display (Point o) => o switch {
                Point { X: 0, Y: 0 }                => "origin",            
                Point { X: var x, Y: var y}         => $"({x}, {y})",   
                _                                   => "Unknown"           
            };
   */