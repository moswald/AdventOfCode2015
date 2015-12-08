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
                .Select(package => package.SurfaceArea + package.Length * package.Width)
                .Sum();
        }

        public static int CalculateRibbonLength(string dimensionList)
        {
            return Regex.Split(dimensionList, "\r\n|\r|\n")
                .Select(definition => new Package(definition))
                .Select(package => 2 * package.Length + 2 * package.Width + package.Volume)
                .Sum();
        }

        struct Package
        {
            readonly int[] _dimensions;

            public Package(string definition)
            {
                _dimensions = definition.Split('x')
                    .Select(int.Parse)
                    .OrderBy(x => x)
                    .ToArray();
            }

            public int Length => _dimensions[0];
            public int Width => _dimensions[1];
            public int Height => _dimensions[2];

            public int SurfaceArea => 2 * Length * Width +
                                      2 * Length * Height +
                                      2 * Width * Height;

            public int Volume => Length * Width * Height;
        }
    }
}
