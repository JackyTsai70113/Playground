namespace playground.UnitTest._2200_2299;

public class _2272_LargestVarianceTest
{
    [Theory]
    [InlineData("aabbbb", 3)]
    [InlineData("aababbb", 3)]
    [InlineData("abcde", 0)]
    [InlineData("lripaa", 1)]
    public void LargestVariance(string s, int expected)
    {
        var actual = _2272_LargestVariance.LargestVariance(s);
        Assert.Equal(expected, actual);
    }
}
