using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0171_TitleToNumberTest
{
    [Theory]
    [InlineData("A", 1)]
    [InlineData("AB", 28)]
    [InlineData("ZY", 701)]
    public void TitleToNumber(string A, int expected)
    {
        var actual = _0171_TitleToNumber.TitleToNumber(A);
        Assert.Equal(expected, actual);
    }
}
