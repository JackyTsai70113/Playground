namespace playground.UnitTest;

public class GetSmallestStringTest3106
{
    [Theory]
    [InlineData("zbbz", 3, "aaaz")]
    [InlineData("xaxcd", 4, "aawcd")]
    [InlineData("lol", 0, "lol")]
    [InlineData("zzzzz", 2000, "aaaaa")]
    public void GetSmallestString(string s, int k, string expected)
    {
        var actual = GetSmallestString3106.GetSmallestString(s, k);
        Assert.Equal(expected, actual);
    }
}
