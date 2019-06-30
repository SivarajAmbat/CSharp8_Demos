using System;
using System.Collections.Generic;

namespace Demo7 {
    class Program {
        static void Main (string[] args) {
            int[] nums = { 1, 2, 3, 4, 5 };
            WriteNumsToFile (nums);
        }

        static void WriteNumsToFile (IEnumerable<int> nums) {
            using var file = new System.IO.StreamWriter ("WriteNums2.txt");
            foreach (var num in nums) {
                file.WriteLine (num);
            }
        // file is disposed here
        } 
    }
}