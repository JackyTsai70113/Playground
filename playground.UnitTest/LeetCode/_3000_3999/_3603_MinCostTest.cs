using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3603_MinCostTest
{
    [Theory]
    [InlineData(1, 2, "[[1,2]]", 3)]
    [InlineData(2, 2, "[[3,5],[2,4]]", 9)]
    [InlineData(2, 3, "[[6,1,4],[3,2,5]]", 16)]
    public void MinCost(int m, int n, string waitCost, long expected)
    {
        // Act
        var actual = _3603_MinCost.MinCost(m, n, waitCost.To2dArr());
        // Assert
        Assert.Equal(expected, actual);
    }
}
