namespace playground.UnitTest;

public class PowerfulIntegersTest0970
{
    [Theory]
    [InlineData(2, 3, 10, "[2,3,4,5,7,9,10]")]
    [InlineData(3, 5, 15, "[2,4,6,8,10,14]")]
    [InlineData(1, 2, 10, "[2,3,5,9]")]
    [InlineData(2, 1, 10, "[2,3,5,9]")]
    public void PowerfulIntegers(int x, int y, int bound, string expected)
    {
        var actual = PowerfulIntegers0970.PowerfulIntegers(x, y, bound);
        Assert.Equal(expected.ToArr(), actual.OrderBy(x => x));
    }
}
