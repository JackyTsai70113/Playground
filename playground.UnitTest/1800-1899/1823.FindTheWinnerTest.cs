namespace playground.UnitTest;

public class FindTheWinnerTest1823
{
    [Theory]
    [InlineData(5, 2, 3)]
    [InlineData(6, 5, 1)]
    public void FindTheWinner(int n, int k, char expected)
    {
        var actual = FindTheWinner1823.FindTheWinner(n, k);
        Assert.Equal(expected, actual);
    }
}
