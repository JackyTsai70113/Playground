namespace playground.UnitTest;

public class GetEncryptedStringTest3210
{
    [Theory]
    [InlineData("dart", 3, "tdar")]
    [InlineData("aaa", 1, "aaa")]
    public void GetEncryptedString(string s, int k, string expected)
    {
        var actual = GetEncryptedString3210.GetEncryptedString(s, k);
        Assert.Equal(expected, actual);
    }
}
