namespace AdventOfCode.Logic.Extensions
{
    using System.Collections.Generic;

    static class Alg
    {
        public static IEnumerable<int> Infinity()
        {
            for (var i = 0; ; ++i)
            {
                yield return i;
            }
        }
    }
}
