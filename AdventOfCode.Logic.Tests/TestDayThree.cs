namespace AdventOfCode.Logic.Tests
{
    using System.Collections.Generic;
    using FluentAssertions;
    using Xunit;

    public class TestDayThree
    {
        [Theory]
        [MemberData("PartOneTestData")]
        public void UniqueVisitedHousesReturnsCorrectResult(string directions, int expectedCount)
        {
            var dayThree = new DayThree(directions);
            dayThree.UniqueVisitedHouses()
                .Should().Be(expectedCount);
        }

        [Theory]
        [MemberData("PartTwoTestData")]
        public void UniqueVisitedHousesWithMultipleVisitorsReturnsCorrectResult(string directions, int expectedCount)
        {
            var dayThree = new DayThree(directions);
            dayThree.UniqueVisitedHousesWithMultipleVisitors()
                .Should().Be(expectedCount);
        }

        public static IEnumerable<object[]> PartOneTestData()
        {
            yield return new object[] { ">", 2 };
            yield return new object[] { "^>v<", 4 };
            yield return new object[] { "^v^v^v^v^v", 2 };
        }

        public static IEnumerable<object[]> PartTwoTestData()
        {
            yield return new object[] { "^v", 3 };
            yield return new object[] { "^>v<", 3 };
            yield return new object[] { "^v^v^v^v^v", 11 };
        }
    }
}
