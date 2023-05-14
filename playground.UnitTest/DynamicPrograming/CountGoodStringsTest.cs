using playground.DynamicPrograming;

namespace playground.UnitTest.DynamicPrograming;

public class CountGoodStringsTest
{
    [Theory]
    [InlineData(3, 3, 1, 1, 8)]
    [InlineData(2, 3, 1, 2, 5)]
    public void CountGoodStrings(int low, int high, int zero, int one, int expected)
    {
        var actual = CountGoodStringsClass.CountGoodStrings(low, high, zero, one);
        Assert.Equal(actual, expected);
    }
}
