using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1930_CountPalindromicSubsequenceTest
{
    [Theory]
    [InlineData("aabca", 3)]
    [InlineData("adc", 0)]
    [InlineData("bbcbaba", 4)]
    public void CountPalindromicSubsequence(string s, int expected)
    {
        var actual = _1930_CountPalindromicSubsequence.CountPalindromicSubsequence(s);
        Assert.Equal(expected, actual);
    }
}
