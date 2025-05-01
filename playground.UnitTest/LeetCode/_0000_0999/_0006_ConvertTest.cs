using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0006_ConvertTest
{
    [Theory]
    [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    [InlineData("AAA", 1, "AAA")]
    [InlineData("A", 4, "A")]
    public void ReverseWords(string s, int numRows, string expected)
    {
        var actual = _0006_Convert.Convert(s, numRows);
        Assert.Equal(expected, actual);
    }
}
