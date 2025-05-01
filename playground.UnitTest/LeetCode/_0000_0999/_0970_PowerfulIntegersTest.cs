using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0970_PowerfulIntegersTest
{
    [Theory]
    [InlineData(2, 3, 10, "[2,3,4,5,7,9,10]")]
    [InlineData(3, 5, 15, "[2,4,6,8,10,14]")]
    [InlineData(1, 2, 10, "[2,3,5,9]")]
    [InlineData(2, 1, 10, "[2,3,5,9]")]
    public void PowerfulIntegers(int x, int y, int bound, string expected)
    {
        var actual = _0970_PowerfulIntegers.PowerfulIntegers(x, y, bound);
        Assert.Equal(expected.ToArr(), actual.OrderBy(x => x));
    }
}
