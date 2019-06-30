using System;
namespace Demo12 {
    class Program {
        static void Main (string[] args) {
            int[] nums = {
                        //index from start  index from end
                1,      //0                 ^5
                2,      //1                 ^4
                3,      //2                 ^3  
                4,      //3                 ^2
                5       //4                 ^1
            };
            Console.WriteLine ($"The last number is {nums[^1]}");
            Display(nums[..]);      // Displays all numbers
            Display(nums[..3]);     // Displays first three numbers
            Display(nums[3..]);     // Displays last two numbers
        }
        public static void Display(Span<int> nums){
            foreach(var n in nums){
                Console.Write($"|{n}");
            }
            Console.WriteLine("|");
        }
    }
}