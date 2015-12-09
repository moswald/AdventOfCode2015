namespace AdventOfCode.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

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
    }
}
