using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0028_StrStrTest
{
    [Theory]
    [InlineData("sadbutsad", "sad", 0)]
    [InlineData("leetcode", "leeto", -1)]
    [InlineData("leetcode", "leetcodeaa", -1)]
    public void StrStr(string A, string B, int expected)
    {
        var actual = _0028_StrStr.StrStr(A, B);
        Assert.Equal(expected, actual);
    }
}
