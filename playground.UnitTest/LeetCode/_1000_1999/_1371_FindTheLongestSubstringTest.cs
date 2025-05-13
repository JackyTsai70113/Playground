using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1371_FindTheLongestSubstringTest
{
    [Theory]
    [InlineData("eleetminicoworoep", 13)]
    [InlineData("leetcodeisgreat", 5)]
    [InlineData("bcbcbcu", 6)]
    public void FindTheLongestSubstring(string s, int expected)
    {
        var actual = _1371_FindTheLongestSubstring.FindTheLongestSubstring(s);
        Assert.Equal(expected, actual);
    }
}
