using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3448_CountSubstringsTest
{
    [Theory]
    [InlineData("12936", 11)]
    [InlineData("5701283", 18)]
    [InlineData("1010101010", 25)]
    [InlineData("580231689239", 39)]
    [InlineData("580231", 14)]
    [InlineData("5802317", 17)]
    [InlineData("74532038088", 37)]
    [InlineData("74532038084", 37)]
    [InlineData("7453203808", 26)]
    [InlineData("4", 1)]
    [InlineData("8", 1)]
    public void CountSubstrings(string s, long expected)
    {
        var actual = _3448_CountSubstrings.CountSubstrings(s);
        Assert.Equal(expected, actual);
    }
}
