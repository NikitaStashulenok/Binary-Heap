using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BinaryHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Stopwatch();
            var rnd = new Random();
            var startItems = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                startItems.Add(rnd.Next(-1000, 1000));
            }

            timer.Start();
            var heap = new Heap(startItems);
            timer.Stop();
            Console.WriteLine("Initial initialization with 1000 elements " + timer.Elapsed);


            timer.Restart();
            for (int i = 0; i < 100; i++)
            {
                heap.Add(rnd.Next(-1000, 1000));
            }
            timer.Stop();
            Console.WriteLine("Adding the second thousand items " + timer.Elapsed);

            timer.Restart();
            foreach (var item in heap)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Output of 2000 items " + timer.Elapsed);
            Console.ReadKey();
        }
    }
}
