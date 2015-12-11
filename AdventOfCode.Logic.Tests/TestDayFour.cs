namespace AdventOfCode.Logic.Tests
{
    using FluentAssertions;
    using Xunit;

    public class TestDayFour
    {
        [Theory]
        [InlineData("abcdef", 609043)]
        [InlineData("pqrstuv", 1048970)]
        public void MineAdventCoinReturnsCorrectValue(string key, int expectedValue)
        {
            new DayFour().MineAdventCoin(key, 5)
                .Should().Be(expectedValue);
        }
    }
}
