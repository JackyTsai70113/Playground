namespace playground.UnitTest;

public class WonderfulSubstringsTest1915
{
    [Theory]
    [InlineData("aba", 4)]
    [InlineData("aabb", 9)]
    [InlineData("he", 2)]
    public void WonderfulSubstrings(string word, long expected)
    {
        var actual = WonderfulSubstrings1915.WonderfulSubstrings(word);
        Assert.Equal(expected, actual);
    }
}
