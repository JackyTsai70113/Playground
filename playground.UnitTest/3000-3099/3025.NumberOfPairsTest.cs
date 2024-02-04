namespace playground.UnitTest;

public class NumberOfPairsTest3025
{
    [Theory]
    [InlineData("[[1,1],[2,2],[3,3]]", 0)]
    [InlineData("[[6,2],[4,4],[2,6]]", 2)]
    [InlineData("[[3,1],[1,3],[1,1]]", 2)]
    public void NumberOfPairs(string A, int expected)
    {
        var actual = NumberOfPairs3025.NumberOfPairs(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
