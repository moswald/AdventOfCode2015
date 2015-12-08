namespace AdventOfCode.Logic
{
    using System.Linq;
    using System.Text.RegularExpressions;

    public class DayTwo
    {
        readonly Package[] _packages;

        public DayTwo(string dimensionList)
        {
            _packages = Regex.Split(dimensionList, "\r\n|\r|\n")
                .Select(definition => new Package(definition))
                .ToArray();
        }

        public int CalculateTotalArea() => _packages
                .Select(package => package.SurfaceArea + package.Length * package.Width)
                .Sum();

        public int CalculateRibbonLength() => _packages
                .Select(package => 2 * package.Length + 2 * package.Width + package.Volume)
                .Sum();

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
