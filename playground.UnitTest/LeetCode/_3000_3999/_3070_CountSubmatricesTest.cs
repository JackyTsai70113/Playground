namespace playground.UnitTest;

public class _3070_CountSubmatricesTest
{
    [Theory]
    [InlineData("[[7,6,3],[6,6,1]]", 18, 4)]
    [InlineData("[[7,2,9],[1,5,0],[2,6,6]]", 20, 6)]
    public void CountSubmatrices(string grid, int k, int expected)
    {
        var actual = _3070_CountSubmatrices.CountSubmatrices(grid.To2dArr(), k);
        Assert.Equal(expected, actual);
    }
}
