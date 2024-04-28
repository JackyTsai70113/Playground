namespace playground.UnitTest;

public class CanMeasureWaterTest0365
{
    [Theory]
    [InlineData(3, 5, 9, false)]
    [InlineData(3, 5, 4, true)]
    [InlineData(2, 6, 5, false)]
    [InlineData(1, 2, 3, true)]
    public void CanMeasureWater(int a, int b, int target, bool expected)
    {
        var actual = CanMeasureWater0365.CanMeasureWater(a, b, target);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(3, 5, 9, false)]
    [InlineData(3, 5, 4, true)]
    [InlineData(2, 6, 5, false)]
    [InlineData(1, 2, 3, true)]
    public void CanMeasureWater2(int a, int b, int target, bool expected)
    {
        var actual = CanMeasureWater0365.CanMeasureWater2(a, b, target);
        Assert.Equal(expected, actual);
    }
}
