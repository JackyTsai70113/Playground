namespace playground.UnitTest;

public class _1518_NumWaterBottlesTest
{
    [Theory]
    [InlineData(9, 3, 13)]
    [InlineData(15, 4, 19)]
    public void NumWaterBottles
    (int numBottles, int numExchange, int expected)
    {
        var actual = _1518_NumWaterBottles.NumWaterBottles(numBottles, numExchange);
        Assert.Equal(expected, actual);
    }
}
