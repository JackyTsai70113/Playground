using playground_1800_1899;

namespace playground.UnitTest._1800_1899;

public class _1888_MinFlipsTest
{
    [Theory]
    [InlineData("111000", 2)]
    [InlineData("010", 0)]
    [InlineData("1110", 1)]
    public void MinFlips(string s, int expected)
    {
        var actual = _1888_MinFlips.MinFlips(s);
        Assert.Equal(expected, actual);
    }
}
