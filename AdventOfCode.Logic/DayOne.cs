namespace AdventOfCode.Logic
{
    using System.Linq;

    public static class DayOne
    {
        public static int GetFloor(string directions)
        {
            return directions
                .Where(ch => ch == ')' || ch == '(')
                .Select(ch => ch == ')' ? -1 : 1)
                .Sum();
        }

        public static int PositionOfBasement(string directions)
        {
            var sum = 0;
            return directions
                .Where(ch => ch == ')' || ch == '(')
                .Select(ch => ch == ')' ? -1 : 1)
                .TakeWhile(_ => sum != -1)
                .Select(val => sum += val)
                .Count();
        }
    }
}
