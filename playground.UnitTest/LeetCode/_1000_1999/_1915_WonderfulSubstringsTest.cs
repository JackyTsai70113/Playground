using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1915_WonderfulSubstringsTest
{
    [Theory]
    [InlineData("aba", 4)]
    [InlineData("aabb", 9)]
    [InlineData("he", 2)]
    public void WonderfulSubstrings(string word, long expected)
    {
        var actual = _1915_WonderfulSubstrings.WonderfulSubstrings(word);
        Assert.Equal(expected, actual);
    }
}
