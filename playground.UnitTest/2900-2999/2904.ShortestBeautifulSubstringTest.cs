namespace playground.UnitTest;

public class ShortestBeautifulSubstringTest2904
{
    [Theory]
    [InlineData("100111001", 3, "111")]
    [InlineData("110010011", 3, "10011")]
    [InlineData("100011001", 3, "11001")]
    [InlineData("1011", 2, "11")]
    [InlineData("000", 1, "")]
    public void ShortestBeautifulSubstring(string s, int k, string expected)
    {
        var actual = ShortestBeautifulSubstring2904.ShortestBeautifulSubstring(s, k);
        Assert.Equal(expected, actual);
    }
}
