namespace AdventOfCode.Logic
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public static class DayTwo
    {
        public static int CalculateTotalArea(string dimensionList)
        {
            return Regex.Split(dimensionList, "\r\n|\r|\n")
                .Select(definition => new Package(definition))
                .Select(package => package.SurfaceArea + package.Shortest)
                .Sum();
        }

        struct Package
        {
            readonly int[] _dimensions;

            int Length => _dimensions[0];
            int Width => _dimensions[1];
            int Height => _dimensions[2];

            public Package(string definition)
            {
                _dimensions = definition.Split('x')
                    .Select(int.Parse)
                    .OrderBy(x => x)
                    .ToArray();
            }

            public int SurfaceArea => 2 * Length * Width +
                                      2 * Length * Height +
                                      2 * Width * Height;

            public int Shortest => Length * Width;
        }
    }
}
