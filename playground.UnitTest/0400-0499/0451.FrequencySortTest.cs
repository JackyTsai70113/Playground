namespace playground.UnitTest;

public class FrequencySortTest0451
{
    [Theory]
    [InlineData("tree", "eert")]
    [InlineData("cccaaa", "aaaccc")]
    [InlineData("Aabb", "bbAa")]
    public void FrequencySort(string s, string expected)
    {
        var actual = FrequencySort0451.FrequencySort(s);
        Assert.Equal(expected, actual);
    }
}
