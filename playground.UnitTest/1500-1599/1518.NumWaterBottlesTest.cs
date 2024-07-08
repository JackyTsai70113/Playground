namespace playground.UnitTest;

public class NumWaterBottlesTest1518
{
    [Theory]
    [InlineData(9, 3, 13)]
    [InlineData(15, 4, 19)]
    public void NumWaterBottles
    (int numBottles, int numExchange, int expected)
    {
        var actual = NumWaterBottles1518.NumWaterBottles(numBottles, numExchange);
        Assert.Equal(expected, actual);
    }
}
