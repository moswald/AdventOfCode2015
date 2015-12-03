namespace AdventOfCode.Console
{
    using System;
    using AdventOfCode.Logic;

    public static class Program
    {
        static void Main()
        {
            var input = "()";
            var result = DayOne.GetFloor(input);
            Console.WriteLine($"{result}");

            Console.ReadKey(true);
        }
    }
}
