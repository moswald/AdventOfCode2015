﻿namespace AdventOfCode.Console
{
    using System;
    using System.IO;
    using AdventOfCode.Logic;

    public static class Program
    {
        static void Main()
        {
            RunDayOne();
            RunDayTwo();

            Console.ReadKey(true);
        }

        static void RunDayOne()
        {
            var input = string.Empty;

            using (var stream = new FileStream("./TestInput/dayOne", FileMode.Open))
            using (var reader = new StreamReader(stream))
            {
                input = reader.ReadToEnd();
            }

            var result = DayOne.GetFloor(input);
            Console.WriteLine($"Day 01-A: {result}");

            result = DayOne.PositionOfBasement(input);
            Console.WriteLine($"Day 01-B: {result}");
        }

        static void RunDayTwo()
        {
            var input = string.Empty;

            using (var stream = new FileStream("./TestInput/dayTwo", FileMode.Open))
            using (var reader = new StreamReader(stream))
            {
                input = reader.ReadToEnd();
            }

            var result = DayTwo.CalculateTotalArea(input);
            Console.WriteLine($"Day 02-A: {result}");

            result = DayTwo.CalculateRibbonLength(input);
            Console.WriteLine($"Day 02-B: {result}");
        }
    }
}
