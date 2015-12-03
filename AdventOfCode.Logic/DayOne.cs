namespace AdventOfCode.Logic
{
    using System.Linq;

    public static class DayOne
    {
        public static int GetFloor(string directions)
        {
            return directions
                .Select(ch => ch == ')' ? -1 : 1)
                .Sum();
        }
    }
}
