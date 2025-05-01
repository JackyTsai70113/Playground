using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2370_LongestIdealStringTest
{
    [Theory]
    [InlineData("acfgbd", 2, 4)]
    [InlineData("abcd", 3, 4)]
    [InlineData("abcd", 0, 1)]
    [InlineData("azaza", 25, 5)]
    public void LongestIdealString(string s, int k, int expected)
    {
        var actual = _2370_LongestIdealString.LongestIdealString(s, k);
        Assert.Equal(expected, actual);
    }
}
