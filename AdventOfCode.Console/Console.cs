namespace AdventOfCode.Console
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

            var dayOne = new DayOne(input);
            Console.WriteLine($"Day 01-A: {dayOne.GetFloor()}");
            Console.WriteLine($"Day 01-B: {dayOne.PositionOfBasement()}");
        }

        static void RunDayTwo()
        {
            var input = string.Empty;

            using (var stream = new FileStream("./TestInput/dayTwo", FileMode.Open))
            using (var reader = new StreamReader(stream))
            {
                input = reader.ReadToEnd();
            }

            var dayTwo = new DayTwo(input);
            Console.WriteLine($"Day 02-A: {dayTwo.CalculateTotalArea()}");
            Console.WriteLine($"Day 02-B: {dayTwo.CalculateRibbonLength()}");
        }
    }
}
