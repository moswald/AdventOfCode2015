namespace AdventOfCode.Logic
{
    using System.Linq;

    public class DayOne
    {
        readonly int[] _directions;

        public DayOne(string directions)
        {
            _directions = directions
                .Where(ch => ch == ')' || ch == '(')
                .Select(ch => ch == ')' ? -1 : 1)
                .ToArray();
        }

        public int GetFloor() => _directions.Sum();

        public int PositionOfBasement()
        {
            var sum = 0;
            return _directions
                .TakeWhile(_ => sum != -1)
                .Select(val => sum += val)
                .Count();
        }
    }
}
