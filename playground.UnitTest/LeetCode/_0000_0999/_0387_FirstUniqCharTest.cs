using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0387_FirstUniqCharTest
{
    [Theory]
    [InlineData("leetcode", 0)]
    [InlineData("loveleetcode", 2)]
    [InlineData("aabb", -1)]
    public void FirstUniqChar(string s, int expected)
    {
        var actual = _0387_FirstUniqChar.FirstUniqChar(s);
        Assert.Equal(expected, actual);
    }
}
