namespace playground.UnitTest;

public class MinimumTotalTest0120
{
    [Theory]
    [InlineData("[[2],[3,4],[6,5,7],[4,1,8,3]]", 11)]
    [InlineData("[[-10]]", -10)]
    [InlineData("[[-1],[3,2],[-3,1,-1]]", -1)]
    public void MinimumTotal(string A, int expected)
    {
        var actual = MinimumTotal0120.MinimumTotal(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
