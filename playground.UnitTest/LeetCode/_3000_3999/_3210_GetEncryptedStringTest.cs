namespace playground.UnitTest;

public class _3210_GetEncryptedStringTest
{
    [Theory]
    [InlineData("dart", 3, "tdar")]
    [InlineData("aaa", 1, "aaa")]
    public void GetEncryptedString(string s, int k, string expected)
    {
        var actual = _3210_GetEncryptedString.GetEncryptedString(s, k);
        Assert.Equal(expected, actual);
    }
}
