namespace playground.UnitTest.LeetCode._3000_3999;

public class _3122_MinimumOperationsTest
{
    [Theory]
    [InlineData("[[1,0,2],[1,0,2]]", 0)]
    [InlineData("[[1,1,1],[0,0,0]]", 3)]
    [InlineData("[[1],[2],[3]]", 2)]
    [InlineData("[[9,4,1],[3,5,1],[9,6,6]]", 4)]
    [InlineData("[[4,2,2],[8,2,5],[1,5,2]]", 5)]
    public void MinimumOperations(string grid, int expected)
    {
        var actual = _3122_MinimumOperations.MinimumOperations(grid.To2dArr());
        Assert.Equal(expected, actual);
    }
}
