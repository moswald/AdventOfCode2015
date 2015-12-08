namespace AdventOfCode.Logic.Tests
{
    using System.Collections;
    using System.Collections.Generic;
    using FluentAssertions;
    using Xunit;

    public class TestDayTwo
    {
        [Theory]
        [MemberData("TestData")]
        public void CalculateTotalAreaReturnsCorrectResult(string dimensionList, int expectedTotal)
        {
            DayTwo.CalculateTotalArea(dimensionList)
                .Should().Be(expectedTotal);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { "2x3x4", 58 };
            yield return new object[] { "1x1x10", 43 };
            yield return new object[]
            {
                "2x3x4\n" +
                "1x1x10",
                58 + 43 };
        }
    }
}