namespace playground.UnitTest;

public class OriginalDigitsTest0423
{
    [Theory]
    [InlineData("ozer", "0")]
    [InlineData("owoztneoer", "012")]
    [InlineData("fviefuro", "45")]
    [InlineData("zeroonetwothreefourfivesixseveneightnine", "0123456789")]
    public void OriginalDigits(string s, string expected)
    {
        var actual = OriginalDigits0423.OriginalDigits(s);
        Assert.Equal(expected, actual);
    }
}
