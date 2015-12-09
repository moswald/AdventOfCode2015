namespace AdventOfCode.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AdventOfCode.Logic.Extensions;

    public class DayThree
    {
        readonly string _directions;

        public DayThree(string directions)
        {
            _directions = directions;
        }

        public int UniqueVisitedHouses()
        {
            var x = 0;
            var y = 0;
            var set = new HashSet<Tuple<int, int>> { Tuple.Create(x, y) };

            foreach (var position in _directions
                .Select(
                    ch =>
                    {
                        switch (ch)
                        {
                            case '^':
                                ++y;
                                break;

                            case 'v':
                                --y;
                                break;

                            case '>':
                                ++x;
                                break;

                            case '<':
                                --x;
                                break;
                        }

                        return Tuple.Create(x, y);
                    }))
            {
                set.Add(position);
            }

            return set.Count;
        }

        public int UniqueVisitedHousesWithMultipleVisitors()
        {
            var set = new HashSet<Tuple<int, int>> { Tuple.Create(0, 0) };

            var visitors = new []
            {
                new HouseVisitor(),
                new HouseVisitor() 
            };

            foreach (var position in _directions.Zip(visitors.Forever(), Tuple.Create)
                .Select(
                    t => 
                    {
                        switch (t.Item1)
                        {
                            case '^':
                                t.Item2.GoUp();
                                break;

                            case 'v':
                                t.Item2.GoDown();
                                break;

                            case '>':
                                t.Item2.GoRight();
                                break;

                            case '<':
                                t.Item2.GoLeft();
                                break;
                        }

                        return Tuple.Create(t.Item2.X, t.Item2.Y);
                    }))
            {
                set.Add(position);
            }

            return set.Count;
        }

        class HouseVisitor
        {
            public int X { get; private set; } = 0;
            public int Y { get; private set; } = 0;

            public void GoUp()
            {
                ++Y;
            }

            public void GoDown()
            {
                --Y;
            }

            public void GoLeft()
            {
                --X;
            }

            public void GoRight()
            {
                ++X;
            }
        }
    }
}

namespace AdventOfCode.Logic.Extensions
{
    using System.Collections.Generic;

    static class ListExtensions
    {
        public static IEnumerable<T> Forever<T>(this IList<T> self)
        {
            for (;;)
            {
                for (var index = 0; index < self.Count; index++)
                {
                    yield return self[index];
                }
            }
        }
    }
}
