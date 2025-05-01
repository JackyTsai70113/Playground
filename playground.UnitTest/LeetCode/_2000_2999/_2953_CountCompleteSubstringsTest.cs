using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2953_CountCompleteSubstringsTest
{
    [Theory]
    [InlineData("igigee", 2, 3)]
    [InlineData("aaabbbccc", 3, 6)]
    [InlineData("aca", 1, 5)]
    [InlineData("jjjqq", 1, 5)]
    public void CountCompleteSubstrings(string s, int k, int expected)
    {
        var actual = _2953_CountCompleteSubstrings.CountCompleteSubstrings(s, k);
        Assert.Equal(expected, actual);
    }
}
