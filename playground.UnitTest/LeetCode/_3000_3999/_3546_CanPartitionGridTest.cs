using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3546_CanPartitionGridTest
{
    [Theory]
    [InlineData("[[1,4],[2,3]]", true)]
    [InlineData("[[1,2],[4,3]]", true)]
    [InlineData("[[1,3],[2,4]]", false)]
    [InlineData("[[1,1],[2,1]]", false)]
    public void Test(string arr, bool expected)
    {
        var grid = arr.To2dArr();
        var result = _3546_CanPartitionGrid.CanPartitionGrid(grid);
        Assert.Equal(expected, result);
    }
}
