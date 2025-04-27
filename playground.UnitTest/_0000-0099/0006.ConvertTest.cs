namespace playground.UnitTest;

public class ConvertTest_0006
{
    [Theory]
    [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    [InlineData("AAA", 1, "AAA")]
    [InlineData("A", 4, "A")]
    public void ReverseWords(string s, int numRows, string expected)
    {
        var actual = Convert_0006.Convert(s, numRows);
        Assert.Equal(expected, actual);
    }
}
