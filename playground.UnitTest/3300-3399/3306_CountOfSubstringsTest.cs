using playground._3300_3399;

namespace playground.UnitTest._3300_3399;

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
