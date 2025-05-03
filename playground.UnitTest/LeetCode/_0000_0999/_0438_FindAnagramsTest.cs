using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0438_FindAnagramsTest
{
    [Theory]
    [InlineData("cbaebabacd", "abc", new int[] { 0, 6 })]
    [InlineData("abab", "ab", new int[] { 0, 1, 2 })]
    public void FindAnagrams(string s, string p, int[] expected)
    {
        var actual = _0438_FindAnagrams.FindAnagrams(s, p);
        Assert.Equal(expected, actual);
    }
}
