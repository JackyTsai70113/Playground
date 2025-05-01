using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0076_MinWindowTest
{
    [Theory]
    [InlineData("ADOBECODEBANC", "ABC", "BANC")]
    [InlineData("CODEBANC", "ABC", "BANC")]
    [InlineData("BANC", "ABC", "BANC")]
    [InlineData("a", "a", "a")]
    [InlineData("a", "aa", "")]
    [InlineData("a", "b", "")]
    public void MinWindow(string s, string t, string expected)
    {
        var actual = _0076_MinWindow.MinWindow(s, t);
        Assert.Equal(expected, actual);
    }
}
