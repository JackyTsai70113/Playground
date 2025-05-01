using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2904_ShortestBeautifulSubstringTest
{
    [Theory]
    [InlineData("100111001", 3, "111")]
    [InlineData("110010011", 3, "10011")]
    [InlineData("100011001", 3, "11001")]
    [InlineData("1011", 2, "11")]
    [InlineData("000", 1, "")]
    public void ShortestBeautifulSubstring(string s, int k, string expected)
    {
        var actual = _2904_ShortestBeautifulSubstring.ShortestBeautifulSubstring(s, k);
        Assert.Equal(expected, actual);
    }
}
