namespace playground.UnitTest;

public class _1823_FindTheWinnerTest
{
    [Theory]
    [InlineData(5, 2, 3)]
    [InlineData(6, 5, 1)]
    public void FindTheWinner(int n, int k, char expected)
    {
        var actual = _1823_FindTheWinner.FindTheWinner(n, k);
        Assert.Equal(expected, actual);
    }
}
