using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0115_NumDistinctTest
{
    [Theory]
    [InlineData("rabbbit", "rabbit", 3)]
    [InlineData("babgbag", "bag", 5)]
    [InlineData("ababgbag", "bag", 5)]
    public void NumDistinct(string s, string t, int expected)
    {
        var actual = _0115_NumDistinct.NumDistinct(s, t);
        Assert.Equal(expected, actual);
    }
}
