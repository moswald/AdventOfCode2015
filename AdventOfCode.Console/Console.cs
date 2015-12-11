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
            RunDayThree();
            RunDayFour();

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

        static void RunDayThree()
        {
            var input = string.Empty;

            using (var stream = new FileStream("./TestInput/dayThree", FileMode.Open))
            using (var reader = new StreamReader(stream))
            {
                input = reader.ReadToEnd();
            }

            var dayThree = new DayThree(input);
            Console.WriteLine($"Day 03-A: {dayThree.UniqueVisitedHouses()}");
            Console.WriteLine($"Day 03-B: {dayThree.UniqueVisitedHousesWithMultipleVisitors()}");
        }

        static void RunDayFour()
        {
            var input = "yzbqklnj";

            var dayFour = new DayFour();
            Console.WriteLine($"Day 04-A: {dayFour.MineAdventCoin(input, 5)}");
            Console.WriteLine($"Day 04-B: {dayFour.MineAdventCoin(input, 6)}");
        }
    }
}
