namespace playground.UnitTest;

public class _3025_NumberOfPairsTest
{
    [Theory]
    [InlineData("[[1,1],[2,2],[3,3]]", 0)]
    [InlineData("[[6,2],[4,4],[2,6]]", 2)]
    [InlineData("[[3,1],[1,3],[1,1]]", 2)]
    public void NumberOfPairs(string A, int expected)
    {
        var actual = _3025_NumberOfPairs.NumberOfPairs(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
