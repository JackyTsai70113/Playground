using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0567_CheckInclusionTest
{
    [Theory]
    [InlineData("ab", "eidbaooo", true)]
    [InlineData("ab", "eidboaoo", false)]
    [InlineData("abcdxabcde", "abcdeabcdx", true)]
    [InlineData("abcdxabcde", "abcdeabcd", false)]
    public void CheckInclusion(string s1, string s2, bool expected)
    {
        var actual = _0567_CheckInclusion.CheckInclusion(s1, s2);
        Assert.Equal(expected, actual);
    }
}