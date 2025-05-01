using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0020_IsValidTest
{
    [Theory]
    [InlineData("(([]){})", true)]
    [InlineData(")", false)]
    [InlineData("]", false)]
    [InlineData("}", false)]
    [InlineData("[)", false)]
    [InlineData("(]", false)]
    [InlineData("(}", false)]
    public void IsValid(string s, bool expected)
    {
        var actual = _0020_IsValid.IsValid(s);
        Assert.Equal(expected, actual);
    }
}
