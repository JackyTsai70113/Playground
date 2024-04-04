namespace playground.UnitTest;

public class MaxBottlesDrunkTest3100
{
    [Theory]
    [InlineData(13, 6, 15)]
    [InlineData(10, 3, 13)]
    public void MaxBottlesDrunk(int numBottles, int numExchange, int expected)
    {
        var actual = MaxBottlesDrunk3100.MaxBottlesDrunk(numBottles, numExchange);
        Assert.Equal(expected, actual);
    }
}
