using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0014_LongestCommonPrefixTest
{
    [Theory]
    [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new string[] { "fl", "flow", "flight" }, "fl")]
    [InlineData(new string[] { "dog", "racecar", "car" }, "")]
    [InlineData(new string[] { "dog", "do" }, "do")]
    public void LongestCommonPrefix(string[] strs, string expected)
    {
        var actual = _0014_LongestCommonPrefix.LongestCommonPrefix(strs);
        Assert.Equal(expected, actual);
    }
}
