using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3306_CountOfSubstringsTest
{
    [Theory]
    [InlineData("aeioqq", 1, 0)]
    [InlineData("aeiou", 0, 1)]
    [InlineData("ieaouqqieaouqq", 1, 3)]
    [InlineData("iqeaouqi", 2, 3)]
    public void CountOfSubstrings(string word, int k, long expected)
    {
        var actual = _3306_CountOfSubstrings.CountOfSubstrings(word, k);
        Assert.Equal(expected, actual);
    }
}
