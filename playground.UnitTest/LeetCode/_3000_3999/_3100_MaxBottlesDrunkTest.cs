namespace playground.UnitTest;

public class _3100_MaxBottlesDrunkTest
{
    [Theory]
    [InlineData(13, 6, 15)]
    [InlineData(10, 3, 13)]
    public void MaxBottlesDrunk(int numBottles, int numExchange, int expected)
    {
        var actual = _3100_MaxBottlesDrunk.MaxBottlesDrunk(numBottles, numExchange);
        Assert.Equal(expected, actual);
    }
}
