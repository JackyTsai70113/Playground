using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0787_FindCheapestPriceTest
{
    [Theory]
    [InlineData(4, "[[0,1,100],[1,2,100],[2,0,100],[1,3,600],[2,3,200]]", 0, 3, 1, 700)]
    [InlineData(4, "[[0,1,100],[1,2,100],[2,0,100]]", 0, 3, 1, -1)]
    [InlineData(3, "[[0,1,100],[1,2,100],[0,2,500]]", 0, 2, 1, 200)]
    [InlineData(3, "[[0,1,100],[1,2,100],[0,2,500]]", 0, 2, 0, 500)]
    public void FindCheapestPrice(int n, string flights, int src, int dst, int k, int expected)
    {
        var actual = _0787_FindCheapestPrice.FindCheapestPrice(n, flights.To2dArr(), src, dst, k);
        Assert.Equal(expected, actual);
    }
}