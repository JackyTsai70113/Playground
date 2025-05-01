using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0365_CanMeasureWaterTest
{
    [Theory]
    [InlineData(3, 5, 9, false)]
    [InlineData(3, 5, 4, true)]
    [InlineData(2, 6, 5, false)]
    [InlineData(1, 2, 3, true)]
    public void CanMeasureWater(int a, int b, int target, bool expected)
    {
        var actual = _0365_CanMeasureWater.CanMeasureWater(a, b, target);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(3, 5, 9, false)]
    [InlineData(3, 5, 4, true)]
    [InlineData(2, 6, 5, false)]
    [InlineData(1, 2, 3, true)]
    public void CanMeasureWater2(int a, int b, int target, bool expected)
    {
        var actual = _0365_CanMeasureWater.CanMeasureWater2(a, b, target);
        Assert.Equal(expected, actual);
    }
}
