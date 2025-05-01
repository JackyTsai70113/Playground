using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0306_IsAdditiveNumberTest
{
    [Theory]
    [InlineData("112358", true)]
    [InlineData("199100199", true)]
    [InlineData("10", false)]
    [InlineData("101", true)]
    [InlineData("1012", false)]
    [InlineData("011112", false)]
    [InlineData("199001200", false)]
    [InlineData("12122436", true)]
    public void IsAdditiveNumber(string num, bool expected)
    {
        var actual = _0306_IsAdditiveNumber.IsAdditiveNumber(num);
        Assert.Equal(expected, actual);
    }
}
