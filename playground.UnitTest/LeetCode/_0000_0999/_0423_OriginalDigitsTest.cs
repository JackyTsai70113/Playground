using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0423_OriginalDigitsTest
{
    [Theory]
    [InlineData("ozer", "0")]
    [InlineData("owoztneoer", "012")]
    [InlineData("fviefuro", "45")]
    [InlineData("zeroonetwothreefourfivesixseveneightnine", "0123456789")]
    public void OriginalDigits(string s, string expected)
    {
        var actual = _0423_OriginalDigits.OriginalDigits(s);
        Assert.Equal(expected, actual);
    }
}
