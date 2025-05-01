using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0451_FrequencySortTest
{
    [Theory]
    [InlineData("tree", "eert")]
    [InlineData("cccaaa", "aaaccc")]
    [InlineData("Aabb", "bbAa")]
    public void FrequencySort(string s, string expected)
    {
        var actual = _0451_FrequencySort.FrequencySort(s);
        Assert.Equal(expected, actual);
    }
}
