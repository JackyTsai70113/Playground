namespace playground.UnitTest;

public class CountGoodStringsTest2466
{
    [Theory]
    [InlineData(3, 3, 1, 1, 8)]
    [InlineData(2, 3, 1, 2, 5)]
    public void CountGoodStrings(int low, int high, int zero, int one, int expected)
    {
        var actual = CountGoodStrings2466.CountGoodStrings(low, high, zero, one);
        Assert.Equal(expected, actual);
    }
}
