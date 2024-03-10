namespace playground.UnitTest;

public class ShortestSubstringsTest3076
{
    [Theory]
    [InlineData(new string[] { "cab", "ad", "bad", "c" }, new string[] { "ab", "", "ba", "" })]
    [InlineData(new string[] { "abc", "bcd", "abcd" }, new string[] { "", "", "abcd" })]
    [InlineData(new string[] { "gfnt", "xn", "mdz", "yfmr", "fi", "wwncn", "hkdy" }, new string[] { "g", "x", "z", "r", "i", "c", "h" })]
    public void ShortestSubstrings(string[] arr, string[] expected)
    {
        var actual = ShortestSubstrings3076.ShortestSubstrings(arr);
        Assert.Equal(expected, actual);
    }
}
