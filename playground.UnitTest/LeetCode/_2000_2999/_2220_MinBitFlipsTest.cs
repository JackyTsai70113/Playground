using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2220_MinBitFlipsTest
{
    [Theory]
    [InlineData(10, 7, 3)]
    [InlineData(3, 4, 3)]
    public void MinBitFlips(int start, int goal, int expected)
    {
        var actual = _2220_MinBitFlips.MinBitFlips(start, goal);
        Assert.Equal(expected, expected);
    }
}
