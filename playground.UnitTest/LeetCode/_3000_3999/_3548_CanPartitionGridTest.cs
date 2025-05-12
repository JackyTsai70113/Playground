using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3548_CanPartitionGridTest
{
    [Theory]
    [InlineData("[[1,4],[2,3]]", true)]
    [InlineData("[[1,2],[3,4]]", true)]
    [InlineData("[[1,2,4],[2,3,5]]", false)]
    [InlineData("[[4,1,8],[3,2,6]]", false)]
    [InlineData("[[56761],[100000],[100000],[100000],[100000]]", true)]
    [InlineData("[[100000],[56761],[100000],[100000],[100000]]", false)]
    [InlineData("[[1],[1],[1],[1],[2]]", true)]
    [InlineData("[[1,1,1,1,2]]", true)]
    [InlineData("[[1,2,1],[9,9,9]]", false)]
    [InlineData("[[1,1,1],[3,2,1]]", true)]
    [InlineData("[[100000],[100000],[100000],[100000],[1]]", true)]
    [InlineData("[[100000,100000,100000,100000,1]]", true)]
    [InlineData("[[1,2,3,4,10]]", true)]
    [InlineData("[[4,3,7],[5,3,3]]", true)]
    public void CanPartitionGrid(string arr, bool expected)
    {
        var grid = arr.To2dArr();
        var result = _3548_CanPartitionGrid.CanPartitionGrid(grid);
        Assert.Equal(expected, result);
    }
}
