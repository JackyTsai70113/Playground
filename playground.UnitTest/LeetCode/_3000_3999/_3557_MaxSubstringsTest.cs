using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3557_MaxSubstringsTest
{
    [Theory]
    [InlineData("abcdeafdef", 2)]
    [InlineData("bcdaaaab", 1)]
    [InlineData("aadcbbbebb", 1)]
    public void MaxSubstrings(string word, int expected)
    {
        var result = _3557_MaxSubstrings.MaxSubstrings(word);
        Assert.Equal(expected, result);
    }
}
