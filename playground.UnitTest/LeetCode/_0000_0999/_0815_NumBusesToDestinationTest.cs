using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0815_NumBusesToDestinationTest
{
    [Theory]
    [InlineData("[[1,7],[3,5]]", 5, 5, 0)]
    [InlineData("[[1,2,7],[3,6,7]]", 1, 6, 2)]
    [InlineData("[[7,12],[4,5,15],[6],[15,19],[9,12,13]]", 18, 12, -1)]
    [InlineData("[[7,12],[4,5,15],[6],[15,19],[9,12,13]]", 15, 12, -1)]
    [InlineData("[[7,12],[4,5,15],[6],[15,19],[9,12,13]]", 12, 12, 0)]
    public void NumBusesToDestination(string routes, int source, int target, int expected)
    {
        var actual = _0815_NumBusesToDestination.NumBusesToDestination(routes.To2dArr(), source, target);
        Assert.Equal(expected, actual);
    }
}
