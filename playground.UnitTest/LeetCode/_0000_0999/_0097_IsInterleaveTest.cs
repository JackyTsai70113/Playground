using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0097_IsInterleaveTest
{
    [Theory]
    [InlineData("aabcc", "dbbca", "aadbbcbcac", true)]
    [InlineData("aabcc", "dbbca", "aadbbbaccc", false)]
    [InlineData("", "", "", true)]
    [InlineData("", "", "a", false)]
    public void IsInterleave(string s1, string s2, string s3, bool expected)
    {
        var actual = _0097_IsInterleave.IsInterleave(s1, s2, s3);
        Assert.Equal(expected, actual);
    }
}
