namespace AdventOfCode.Logic.Tests
{
    using System.Collections;
    using System.Collections.Generic;
    using FluentAssertions;
    using Xunit;

    public class TestDayTwo
    {
        [Theory]
        [MemberData("PartOneTestData")]
        public void CalculateTotalAreaReturnsCorrectResult(string dimensionList, int expectedTotal)
        {
            var dayTwo = new DayTwo(dimensionList);
            dayTwo.CalculateTotalArea()
                .Should().Be(expectedTotal);
        }

        [Theory]
        [MemberData("PartTwoTestData")]
        public void CalculateRibbonLength(string dimensionList, int expectedTotal)
        {
            var dayTwo = new DayTwo(dimensionList);
            dayTwo.CalculateRibbonLength()
                .Should().Be(expectedTotal);
        }

        public static IEnumerable<object[]> PartOneTestData()
        {
            yield return new object[] { "2x3x4", 58 };
            yield return new object[] { "1x1x10", 43 };
            yield return new object[]
            {
                "2x3x4\n" +
                "1x1x10",
                58 + 43
            };
        }

        public static IEnumerable<object[]> PartTwoTestData()
        {
            yield return new object[] { "2x3x4", 34 };
            yield return new object[] { "1x1x10", 14 };
            yield return new object[]
            {
                "2x3x4\n" +
                "1x1x10",
                34 + 14
            };
        }
    }
}