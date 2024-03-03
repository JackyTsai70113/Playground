namespace playground.UnitTest;

public class MinimumOperationsToWriteYTest3071
{
    [Theory]
    [InlineData("[[1,2,2],[1,1,0],[0,1,0]]", 3)]
    [InlineData("[[0,1,0,1,0],[2,1,0,1,2],[2,2,2,0,1],[2,2,2,2,2],[2,1,2,2,2]]", 12)]
    public void MinimumOperationsToWriteY(string grid, int expected)
    {
        var actual = MinimumOperationsToWriteY3071.MinimumOperationsToWriteY(grid.To2dArr());
        Assert.Equal(expected, actual);
    }
}
