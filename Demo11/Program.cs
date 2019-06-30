using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo11 {
    class Program {

        // static async Task Main (string[] args) {
        //     foreach (var dataPoint in await FetchData ()) {
        //         Console.WriteLine (dataPoint);
        //     }

        //     Console.ReadLine ();
        // }

        // static async Task<IEnumerable<int>> FetchData () {
        //     List<int> dataPoints = new List<int> ();
        //     for (int i = 1; i <= 10; i++) {
        //         await Task.Delay (1000); //Simulate waiting for data to come through. 
        //         dataPoints.Add (i);
        //     }
        //     return dataPoints;
        // }

        static async Task Main (string[] args) {
            await
            foreach (var dataPoint in FetchData ()) {
                Console.WriteLine (dataPoint);
            }

            Console.ReadLine ();
        }

        static async IAsyncEnumerable<int> FetchData () {
            for (int i = 1; i <= 10; i++) {
                await Task.Delay (1000); //Simulate waiting for data to come through. 
                yield return i;
            }
        }
    }
}