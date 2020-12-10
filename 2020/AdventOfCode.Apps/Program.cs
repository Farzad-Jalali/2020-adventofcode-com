using System;
using AdventOfCode.Apps.days;

namespace AdventOfCode.Apps
{
    class Program
    {
        static void Main(string[] args)
        {

            // var task = new Day1();
            // task.orchestrator();
            
            
            var task = new Day2b();
            Console.WriteLine($"day2 -a : { task.Answer()}");
           
            
            
            Console.WriteLine("press enter to finsih");
            Console.ReadLine();
            
        }
    }
}