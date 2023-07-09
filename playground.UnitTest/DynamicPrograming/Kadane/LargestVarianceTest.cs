using playground.DynamicPrograming.Kadane;

namespace playground.UnitTest.DynamicPrograming.Kadane;

public class LargestVarianceTest
{
    [Theory]
    [InlineData("aabbbb", 3)]
    [InlineData("aababbb", 3)]
    [InlineData("abcde", 0)]
    public void LargestVariance(string s, int expected)
    {
        var actual = LargestVarianceClass.LargestVariance(s);
        Assert.Equal(expected, actual);
    }
}
