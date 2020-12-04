using System;
using AdventOfCode.Apps.day1;

namespace AdventOfCode.Apps
{
    class Program
    {
        static void Main(string[] args)
        {

            var task = new Day1();
            task.orchestrator();
            
            Console.WriteLine("press enter to finsih");
            Console.ReadLine();
            
        }
    }
}