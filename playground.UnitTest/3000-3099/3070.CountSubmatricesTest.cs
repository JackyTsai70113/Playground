namespace playground.UnitTest;

public class CountSubmatricesTest3070
{
    [Theory]
    [InlineData("[[7,6,3],[6,6,1]]", 18, 4)]
    [InlineData("[[7,2,9],[1,5,0],[2,6,6]]", 20, 6)]
    public void CountSubmatrices(string grid, int k, int expected)
    {
        var actual = CountSubmatrices3070.CountSubmatrices(grid.To2dArr(), k);
        Assert.Equal(expected, actual);
    }
}
