namespace playground.UnitTest;

public class MinimumOperationsTest3122
{
    [Theory]
    [InlineData("[[1,0,2],[1,0,2]]", 0)]
    [InlineData("[[1,1,1],[0,0,0]]", 3)]
    [InlineData("[[1],[2],[3]]", 2)]
    [InlineData("[[9,4,1],[3,5,1],[9,6,6]]", 4)]
    [InlineData("[[4,2,2],[8,2,5],[1,5,2]]", 5)]
    public void MinimumOperations(string grid, int expected)
    {
        var actual = MinimumOperations3122.MinimumOperations(grid.To2dArr());
        Assert.Equal(expected, actual);
    }
}
