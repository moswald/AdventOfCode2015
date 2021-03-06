﻿namespace AdventOfCode.Logic.Tests
{
    using FluentAssertions;
    using Xunit;

    public class TestDayOne
    {
        [Theory]
        [InlineData("(())", 0)]
        [InlineData("()()", 0)]
        [InlineData("(((", 3)]
        [InlineData("(()(()(", 3)]
        [InlineData("))(((((", 3)]
        [InlineData("())", -1)]
        [InlineData("))(", -1)]
        [InlineData(")))", -3)]
        [InlineData(")())())", -3)]
        public void GetFloorReturnsCorrectResult(string directions, int expectedFloor)
        {
            var dayOne = new DayOne(directions);
            dayOne.GetFloor()
                .Should().Be(expectedFloor);
        }

        [Theory]
        [InlineData(")", 1)]
        [InlineData("()())", 5)]
        public void PositionOfBasementReturnsCorrectResult(string directions, int expectedPosition)
        {
            var dayOne = new DayOne(directions);
            dayOne.PositionOfBasement()
                .Should().Be(expectedPosition);
        }
    }
}
