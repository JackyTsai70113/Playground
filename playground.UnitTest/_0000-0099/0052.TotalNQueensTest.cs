namespace playground.UnitTest;

public class TotalNQueensTest0052
{
    [Theory]
    [InlineData(4, 2)]
    [InlineData(1, 1)]
    public void TotalNQueens(int n, int expected)
    {
        var actual = TotalNQueens0052.TotalNQueens(n);
        Assert.Equal(expected, actual);
    }
}
