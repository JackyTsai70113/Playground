using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1143_LongestCommonSubsequenceTest
{
    [Theory]
    [InlineData("abcde", "ace", 3)]
    [InlineData("abc", "abc", 3)]
    [InlineData("abc", "def", 0)]
    [InlineData("bl", "yby", 1)]
    public void LongestCommonSubsequence(string text1, string text2, int expected)
    {
        var actual = _1143_LongestCommonSubsequence.LongestCommonSubsequence(text1, text2);
        Assert.Equal(expected, actual);
    }
}
