using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0955_MinDeletionSizeTest
{
    [Theory]
    [InlineData(new[] { "xc", "yb", "za" }, 0)]
    [InlineData(new[] { "zyx", "wvu", "tsr" }, 3)]
    [InlineData(new[] { "a", "b", "c" }, 0)]
    [InlineData(new[] { "aa", "bb", "cc" }, 0)]
    [InlineData(new[] { "aa", "ba", "ca" }, 0)]
    [InlineData(new[] { "ac", "bb", "ca" }, 0)]
    [InlineData(new[] { "aa", "ab", "ac" }, 0)]
    [InlineData(new[] { "aa", "aa", "aa" }, 0)]
    [InlineData(new[] { "ac", "ab", "aa" }, 1)]
    [InlineData(new[] { "ca", "bb", "ac" }, 1)]
    [InlineData(new[] { "ca", "ba", "aa" }, 1)]
    [InlineData(new[] { "cc", "bb", "aa" }, 2)]
    public void TestMinDeletionSize(string[] strs, int expected)
    {
        int result = _0955_MinDeletionSize.MinDeletionSize(strs);
        Assert.Equal(expected, result);
    }
}
