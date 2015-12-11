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
